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
using System.Drawing.Imaging;
using _2.BUS.ViewModels;

namespace _3.PL.Views
{
    public partial class QLGioHang : UserControl
    {
        INhanVienServices _iNhanVienServices;
        IDoChoiServices _iDoChoiServices;
        IThucAnServices _iThucAnServices;
        IThuCungServices _iThuCungServices;
        IKhachHangServices _iKhachHangServices;
        IHoaDonServices _iHoaDonServices;
        NhanVienView nv;
        List<HoaDonChiTietView> hdct;
        public QLGioHang()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            _iDoChoiServices = new DoChoiServices();
            _iThucAnServices = new ThucAnServices();
            _iThuCungServices = new ThuCungServices();
            _iKhachHangServices = new KhachHangServices();
            _iHoaDonServices = new HoaDonServices();
            hdct = new List<HoaDonChiTietView>();
        }
        
        public void GetNhanVien(NhanVienView nhanVienView)
        {
            nv = nhanVienView;
            MessageBox.Show(nhanVienView.Ten);
        }

        private void QLGioHang_Load(object sender, EventArgs e)
        {
            LoadData();
            FrmMain frmMain = new FrmMain();
            frmMain.Push = new FrmMain.PushNhanVien(GetNhanVien);
        }
        public string CreateKey()
        {
            string ma = "HD";
            DateTime dateTime = DateTime.Now;
            string d = String.Format($"{dateTime.Day}{dateTime.Month}{dateTime.Year}_{dateTime.Hour}{dateTime.Minute}{dateTime.Second}");
            ma = ma + d;
            return ma;
        }
        public Image resizeImage(int newWidth, int newHeight, string stPhotoPath)
        {
            Image imgPhoto = Image.FromFile(stPhotoPath);

            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;

            //Consider vertical pics
            if (sourceWidth < sourceHeight)
            {
                int buff = newWidth;

                newWidth = newHeight;
                newHeight = buff;
            }

            int sourceX = 0, sourceY = 0, destX = 0, destY = 0;
            float nPercent = 0, nPercentW = 0, nPercentH = 0;

            nPercentW = ((float)newWidth / (float)sourceWidth);
            nPercentH = ((float)newHeight / (float)sourceHeight);
            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((newWidth -
                          (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((newHeight -
                          (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);


            Bitmap bmPhoto = new Bitmap(newWidth, newHeight,
                          PixelFormat.Format24bppRgb);

            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                         imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode =
                System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            imgPhoto.Dispose();
            return bmPhoto;
        }

        private void LoadData()
        {
            dtgv_HoaDon.Columns.Clear();
            //Hóa đơn
            dtgv_HoaDon.ColumnCount = 5;
            dtgv_HoaDon.Columns[0].Name = "ID";
            dtgv_HoaDon.Columns[0].Visible = false;
            dtgv_HoaDon.Columns[1].Name = "Mã hóa đơn";
            dtgv_HoaDon.Columns[2].Name = "Tên nhân viên";
            dtgv_HoaDon.Columns[3].Name = "Ngày tạo";
            dtgv_HoaDon.Columns[4].Name = "Trạng thái";
            //Thú cưng
            dtgv_ThuCung.ColumnCount = 3;
            dtgv_ThuCung.Columns[0].Name = "ID";
            dtgv_ThuCung.Columns[0].Visible = false;
            dtgv_ThuCung.Columns[1].Name = "Tên";
            dtgv_ThuCung.Columns[2].Name = "Image";
            dtgv_ThuCung.Columns[2].ValueType = typeof(Image);
            //Thức ăn
            dtgv_ThucAn.ColumnCount = 3;
            dtgv_ThucAn.Columns[0].Name = "ID";
            dtgv_ThucAn.Columns[0].Visible = false;
            dtgv_ThucAn.Columns[1].Name = "Tên";
            dtgv_ThucAn.Columns[2].Name = "Image";
            dtgv_ThucAn.Columns[2].ValueType = typeof(Image);
            //Đồ chơi
            dtgv_DoChoi.ColumnCount = 3;
            dtgv_DoChoi.Columns[0].Name = "ID";
            dtgv_DoChoi.Columns[0].Visible = false;
            dtgv_DoChoi.Columns[1].Name = "Tên";
            dtgv_DoChoi.Columns[2].Name = "Image";
            dtgv_DoChoi.Columns[2].ValueType = typeof(Image);
            foreach (var x in _iThuCungServices.GetAll())
            {
                Image image = resizeImage(50, 50, x.Image);
                dtgv_ThuCung.Rows.Add(x.IdTCCT, x.Ten, image);
            }
            foreach (var x in _iThucAnServices.GetAll())
            {
                Image image = resizeImage(50, 50, x.Image);
                dtgv_ThucAn.Rows.Add(x.Id, x.Ten, image);
            }
            foreach (var x in _iDoChoiServices.GetAll())
            {
                Image image = resizeImage(50, 50, x.Image);
                dtgv_DoChoi.Rows.Add(x.Id, x.Ten, image);
            }
            foreach (var x in _iHoaDonServices.GetAll())
            {
                dtgv_HoaDon.Rows.Add(x.Id,x.Ma, x.TenNv,x.NgayTao, x.TinhTrang == 0 ? "Chưa thanh toán ..." : "Đã thanh toán");
            }
        }

        private void dtgv_ThuCung_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_TaoHoaDon_Click(object sender, EventArgs e)
        {

            var khvl = _iKhachHangServices.GetAll().FirstOrDefault(x => x.Ma == "KH00");
            var x = new HoaDonView()
            {
                Id = Guid.NewGuid(),
                Ma = CreateKey(),
                NgayTao = DateTime.Now,
                NgayThanhToan = DateTime.Now,
                NgayGiaoHang = DateTime.Now,
                NgayNhan = DateTime.Now,
                TienCoc = 0,
                TienShip = 0,
                TenNguoiNhan = khvl.HoVaTen,
                IdKhachHang = khvl.Id,
                IdNhanVien = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Ma == "admin").Id,
                DiaChi = khvl.DiaChi,
                TinhTrang = 0,
                Sdt = khvl.Sdt,
                PhanTramGiamGia = 0
            };
            if (_iHoaDonServices.Add(x))
            {
                LoadData();
            }
        }
    }
}
