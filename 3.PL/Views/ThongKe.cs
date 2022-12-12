using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class ThongKe : UserControl
    {
        public List<ThongKeView> _lstthongke;
        IHDTCCTServices _iHDTCCTServices;
        IHDTACTServices _iHDTACTServices;
        IHDDCCTServices _iHDDCCTServices;
        IHoaDonServices _iHoaDonServices;
        List<HoaDonChiTietView> _listhdct;
        decimal thanhtien;
        public ThongKe()
        {
            InitializeComponent();
            _iHDTCCTServices = new HDTCCTServices();
            _iHDTACTServices = new HDTACTServices();
            _iHDDCCTServices = new HDDCCTServices();
            _iHoaDonServices = new HoaDonServices();
            _listhdct = new List<HoaDonChiTietView>();
        }

        private void Load_Data_ThuCung()
        {
            int stt = 1;
            _listhdct.Clear();
            dtg_thucung.ColumnCount = 3;
            dtg_thucung.Rows.Clear();
            dtg_thucung.Columns[0].Name = "STT";
            dtg_thucung.Columns[1].Name = "Thú Cưng";
            dtg_thucung.Columns[2].Name = "Số lượng";
            _iHDTCCTServices.GetAll().GroupBy(x => x.IdSp).ToList().ForEach(e =>
            {
                _listhdct.Add(new HoaDonChiTietView
                {
                    IdSp = e.Key,
                    SoLuong = e.Sum(p => p.SoLuong)
                });
            });
            foreach (var x in _listhdct)
            {
                var ten = _iHDTCCTServices.GetAll().FirstOrDefault(p => p.IdSp == x.IdSp).Ten;
                dtg_thucung.Rows.Add(stt++, ten, x.SoLuong);
            }
        }


        private void Load_Data_ThucAn()
        {
            int stt = 1;
            dtg_thucan.ColumnCount = 3;
            dtg_thucan.Rows.Clear();
            _listhdct.Clear();
            dtg_thucan.Columns[0].Name = "STT";
            dtg_thucan.Columns[1].Name = "Thức Ăn";
            dtg_thucan.Columns[2].Name = "Số lượng";

            _iHDTACTServices.GetAll().GroupBy(x => x.IdSp).ToList().ForEach(e =>
            {
                _listhdct.Add(new HoaDonChiTietView
                {
                    IdSp = e.Key,
                    SoLuong = e.Sum(p => p.SoLuong)
                });
            });
            foreach (var x in _listhdct)
            {
                var ten = _iHDTACTServices.GetAll().FirstOrDefault(p => p.IdSp == x.IdSp).Ten;
                dtg_thucan.Rows.Add(stt++, ten, x.SoLuong);
            }
        }

        private void Load_Data_DoChoi()
        {
            int stt = 1;
            dtg_dochoi.ColumnCount = 3;
            dtg_dochoi.Rows.Clear();
            _listhdct.Clear();
            dtg_dochoi.Columns[0].Name = "STT";
            dtg_dochoi.Columns[1].Name = "Đồ chơi";
            dtg_dochoi.Columns[2].Name = "Số lượng";
            _iHDDCCTServices.GetAll().GroupBy(x => x.IdSp).ToList().ForEach(e =>
            {
                _listhdct.Add(new HoaDonChiTietView
                {
                    IdSp = e.Key,
                    SoLuong = e.Sum(p => p.SoLuong)
                });
            });
            foreach (var x in _listhdct)
            {
                var ten = _iHDDCCTServices.GetAll().FirstOrDefault(p => p.IdSp == x.IdSp).Ten;
                dtg_dochoi.Rows.Add(stt++, ten, x.SoLuong);
            }
        }
        private string ChangeFormatMoney(decimal value)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);
        }

        private void ThongKe_Theongay()
        {
            int Count = 0;
            dtg_dochoi.Rows.Clear();
            dtg_thongtin.Rows.Clear();
            dtg_thucan.Rows.Clear();
            dtg_thucung.Rows.Clear();
            thanhtien = 0;

            int stt = 1;
            decimal tongtien = 0;
            thanhtien = 0;
            dtg_thongtin.ColumnCount = 6;
            dtg_thongtin.Rows.Clear();
            dtg_thongtin.Columns[0].Name = "STT";
            dtg_thongtin.Columns[1].Name = "Mã hóa đơn";
            dtg_thongtin.Columns[2].Name = "Ngày mua hàng";
            dtg_thongtin.Columns[3].Name = "Nhân viên";
            dtg_thongtin.Columns[4].Name = "Giảm giá (%)";
            dtg_thongtin.Columns[5].Name = "Tổng tiền";

            var tc = _iHDTCCTServices.GetAll();
            var ta = _iHDTACTServices.GetAll();
            var dc = _iHDDCCTServices.GetAll();
            var list = _iHoaDonServices.GetAll().Where(x => x.NgayThanhToan.Day >= dtp_day.Value.Day && x.NgayThanhToan.Month >= dtp_day.Value.Month && x.NgayThanhToan.Year >= dtp_day.Value.Year && x.NgayThanhToan.Day <= dtp_daytoday.Value.Day && x.NgayThanhToan.Month <= dtp_daytoday.Value.Month && x.NgayThanhToan.Year <= dtp_daytoday.Value.Year && x.TinhTrang == 1).ToList();

            Load_Data_ThuCung();
            Load_Data_ThucAn();
            Load_Data_DoChoi();

            foreach (var x in list)
            {
                foreach (var t in tc)
                {
                    if (x.Id == t.IdHoaDon)
                    {
                        tongtien += t.TongTien;
                    }
                }
                foreach (var t in ta)
                {
                    if (x.Id == t.IdHoaDon)
                    {
                        tongtien += t.TongTien;
                    }
                }
                foreach (var t in dc)
                {
                    if (x.Id == t.IdHoaDon)
                    {
                        tongtien += t.TongTien;
                    }
                }
                dtg_thongtin.Rows.Add(stt++, x.Ma, x.NgayTao.ToString("d"), x.TenNv, x.PhanTramGiamGia, tongtien);
                thanhtien += tongtien;
                tongtien = 0;
                Count++;
            }
            lb_hoadon.Text = Count.ToString();
            lb_tdt.Text = ChangeFormatMoney(thanhtien);
        }



        private void ThongKe_Load(object sender, EventArgs e)
        {
            ThongKe_Theongay();
        }

        private void dtp_day_ValueChanged(object sender, EventArgs e)
        {
            ThongKe_Theongay();
        }

        private void dtp_daytoday_ValueChanged(object sender, EventArgs e)
        {
            ThongKe_Theongay();
        }
    }
}
