using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleCounting
{
    public partial class CenterOfGravity : Form
    {
        Image<Gray, byte> image=null;
        public CenterOfGravity()
        {
            InitializeComponent();
            image = new Image<Gray, byte>(@"E:\College\PCD\image to enhance\img_to_moment.png");
            
            calcualteCenterOfGravity();
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

            for (int i = 100; i < 200; i++)
            {
                for (int j = 100; j < 200; j++)
                {
                    image.Data[i, j, 0] = 255;
                }
            }
            CvInvoke.Imshow("Image", image);
        }
        private void calcualteCenterOfGravity()
        {
            try
            {
                int horizontalCenter = moment(1, 0) / moment(0, 0);
                int verticalCenter = moment(0, 1) / moment(0, 0);

                Console.WriteLine("HorizontalCenter : " + horizontalCenter + ", VerticalCenter : " + verticalCenter);
                Image<Rgb, byte> imageRGB = new Image<Rgb, byte>(image.ToBitmap());
                for (int i= -5; i <= 5; i++){
                    for(int j = -5; j <= 5; j++)
                    {
                        imageRGB.Data[verticalCenter + i, horizontalCenter + j, 1] = 200;
                    }
                }

                ibxGravityCenter.Image = imageRGB;
            }catch(Exception exception)
            {
                MessageBox.Show("Error !\n" + exception.StackTrace);
                
            }
        }
        
        private int moment(int p, int q)
        {
            int momentPQ=0;
            Console.WriteLine("Entering begining moment method");
            for(int u = 0; u < image.Height; u++)
            {
                for(int v = 0; v < image.Width; v++)
                {
                    momentPQ += (int) (Math.Pow(u, p) * Math.Pow(v, q) * image.Data[u, v, 0]);
                }
            }
            Console.WriteLine("entering end of moment method");

            return momentPQ;
        }
    }
}
