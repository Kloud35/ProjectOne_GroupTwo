using AForge.Video.DirectShow;
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
using IronBarCode;

namespace _3.PL.Views
{
    public partial class QLGioHang : UserControl
    {
        public QLGioHang()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void QLGioHang_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private async void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            BarcodeResults results = BarcodeReader.Read(bitmap);
            foreach (var result in results)
            {
                if (result != null)
                {
                    tbt_TongTien.Invoke(new MethodInvoker(delegate ()
                    {
                        tbt_TongTien.Texts = result.ToString();
                    }));
                }
            }
            ptb_Scan.Image = bitmap;
        }

        private void QLGioHang_Leave(object sender, EventArgs e)
        {

            if (videoCaptureDevice.IsRunning)
            {
                videoCaptureDevice.Stop();
            }
        }

    }
}
