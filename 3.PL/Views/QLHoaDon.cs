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
    public partial class QLHoaDon : UserControl
    {
        IHoaDonServices _iHoaDonServices;
        IHDTCCTServices _iHDTCCTServices;
        IHDDCCTServices _iHDDCCTServices;
        IHDTACTServices _iHDTACTServices;
        List<HoaDonChiTietView> hdct;
        Guid idhd;
        decimal thanhtien;
        public QLHoaDon()
        {
            InitializeComponent();
            _iHoaDonServices = new HoaDonServices();
            _iHDTCCTServices = new HDTCCTServices();
            _iHDDCCTServices = new HDDCCTServices();
            _iHDTACTServices = new HDTACTServices();
            hdct = new List<HoaDonChiTietView>();
        }
        private void LoadData()
        {
            //Hóa đơn
            dtgv_HoaDon.ColumnCount = 5;
            dtgv_HoaDon.Columns[0].Name = "ID";
            dtgv_HoaDon.Columns[0].Visible = false;
            dtgv_HoaDon.Columns[1].Name = "Mã hóa đơn";
            dtgv_HoaDon.Columns[2].Name = "Tên nhân viên";
            dtgv_HoaDon.Columns[3].Name = "Ngày tạo";
            dtgv_HoaDon.Columns[4].Name = "Trạng thái";
            foreach (var x in _iHoaDonServices.GetAll())
            {
                dtgv_HoaDon.Rows.Add(x.Id, x.Ma, x.TenNv, x.NgayTao, x.TinhTrang == 0 ? "Chưa thanh toán" : "Đã thanh toán");
            }
        }

        private void dtgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_HoaDon.CurrentCell != null && dtgv_HoaDon.CurrentCell.Value != null)
            {
                hdct.Clear();
                idhd = Guid.Parse(dtgv_HoaDon.CurrentRow.Cells[0].Value.ToString());
                var x = _iHoaDonServices.GetAll().FirstOrDefault(x => x.Id == idhd);
                var dcct = _iHDDCCTServices.GetAll().Where(p => p.IdHoaDon == idhd).ToList();
                foreach (var dc in dcct)
                {
                    hdct.Add(dc);
                }

                var tact = _iHDTACTServices.GetAll().Where(p => p.IdHoaDon == idhd);
                foreach (var ta in tact)
                {
                    hdct.Add(ta);
                }
                var tcct = _iHDTCCTServices.GetAll().Where(p => p.IdHoaDon == idhd);
                foreach (var tc in tcct)
                {
                    hdct.Add(tc);
                }
                LoadHDCT();
            }
        }
        private void LoadHDCT()
        {
            thanhtien = 0;
            dtgv_HoaDonCt.Rows.Clear();
            int sc = dtgv_HoaDon.Rows.Count;
            int i = 0;
            foreach (var x in hdct)
            {
                dtgv_HoaDonCt.Rows.Add(x.IdSp, x.Ten, x.SoLuong, ChangeFormatMoney(x.DonGia), ChangeFormatMoney(x.TongTien));
                thanhtien += x.TongTien;
                i++;
            }
            dtgv_HoaDonCt.Rows[i].Cells[4].Value = ChangeFormatMoney(thanhtien);
        }

        private string ChangeFormatMoney(decimal value)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);
        }
        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgv_HoaDonCt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
