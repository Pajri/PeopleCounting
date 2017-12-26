using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PeopleCounting
{
    public partial class GrassFire : Form
    {
        Image<Gray, byte> image = null;
        Image<Rgb, byte> result = null;
        List<Blob> detectedBlobs = null;
        List<Pixel> pixelList = null;
        int nPiece = 0;
        public GrassFire()
        {
            InitializeComponent();

            image = new Image<Gray, byte>(@"E:\College\PCD\image to enhance\img_to_moment.png");
            //createBinaryImage();
            CvInvoke.Imshow("binary image",image);
            Image<Gray,byte> temp = image.Clone();
            
            
            result = new Image<Rgb, byte>(image.Width, image.Height);
            //initialize result
            for(int i = 0; i < result.Height; i++)
            {
                for(int j = 0; j < result.Width; j++)
                {
                    result.Data[i, j, 0] = 0;
                    result.Data[i, j, 1] = 0;
                    result.Data[i, j, 2] = 0;
                }
            }

            detectedBlobs = new List<Blob>();

            //do grass  fire
            grassFire();
            Console.WriteLine("nPiece : " + nPiece);

            //Rectangle init = new Rectangle(0, 100, 100, 100);
            //result.Draw(init, new Rgb(255, 0, 0), 2);
            //draw bounding box
            drawBoundingBox();

            ibxGrassFire.Image = result;
            //CvInvoke.Imshow("Image", image);
            //CvInvoke.Imshow("temp", temp);
        }

        private void createBinaryImage()
        {
            image = new Image<Gray, byte>(480, 480);
            for (int i = 0; i < 480; i++)
            {
                for (int j = 0; j < 480; j++)
                {
                    image.Data[i, j, 0] = 0;
                }
            }

            for (int i = 100; i < 150; i++)
            {
                for (int j = 100; j < 150; j++)
                {
                    image.Data[i, j, 0] = 255;
                }
            }
        }

        private void drawBoundingBox()
        {
            int minX, minY, maxX, maxY;
            foreach(Blob blob in detectedBlobs)
            {
                List<Pixel> pixels = blob.pixelList;
                minX = result.Width;
                minY = result.Height;
                maxX = 0;
                maxY = 0;

                for(int i = 0; i < pixels.Count; i++)
                {
                    if (pixels[i].x < minX) minX = pixels[i].x;
                    if (pixels[i].y < minY) minY = pixels[i].y;

                    if (pixels[i].x > maxX) maxX = pixels[i].x;
                    if (pixels[i].y > maxY) maxY = pixels[i].y;
                }
                
                
                Rectangle rect = new Rectangle(minX, minY, maxX-minX, maxY-minY);
                result.Draw(rect, new Rgb(0, 200, 0), 1);
                Console.WriteLine("minX : " + minX + ", minY : " + minY);
                Console.WriteLine("maxX : " + maxX + ", maxY : " + maxY);
            }
        }

        private void grassFire()
        {
            for(int i = 0; i < image.Height; i++)
            {
                for(int j = 0; j < image.Width; j++)
                {
                    if (image.Data[i, j,0] == 255)
                    {
                        pixelList = new List<Pixel>();
                        fireConnectedPixels(i, j);
                        Blob blob = new Blob(""+nPiece,pixelList);
                        detectedBlobs.Add(blob);
                        nPiece++;
                    }
                }
            }
        }

        /*
         * Params
         *  p : index row
         *  q : index col
         */
        private void fireConnectedPixels(int p, int q)
        {
            if(p>=0 && p<image.Height && q>0 && q < image.Width)
            {
                if (image.Data[p, q, 0] == 255)
                {
                    Pixel px = new Pixel(p,q,image.Data[p,q,0]);
                    pixelList.Add(px);

                    image.Data[p, q, 0] = 0;
                    result.Data[p, q, 0] = (byte)(nPiece*10);
                    result.Data[p, q, 0] = (byte)(nPiece * 10+10);
                    result.Data[p, q, 0] = (byte)(nPiece + 100);

                    fireConnectedPixels(p - 1, q);
                    fireConnectedPixels(p + 1, q);
                    fireConnectedPixels(p, q - 1);
                    fireConnectedPixels(p, q + 1);
                }
            }
                
        }
    }
}
