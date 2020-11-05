using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = true;


        private delegate void SafeCallDelegate();

        public Form1()
        {
            InitializeComponent();

            this.Closed += Form1_Closed;
        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            isCameraRunning = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.TopMost = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;

            Application.AddMessageFilter(new AltKeyFilter());

            CaptureCamera();

        }
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {
                    //Thread.Sleep(100);

                    capture.Read(frame);
                    image = new Bitmap(BitmapConverter.ToBitmap(frame), pictureBox1.Width, pictureBox1.Height);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose();
                    }

                    int averageR = 0;
                    int averageG = 0;
                    int averageB = 0;

                    for (int i = 0; i < pictureBox1.Width; i++)
                    {
                        for (int j = 0; j < pictureBox1.Height; j++)
                        {
                            Color pixelColor = image.GetPixel(i, j);

                            averageR += pixelColor.R;
                            averageG += pixelColor.G;
                            averageB += pixelColor.B;
                        }
                    }

                    averageR /= (image.Width * image.Height);
                    averageG /= (image.Width * image.Height);
                    averageB /= (image.Width * image.Height);

                    Color averageColor = Color.FromArgb(averageR, averageG, averageB);

                    try
                    {

                        pictureBox1.Invoke(new SafeCallDelegate((() =>
                        {
                            try
                            {
                                pictureBox1.Image = image;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Failed to set image");
                            }
                        })));

                        pictureBox2.Invoke(new SafeCallDelegate((() =>
                        {
                            pictureBox2.BackColor = averageColor;
                        })));

                        labelRValue.Invoke(new SafeCallDelegate((() =>
                        {
                            labelRValue.Text = averageR.ToString();
                        })));

                        labelGValue.Invoke(new SafeCallDelegate((() =>
                        {
                            labelGValue.Text = averageG.ToString();
                        })));

                        labelBValue.Invoke(new SafeCallDelegate((() =>
                        {
                            labelBValue.Text = averageB.ToString();
                        })));


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to invoke methods: " + ex.Message);
                    }
                }
            }
        }


        public void SomeMethod()
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private class AltKeyFilter : IMessageFilter
        {
            public bool PreFilterMessage(ref Message m)
            {
                return m.Msg == 0x0104 && ((int)m.LParam & 0x20000000) != 0;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.X)
            {
                this.Close();
                Application.Exit();
            }
        }
    }
}