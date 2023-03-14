using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterinfocollection;
        VideoCaptureDevice videocapturedevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            filterinfocollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterinfocollection)
            cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videocapturedevice = new VideoCaptureDevice(); 
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            videocapturedevice = new VideoCaptureDevice(filterinfocollection[cboCamera.SelectedIndex].MonikerString);
            videocapturedevice.NewFrame += Videocapturedevice_NewFrame;
            videocapturedevice.Start();
        }

        private void Videocapturedevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pic.Image = (Bitmap)eventArgs.Frame.Clone();        
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videocapturedevice.IsRunning == true)
                videocapturedevice.Stop();
        }
    }
}
