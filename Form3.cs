using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;


namespace contact_tracing_program
{
    public partial class Form3 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;


        public Form3()
        {
            InitializeComponent();
        }

        private void CTloginlabel_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                CTcombobox.Items.Add(Device.Name);

            CTcombobox.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[CTcombobox.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();

        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning==true)
                FinalFrame.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e, Bitmap image)
        {
            //BarcodeReaderGeneric reader = new BarcodeReaderGeneric();
           // Bitmap image = (Bitmap)pictureBox1.Image;
           // Result result = reader.Decode(image);
            //try
            {
                //string decoded = result.ToString().Trim();
               // if (decoded !="")
                {
                   // CTloginlabel.Text = decoded;
                }
            }
            //catch(Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //timer1.Start();
        }
    }
}
