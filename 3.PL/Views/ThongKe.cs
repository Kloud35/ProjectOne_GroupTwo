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
        private IThongKeServices _iThongkeservices;
        public List<ThongKeView> _lstthongke;
        IHDTCCTServices _iHDTCCTServices;
        IHDTACTServices _iHDTACTServices;
        IHDDCCTServices _iHDDCCTServices;
        IHoaDonServices _iHoaDonServices;
        List<HoaDonChiTietView> _lstHoaDonChiTietViews;
        decimal thanhtien;
        public ThongKe()
        {
            InitializeComponent();
            _iThongkeservices = new ThongKeServices();
            _iHDTCCTServices = new HDTCCTServices();
            _iHDTACTServices = new HDTACTServices();
            _iHDDCCTServices = new HDDCCTServices();
            _iHoaDonServices = new HoaDonServices();
            _lstHoaDonChiTietViews = new List<HoaDonChiTietView>();
        }

        private void Load_Data_ThuCung()
        {
            int stt = 1;
            _lstHoaDonChiTietViews.Clear();
            dtg_thucung.ColumnCount = 3;
            dtg_thucung.Rows.Clear();
            dtg_thucung.Columns[0].Name = "STT";
            dtg_thucung.Columns[1].Name = "Thú Cưng";
            dtg_thucung.Columns[2].Name = "Số lượng";
            _iHDTCCTServices.GetAll().GroupBy(x => x.IdSp).ToList().ForEach(e =>
            {
                _lstHoaDonChiTietViews.Add(new HoaDonChiTietView
                {
                    IdSp = e.Key,
                    SoLuong = e.Sum(p => p.SoLuong)
                });
            });
            foreach (var x in _lstHoaDonChiTietViews)
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
            _lstHoaDonChiTietViews.Clear();
            dtg_thucan.Columns[0].Name = "STT";
            dtg_thucan.Columns[1].Name = "Thức Ăn";
            dtg_thucan.Columns[2].Name = "Số lượng";

            _iHDTACTServices.GetAll().GroupBy(x => x.IdSp).ToList().ForEach(e =>
            {
                _lstHoaDonChiTietViews.Add(new HoaDonChiTietView
                {
                    IdSp = e.Key,
                    SoLuong = e.Sum(p => p.SoLuong)
                });
            });
            foreach (var x in _lstHoaDonChiTietViews)
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
            _lstHoaDonChiTietViews.Clear();
            dtg_dochoi.Columns[0].Name = "STT";
            dtg_dochoi.Columns[1].Name = "Đồ chơi";
            dtg_dochoi.Columns[2].Name = "Số lượng";
            _iHDDCCTServices.GetAll().GroupBy(x => x.IdSp).ToList().ForEach(e =>
            {
                _lstHoaDonChiTietViews.Add(new HoaDonChiTietView
                {
                    IdSp = e.Key,
                    SoLuong = e.Sum(p => p.SoLuong)
                });
            });
            foreach (var x in _lstHoaDonChiTietViews)
            {
                var ten = _iHDDCCTServices.GetAll().FirstOrDefault(p => p.IdSp == x.IdSp).Ten;
                dtg_dochoi.Rows.Add(stt++, ten, x.SoLuong);
            }
        }
        private string ChangeFormatMoney(decimal value)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);
        }
        private void Load_Data_ThongTin()
        {
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
            var list = _iHoaDonServices.GetAll();
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
            }

        }

        private void Dis()
        {
            dtp_day.Visible = false;
            cbb_quy.Visible = false;
            cbb_thang.Visible = false;
            cbb_nam.Visible = false;
        }
        private void LoadData()
        {
            Load_Data_ThuCung();
            Load_Data_ThucAn();
            Load_Data_DoChoi();
            Load_Data_ThongTin();
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            //LoadData();
        }

        private void ThongKe_Theongay()
        {
            int Count = 0;
            dtg_dochoi.Rows.Clear();
            dtg_thongtin.Rows.Clear();
            dtg_thucan.Rows.Clear();
            dtg_thucung.Rows.Clear();

            dtp_day.Visible = true;
            cbb_thang.Visible = false;
            cbb_nam.Visible = false;
            cbb_quy.Visible = false;
            thanhtien = 0;

            var _list = _iHoaDonServices.GetAll().Where(x => x.NgayTao.ToString("MM/dd/yyyy") == dtp_day.Value.ToString("MM/dd/yyyy")).ToList();
            //   var _list = _iHoaDonServices.GetAll().Where(x => (x.NgayTao.Day == dtp_day.Value.Day) && (x.NgayTao.Month == dtp_day.Value.Month)).ToList();     
            foreach (var x in _list)
            {
                LoadData();
                Count++;
            }
            lb_hoadon.Text = Count.ToString();
            lb_tdt.Text = ChangeFormatMoney(thanhtien);
        }

        private void tsmi_theongay_Click(object sender, EventArgs e)
        {
            dtg_dochoi.Rows.Clear();
            dtg_thongtin.Rows.Clear();
            dtg_thucan.Rows.Clear();
            dtg_thucung.Rows.Clear();
            lb_hoadon.Text = "";
            lb_tdt.Text = "";
            ThongKe_Theongay();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            Dis();
        }

        private void tmsi_tuan_Click(object sender, EventArgs e)
        {
            dtg_dochoi.Rows.Clear();
            dtg_thongtin.Rows.Clear();
            dtg_thucan.Rows.Clear();
            dtg_thucung.Rows.Clear();
            lb_hoadon.Text = "";
            lb_tdt.Text = "";

            dtp_day.Visible = false;
            cbb_nam.Visible = false;
            cbb_quy.Visible = false;
            cbb_thang.Visible = false;
            var listtuan = _iThongkeservices.GetAll();
            foreach (var x in listtuan)
            {
                TimeSpan ts;
                DateTime Ngaytao = Convert.ToDateTime(x.NgayTaoHD);
                DateTime ToDay = Convert.ToDateTime(DateTime.Now);

                ts = (Ngaytao - ToDay);
                int TongSoNgay = Convert.ToInt32(Math.Abs(ts.TotalDays));

                if (TongSoNgay <= 7)
                {
                    LoadData();
                    var _list = _iHoaDonServices.GetAll();
                    int Count = 0;
                    foreach (var item in _list)
                    {

                        Count++;
                        lb_hoadon.Text = Count.ToString();
                        lb_tdt.Text = ChangeFormatMoney(thanhtien);
                    }
                }



                //if (x.MaHD != null)
                //{
                //    lb_tdt.Text = (x.SoluongThu * (Convert.ToInt32(x.GiaThuCung)) + x.SLThucAn * (Convert.ToInt32(x.GiaThucAn)) + x.SLDoChoi * (Convert.ToInt32(x.GiaDoChoi))).ToString();
                //    lb_hoadon.Text = (x.MaHD).Count().ToString();
                //    lb_khachhang.Text = (x.SDTKH).Count().ToString();
                //}

            }
        }

        private void Nam_TK()
        {
            int stt = 1;
            decimal tongtien = 0;
            thanhtien = 0;
            dtg_thongtin.ColumnCount = 6;
            dtg_thongtin.Rows.Clear();
            dtg_thongtin.Columns[0].Name = "STT";
            dtg_thongtin.Columns[1].Name = "Mã hóa đơn";
            dtg_thongtin.Columns[2].Name = "Năm bán";
            dtg_thongtin.Columns[3].Name = "Nhân viên";
            dtg_thongtin.Columns[4].Name = "Giảm giá (%)";
            dtg_thongtin.Columns[5].Name = "Tổng tiền";
            var tc = _iHDTCCTServices.GetAll();
            var ta = _iHDTACTServices.GetAll();
            var dc = _iHDDCCTServices.GetAll();
            var list = _iHoaDonServices.GetAll();
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
                dtg_thongtin.Rows.Add(stt++, x.Ma, x.NgayTao.Year, x.TenNv, x.PhanTramGiamGia, tongtien);
                thanhtien += tongtien;
                tongtien = 0;
            }
        }

        private void tmsi_thang_Click(object sender, EventArgs e)
        {
            dtg_dochoi.Rows.Clear();
            dtg_thongtin.Rows.Clear();
            dtg_thucan.Rows.Clear();
            dtg_thucung.Rows.Clear();
            lb_hoadon.Text = "";
            lb_tongdoanhthu.Text = "";

            cbb_thang.Visible = true;
            dtp_day.Visible = false;
            cbb_nam.Visible = false;
            cbb_quy.Visible = false;
            if (cbb_thang.Text != "")
            {
                _lstthongke = _iThongkeservices.GetAll().Where(x => (x.NgayTaoHD.Month.ToString() == cbb_thang.Text)).ToList();
                foreach (var x in _lstthongke)
                {
                    LoadData();
                    var _list = _iHoaDonServices.GetAll();
                    int Count = 0;
                    foreach (var item in _list)
                    {
                        Count++;
                    }
                    lb_hoadon.Text = Count.ToString();
                    lb_tdt.Text = ChangeFormatMoney(thanhtien);
                }
            }

        }

        private void tmsi_quy_Click(object sender, EventArgs e)
        {
            dtg_dochoi.Rows.Clear();
            dtg_thongtin.Rows.Clear();
            dtg_thucan.Rows.Clear();
            dtg_thucung.Rows.Clear();
            lb_hoadon.Text = "";
            lb_tdt.Text = "";

            cbb_quy.Visible = true;
            cbb_nam.Visible = false;
            cbb_thang.Visible = false;
            dtp_day.Visible = false;
            if (cbb_quy.Text != "")
            {
                _lstthongke = _iThongkeservices.GetAll();
                foreach (var x in _lstthongke)
                {
                    if (x.NgayTaoHD.Month <= 3 && x.NgayTaoHD.Month >= 1 && cbb_quy.Text == "1")
                    {
                        LoadData();
                        int Count = 0;
                        var _list = _iHoaDonServices.GetAll();
                        foreach (var item in _list)
                        {
                            Count++;
                        }
                        lb_hoadon.Text = Count.ToString();
                        lb_tdt.Text = ChangeFormatMoney(thanhtien);

                    }
                    else if (x.NgayTaoHD.Month > 3 && x.NgayTaoHD.Month <= 6 && cbb_quy.Text == "2")
                    {
                        LoadData();
                        int Count = 0;
                        var _list = _iHoaDonServices.GetAll();
                        foreach (var item in _list)
                        {
                            Count++;
                        }
                        lb_hoadon.Text = Count.ToString();
                        lb_tdt.Text = ChangeFormatMoney(thanhtien);
                    }
                    else if (x.NgayTaoHD.Month > 6 && x.NgayTaoHD.Month <= 9 && cbb_quy.Text == "3")
                    {
                        LoadData();
                        int Count = 0;
                        var _list = _iHoaDonServices.GetAll();
                        foreach (var item in _list)
                        {
                            Count++;
                        }
                        lb_hoadon.Text = Count.ToString();
                        lb_tdt.Text = ChangeFormatMoney(thanhtien);
                    }
                    else if (x.NgayTaoHD.Month > 9 && x.NgayTaoHD.Month <= 12 && cbb_quy.Text == "4")
                    {
                        LoadData();
                        int Count = 0;
                        var _list = _iHoaDonServices.GetAll();
                        foreach (var item in _list)
                        {
                            Count++;
                        }
                        lb_hoadon.Text = Count.ToString();
                        lb_tdt.Text = ChangeFormatMoney(thanhtien);

                    }
                }
            }
        }
        private void tmsi_nam_Click(object sender, EventArgs e)
        {
            LoadNam();
            dtg_dochoi.Rows.Clear();
            dtg_thongtin.Rows.Clear();
            dtg_thucan.Rows.Clear();
            dtg_thucung.Rows.Clear();
            lb_hoadon.Text = "";
            lb_tdt.Text = "";

            cbb_nam.Visible = true;
            cbb_quy.Visible = false;
            cbb_thang.Visible = false;
            dtp_day.Visible = false;
            if (cbb_nam.Text != "")
            {
                int Count = 0;
                var _list = _iHoaDonServices.GetAll().Where(x => (x.NgayTao.Year.ToString() == cbb_nam.Text)).ToList();
                foreach (var x in _list)
                {
                    Load_Data_ThuCung();
                    Load_Data_ThucAn();
                    Load_Data_DoChoi();
                    Nam_TK();
                    Count++;
                }
                lb_hoadon.Text = Count.ToString();
                lb_tdt.Text = ChangeFormatMoney(thanhtien);
            }
        }
 

        private void LoadNam()
        {
            for (int i = 2020; i < 2025; i++)
            {
                cbb_nam.Items.Add(i);
            }

        }

        private void txt_searchSP_TextChanged(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_thucung.ColumnCount = 5;
            dtg_thucung.Rows.Clear();
            dtg_thucung.Columns[0].Name = "STT";
            dtg_thucung.Columns[1].Name = "Mã hóa đơn";
            dtg_thucung.Columns[2].Name = "Thú Cưng";
            dtg_thucung.Columns[3].Name = "Số lượng";
            dtg_thucung.Columns[4].Name = "Giá Bán";

            dtg_thucan.ColumnCount = 5;
            dtg_thucan.Rows.Clear();
            dtg_thucan.Columns[0].Name = "STT";
            dtg_thucan.Columns[1].Name = "Mã hóa đơn";
            dtg_thucan.Columns[2].Name = "Thức Ăn";
            dtg_thucan.Columns[3].Name = "Số lượng";
            dtg_thucan.Columns[4].Name = "Giá Bán";

            dtg_dochoi.ColumnCount = 5;
            dtg_dochoi.Rows.Clear();
            dtg_dochoi.Columns[0].Name = "STT";
            dtg_dochoi.Columns[1].Name = "Mã hóa đơn";
            dtg_dochoi.Columns[2].Name = "Đồ chơi";
            dtg_dochoi.Columns[3].Name = "Số lượng";
            dtg_dochoi.Columns[4].Name = "Giá Bán";

            dtg_thongtin.ColumnCount = 7;
            dtg_thongtin.Rows.Clear();
            dtg_thongtin.Columns[0].Name = "STT";
            dtg_thongtin.Columns[1].Name = "Mã hóa đơn";
            dtg_thongtin.Columns[2].Name = "Giảm giá (%)";
            dtg_thongtin.Columns[3].Name = "Ngày mua hàng";
            dtg_thongtin.Columns[4].Name = "Nhân Viên";
            dtg_thongtin.Columns[5].Name = "Khách Hàng";
            dtg_thongtin.Columns[6].Name = "SĐT KH";


            var list = _iThongkeservices.GetAll();

            if (txt_searchSP.Text != "")
            {
                list = list.Where(x => x.MaHD.ToLower().Contains(txt_searchSP.Text.ToLower()) || x.TenThucAn.ToLower().Contains(txt_searchSP.Text.ToLower()) || x.TenThuCung.ToLower().Contains(txt_searchSP.Text.ToLower()) || x.TenDoChoi.ToLower().Contains(txt_searchSP.Text.ToLower())).ToList();
            }
            foreach (var x in list)
            {
                dtg_thucung.Rows.Add(stt++, x.MaHD, x.TenThuCung, x.SoluongThu, x.GiaThuCung);
                dtg_thucan.Rows.Add(stt++, x.MaHD, x.TenThucAn, x.SLThucAn, x.GiaThucAn);
                dtg_dochoi.Rows.Add(stt++, x.MaHD, x.TenDoChoi, x.SLDoChoi, x.GiaDoChoi);
                dtg_thongtin.Rows.Add(stt++, x.MaHD, x.PhanTramGiamGia, x.NgayTaoHD, x.HoNV + " " + x.TenDemNV + " " + x.TenVN, x.HoKH + " " + x.TenDemKH + " " + x.TenKH, x.SDTKH);
            }
        }

        private void txt_searchKH_TextChanged(object sender, EventArgs e)
        {
            int stt = 1;
            dtg_thucung.ColumnCount = 5;
            dtg_thucung.Rows.Clear();
            dtg_thucung.Columns[0].Name = "STT";
            dtg_thucung.Columns[1].Name = "Mã hóa đơn";
            dtg_thucung.Columns[2].Name = "Thú Cưng";
            dtg_thucung.Columns[3].Name = "Số lượng";
            dtg_thucung.Columns[4].Name = "Giá Bán";

            dtg_thucan.ColumnCount = 5;
            dtg_thucan.Rows.Clear();
            dtg_thucan.Columns[0].Name = "STT";
            dtg_thucan.Columns[1].Name = "Mã hóa đơn";
            dtg_thucan.Columns[2].Name = "Thức Ăn";
            dtg_thucan.Columns[3].Name = "Số lượng";
            dtg_thucan.Columns[4].Name = "Giá Bán";

            dtg_dochoi.ColumnCount = 5;
            dtg_dochoi.Rows.Clear();
            dtg_dochoi.Columns[0].Name = "STT";
            dtg_dochoi.Columns[1].Name = "Mã hóa đơn";
            dtg_dochoi.Columns[2].Name = "Đồ chơi";
            dtg_dochoi.Columns[3].Name = "Số lượng";
            dtg_dochoi.Columns[4].Name = "Giá Bán";

            dtg_thongtin.ColumnCount = 7;
            dtg_thongtin.Rows.Clear();
            dtg_thongtin.Columns[0].Name = "STT";
            dtg_thongtin.Columns[1].Name = "Mã hóa đơn";
            dtg_thongtin.Columns[2].Name = "Giảm giá (%)";
            dtg_thongtin.Columns[3].Name = "Ngày mua hàng";
            dtg_thongtin.Columns[4].Name = "Nhân Viên";
            dtg_thongtin.Columns[5].Name = "Khách Hàng";
            dtg_thongtin.Columns[6].Name = "SĐT KH";


            var list = _iThongkeservices.GetAll();

            if (txt_searchKH.Text != "")
            {
                list = list.Where(x => x.SDTKH.ToLower().Contains(txt_searchSP.Text.ToLower())).ToList();
            }
            foreach (var x in list)
            {
                dtg_thucung.Rows.Add(stt++, x.MaHD, x.TenThuCung, x.SoluongThu, x.GiaThuCung);
                dtg_thucan.Rows.Add(stt++, x.MaHD, x.TenThucAn, x.SLThucAn, x.GiaThucAn);
                dtg_dochoi.Rows.Add(stt++, x.MaHD, x.TenDoChoi, x.SLDoChoi, x.GiaDoChoi);
                dtg_thongtin.Rows.Add(stt++, x.MaHD, x.PhanTramGiamGia, x.NgayTaoHD, x.HoNV + " " + x.TenDemNV + " " + x.TenVN, x.HoKH + " " + x.TenDemKH + " " + x.TenKH, x.SDTKH);
            }
        }

        private void dtp_day_ValueChanged(object sender, EventArgs e)
        {
            ThongKe_Theongay();
        }
    }
}
