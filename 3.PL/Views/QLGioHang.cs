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
using ZXing;
using _2.BUS.IServices;
using _2.BUS.Services;

namespace _3.PL.Views
{
    public partial class QLGioHang : UserControl
    {
        INhanVienServices _iNhanVienServices;
        IDoChoiServices _iDoChoiServices;
        IThucAnServices _iThucAnServices;
        IThuCungServices _iThuCungServices;
        public QLGioHang()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            _iDoChoiServices = new DoChoiServices();
            _iThucAnServices = new ThucAnServices();
            _iThuCungServices = new ThuCungServices();
        }
        //FilterInfoCollection filterInfoCollection;
        //VideoCaptureDevice videoCaptureDevice;

        private void QLGioHang_Load(object sender, EventArgs e)
        {
            //filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            //videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            //videoCaptureDevice.Start();
        }

        //private async void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        //{
        //    Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
        //    //foreach (var result in results)
        //    //{
        //    //    if (result != null)
        //    //    {
        //    //        tbt_TongTien.Invoke(new MethodInvoker(delegate ()
        //    //        {
        //    //            tbt_TongTien.Texts = result.ToString();
        //    //        }));
        //    //    }
        //    //}
        //    ptb_Scan.Image = bitmap;
        //}
        private void QLGioHang_Leave(object sender, EventArgs e)
        {

            //if (videoCaptureDevice.IsRunning)
            //{
            //    videoCaptureDevice.Stop();
            //}
        }

        private void dtgv_ThuCung_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
