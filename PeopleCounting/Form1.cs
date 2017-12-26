using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.Util.TypeEnum;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Threading;
using Emgu.CV.Cvb;

namespace PeopleCounting
{
    public partial class Form1 : Form
    {
        private Capture capture;
        delegate void SetTextCallback(string text);

        /*variable for updating background*/
        private Boolean isUpdatingBackground = false;
        private int counterCapturedBackground = 0;
        private const int MAX_BACKGROUND_SAMPLES = 5;
        private Image<Gray, byte>[] backgroundSamples = new Image<Gray, byte>[MAX_BACKGROUND_SAMPLES];
        private Image<Gray, byte> background = null;
        /*end of variable for updating background*/

        /*variable for motion detector*/
        private Boolean isDetectingMotion = false;
        private Image<Gray, byte> preImage = null;
        private byte motionThreshold = 100;
        /*end of variable for motion detector*/

        /*variable of subracting background*/
        private byte thresholdBackground = 50;
        private Boolean isSubtractingBackground = false;
        /*end of variable of subracting background*/

        /*variable for detecting center of gravity*/
        Boolean isDetectingCenterOfGravity = false;
        /*end of variable for detecting center of gravity*/

        /*variable for surrounding blob with bounding box*/
        private Boolean isBoundingBlob = false;
        private List<Blob> detectedBlobs = null;
        private List<Pixel> pixelList = null;
        private Image<Gray, byte> tempFiredImage = null;
        private Image<Rgb, byte> boundedImage = null;
        private Image<Rgb, byte> rgbImage = null;
        private int nPiece = 0;
        private int areaThreshold = 200;
        private int centerPoint;
        /*end of variable for surrounding blob with bounding box*/

        /*variable for counting*/
        private const int MAX_FRAME_TRACKING = 2;
        private int[] centerTracking = new int[MAX_FRAME_TRACKING];
        private Boolean isCounting = false;
        private int peopleIn = 0;
        private int peopleOut = 0;
        private int countFrameTracking = 0;
        private int curFrame = -1;
        private int preFrame = -1;
        /*end of variable for counting*/

        public Form1()
        {
            InitializeComponent();
        }

    

        private void btnVidPlay_Click(object sender, EventArgs e)
        {
            try
            {
                capture = new Capture();
                capture.SetCaptureProperty(CapProp.FrameWidth,200);
                capture.SetCaptureProperty(CapProp.FrameHeight, 200);
                capture.SetCaptureProperty(CapProp.Fps, 10);
                capture.ImageGrabbed += ProcessFrame;

                Console.WriteLine("framewidth : " + capture.GetCaptureProperty(CapProp.FrameWidth));
                Console.WriteLine("frameheight : " + capture.GetCaptureProperty(CapProp.FrameHeight));
                capture.Start();
                

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.StackTrace);
                this.txtInfo.Text = exception.Message;
            }

            
        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame, 0);

            Image<Gray, byte> grayImage = frame.ToImage<Gray, byte>();

            if(!isBoundingBlob)
                this.ibxVidRgb.Image = grayImage;
            

            if (isUpdatingBackground)
            {
                backgroundSamples[counterCapturedBackground] = frame.ToImage<Gray, byte>();
                counterCapturedBackground++;
                if (counterCapturedBackground == MAX_BACKGROUND_SAMPLES)
                {
                    isUpdatingBackground = false;
                    counterCapturedBackground = 0;   
                }
            }

            if (isSubtractingBackground)
            {
                ibxVidGray.Image = subtractBackground(grayImage);
            }
 
            /*motion detection operation*/
            if (isDetectingMotion)
            {
                if (preImage != null)
                {
                    Image<Gray, byte> motion = (grayImage - preImage);
                    //find maxByteValue
                    byte max = 0;
                    for (int i = 0; i < motion.Height; i++)
                    {
                        for (int j = 0; j < motion.Width; j++)
                        {
                            if (motion.Data[i, j, 0] > max)
                            {
                                max = motion.Data[i, j, 0];
                            }
                        }
                    }
                    if (max > motionThreshold)
                    {
                        ibxVidGray.Image = grayImage - preImage;
                    }
                    
                }
                preImage = grayImage;
            }
            /*end of motion detection operation*/

            /*center of gravity detection*/
            if (isDetectingCenterOfGravity)
            {
                
                Image<Rgb, byte> imageCenterOfGravity = centerOfGravity(subtractBackground(grayImage));
                ibxVidGray.Image = imageCenterOfGravity;
            }
            /*end of center of gravity detection*/

            /*surrounding blob with bounding box*/
            if (isBoundingBlob) {
                rgbImage = new Image<Rgb, byte>(grayImage.ToBitmap());
                tempFiredImage = subtractBackground(grayImage);
                //initialize bounded image;
                boundedImage = new Image<Rgb, byte>(grayImage.Width, grayImage.Height);
                for(int i = 0; i < boundedImage.Height; i++)
                {
                    for(int j = 0; j < boundedImage.Width; j++)
                    {
                        boundedImage.Data[i, j, 0] = 0;
                        boundedImage.Data[i, j, 1] = 0;
                        boundedImage.Data[i, j, 2] = 0;
                    }
                }

                detectedBlobs = new List<Blob>();
                grassFire();
                drawBoundingBox();
                ibxVidGray.Image = boundedImage;
                ibxVidRgb.Image = rgbImage;
            }
            /*end of surrondin blob with bounding box*/

            if (isCounting)
            {
                double halfWidth = capture.GetCaptureProperty(CapProp.FrameWidth) / 2;
                if (curFrame != 1 && preFrame!=-1)
                {
                    if (preFrame < curFrame)
                    {
                        int incIn = Convert.ToInt32(this.lblIn.Text) + 1;
                        setLblIn(Convert.ToString(incIn));
                    }
                    else if(preFrame > curFrame)
                    {
                        int incOut = Convert.ToInt32(this.lblOut.Text) + 1;
                        setLblOut(Convert.ToString(incOut));
                        
                    }
                }
              
                preFrame = curFrame;
              
                
            }


        }

        private void setLblIn(String text)
        {
            if (this.lblIn.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setLblIn);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblIn.Text = text;
            }
        }

        private void setLblOut(String text)
        {
            if (this.lblOut.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(setLblOut);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.lblOut.Text = text;
            }
        }


        private Image<Gray,byte> subtractBackground(Image<Gray, byte> frame) 
        {
            frame.SmoothMedian(3);
            Image<Gray, byte> subtractedImage = new Image<Gray, byte>(frame.Width, frame.Height);
            for(int i = 0; i < frame.Height; i++)
            {
                for(int j = 0; j < frame.Width; j++)
                {
                    int pixelFrame = (int)frame.Data[i, j, 0];
                    int pixelBackground = (int)background.Data[i, j, 0];
                    int result = Math.Abs(pixelFrame - pixelBackground);
                    int threshold = (int)thresholdBackground;
                    if (result >= threshold) result = 255;
                    else result = 0;
                    subtractedImage.Data[i, j, 0] = (byte) result;
                }
            }

            /*opening*/
            subtractedImage.Erode(1);
            subtractedImage.Dilate(1);
            /*end of opening*/


            return subtractedImage;
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //isUpdatingBackground = true;
            capture.QueryFrame();
            Thread t = new Thread(updateBackground);
            t.Start();
            //t.Join();
            //Console.Write("Thread is stopped");

        }

        private void updateBackground()
        {
            isUpdatingBackground = true;
            while (isUpdatingBackground) ;
            background = new Image<Gray, byte>(backgroundSamples[0].Width, backgroundSamples[0].Height);

            for(int i = 0; i < backgroundSamples[0].Height; i++)
            {
                for(int j = 0; j < backgroundSamples[0].Width; j++)
                {
                    //retrieve data
                    byte[] data = new byte[MAX_BACKGROUND_SAMPLES];
                    for(int k = 0; k < MAX_BACKGROUND_SAMPLES; k++)
                    {
                        data[k] = backgroundSamples[k].Data[i, j, 0];
                    }

                    //sorting data
                    for(int k = 0; k < data.Length-1; k++)
                    {
                        byte min = data[k];
                        for(int l = k + 1; l < data.Length; l++)
                        {
                            if (data[k] > data[l])
                            {
                                byte temp = data[k];
                                data[k] = data[l];
                                data[l] = temp;
                            }
                        }
                    }

                    //median
                    int middleIndex = (int)(MAX_BACKGROUND_SAMPLES / 2);
                    byte median = (byte)((data[middleIndex] + data[middleIndex + (MAX_BACKGROUND_SAMPLES%2)])/2);

                    //create background
                    background.Data[i, j, 0] = median;
                }
            }

            ibxVidGray.Image = background;
        }

        private void motionDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDetectingMotion = true;
           
        }

        private void backgroundSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isSubtractingBackground = true;
        }

        private void centerOfGravityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CenterOfGravity centerOfGravity = new CenterOfGravity();
            centerOfGravity.Show();
        }

        private void centerOfGravityDetectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDetectingCenterOfGravity = !isDetectingCenterOfGravity;
        }

        private Image<Rgb, byte> centerOfGravity(Image<Gray,byte> image)
        {
            Image<Rgb, byte> imageRGB;
            try
            {
                int horizontalCenter = moment(1, 0,image) / moment(0, 0,image);
                int verticalCenter = moment(0, 1,image) / moment(0, 0,image);

                imageRGB = new Image<Rgb, byte>(image.ToBitmap());
                for (int i = -5; i <= 5; i++)
                {
                    for (int j = -5; j <= 5; j++)
                    {
                        int verticalCoord = verticalCenter + i;
                        int horizontalCoord = horizontalCenter + j;

                        if (verticalCoord < 0) verticalCoord = 0;
                        if (verticalCoord > image.Height) verticalCoord = image.Height-1;
                        if (horizontalCoord < 0) horizontalCoord = 0;
                        if (horizontalCoord > image.Width) horizontalCoord = image.Width-1;

                        imageRGB.Data[verticalCoord, horizontalCoord, 0] = 0;
                        imageRGB.Data[verticalCoord, horizontalCoord, 1] = 200;
                        imageRGB.Data[verticalCoord, horizontalCoord, 2] = 0;

                    }
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error !\n" + exception.StackTrace);
                return null;

            }

            return imageRGB;
        }
        private int moment(int p, int q, Image<Gray,byte>image)
        {
            int momentPQ = 0;
            //Console.WriteLine("Entering begining moment method");
            for (int u = 0; u < image.Height; u++)
            {
                for (int v = 0; v < image.Width; v++)
                {
                    momentPQ += (int)(Math.Pow(u, p) * Math.Pow(v, q) * image.Data[u, v, 0]);
                }
            }
            //Console.WriteLine("entering end of moment method");

            return momentPQ;
        }

        private void grassFireAlgorithmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrassFire grassFire = new GrassFire();
            grassFire.Show();
        }

        private void boundBlobToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isBoundingBlob = !isBoundingBlob;
            isCounting = !isCounting;
        }

        private void grassFire()
        {
            for (int i = 0; i < tempFiredImage.Height; i++)
            {
                for (int j = 0; j < tempFiredImage.Width; j++)
                {
                    if (tempFiredImage.Data[i, j, 0] == 255)
                    {
                        pixelList = new List<Pixel>();
                        fireConnectedPixels(i, j);
                        Blob blob = new Blob("" + nPiece, pixelList);
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
            if (p >= 0 && p < tempFiredImage.Height && q > 0 && q < tempFiredImage.Width)
            {
                if (tempFiredImage.Data[p, q, 0] == 255)
                {
                    Pixel px = new Pixel(p, q, tempFiredImage.Data[p, q, 0]);
                    pixelList.Add(px);

                    tempFiredImage.Data[p, q, 0] = 0;

                    boundedImage.Data[p, q, 0] = 255;
                    boundedImage.Data[p, q, 1] = 255;
                    boundedImage.Data[p, q, 2] = 255;
                    

                    fireConnectedPixels(p - 1, q);
                    fireConnectedPixels(p + 1, q);
                    fireConnectedPixels(p, q - 1);
                    fireConnectedPixels(p, q + 1);
                }
            }

        }

        private void drawBoundingBox()
        {
            int minX, minY, maxX, maxY,maxPixels=0;
            foreach (Blob blob in detectedBlobs)
            {
                List<Pixel> pixels = blob.pixelList;
                minX = boundedImage.Width;
                minY = boundedImage.Height;
                maxX = 0;
                maxY = 0;
                if(pixels.Count > areaThreshold) { 
                    for (int i = 0; i < pixels.Count; i++)
                    {
                        if (pixels[i].x < minX) minX = pixels[i].x;
                        if (pixels[i].y < minY) minY = pixels[i].y;

                        if (pixels[i].x > maxX) maxX = pixels[i].x;
                        if (pixels[i].y > maxY) maxY = pixels[i].y;
                    }
                

                    Rectangle rect = new Rectangle(minX, minY, maxX - minX, maxY - minY);
                    boundedImage.Draw(rect, new Rgb(0, 200, 0), 1);
                    rgbImage.Draw(rect, new Rgb(0, 200, 0), 1);

                    if(maxPixels < pixels.Count)
                    {

                        maxPixels = pixels.Count;
                        centerPoint = (int)(((maxX - minX) / 2)+minX);
                        double centerWidth = capture.GetCaptureProperty(CapProp.FrameWidth) / 2;
                        if (centerPoint < centerWidth) curFrame = 0;
                        else curFrame = 1;
                        
                    }
                    
                    //Console.WriteLine("minX : " + minX + ", minY : " + minY);
                    //Console.WriteLine("maxX : " + maxX + ", maxY : " + maxY);
                }
             
            }
        }

        private void btnCountStart_Click(object sender, EventArgs e)
        {
            isCounting = true;
        }

        private void btnCountPause_Click(object sender, EventArgs e)
        {
            isCounting = false;
        }

        private void btnCountStopReset_Click(object sender, EventArgs e)
        {
            isCounting = false;
            peopleIn = 0;
            peopleOut = 0;
        }
    }
}
