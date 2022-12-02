using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QLKhachHang : UserControl
    {
        IKhachHangServices _iKhachHangServices;
        private Guid id;
        public QLKhachHang()
        {
            InitializeComponent();
            _iKhachHangServices = new KhachHangServices();
        }
        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 12;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Họ";
            dtgv_Show.Columns[4].Name = "Tên đệm";
            dtgv_Show.Columns[5].Name = "Tên";
            dtgv_Show.Columns[6].Name = "Ngày sinh";
            dtgv_Show.Columns[7].Name = "Giới tính";
            dtgv_Show.Columns[8].Name = "Sđt";
            dtgv_Show.Columns[9].Name = "Địa chỉ";
            dtgv_Show.Columns[10].Name = "Thành phố";
            dtgv_Show.Columns[11].Name = "Quốc gia";
            var list = _iKhachHangServices.GetAll();
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.Ho, item.TenDem, item.Ten, item.NgaySinh, item.GioiTinh, item.Sdt, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new KhachHangView()
            {
                Id = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ho = tbt_Ho.Texts,
                TenDem = tbt_TenDem.Texts,
                Ten = tbt_Ten.Texts,
                NgaySinh = dtp_NgaySinh.Value,
                GioiTinh = rbn_GtNam.Checked ? "Nam" : "Nữ",
                Sdt = tbt_Sdt.Texts,
                DiaChi = tbt_DiaChi.Texts,
                ThanhPho = tbt_ThanhPho.Texts,
                QuocGia = tbt_QuocGia.Texts,

            };
            if (_iKhachHangServices.Add(x))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            KhachHangView a = new KhachHangView()
            {
                Id = id,
                Ma = tbt_Ma.Texts,
                Ho = tbt_Ho.Texts,
                TenDem = tbt_TenDem.Texts,
                Ten = tbt_Ten.Texts,
                NgaySinh = dtp_NgaySinh.Value,
                GioiTinh = rbn_GtNam.Checked ? "Nam" : "Nữ",
                Sdt = tbt_Sdt.Texts,
                DiaChi = tbt_DiaChi.Texts,
                ThanhPho = tbt_ThanhPho.Texts,
                QuocGia = tbt_QuocGia.Texts,
            };
            _iKhachHangServices.Update(a);
            LoadData();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (id == Guid.Empty)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng để xóa");

            }
            else
            {
                DialogResult dlg = MessageBox.Show("Bạn có muốn xóa khách hàng không", "Chú ý", MessageBoxButtons.YesNo);
                if (dlg == DialogResult.Yes)
                {
                    _iKhachHangServices.Delete(id);
                    LoadData();
                }
                else
                {
                    LoadData();
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Texts = " ";
            tbt_Ho.Texts = "";
            tbt_TenDem.Texts = "";
            tbt_Ten.Texts = "";
            tbt_Sdt.Texts = "";
            dtp_NgaySinh.Value = DateTime.Now;
            rbn_GtNam.Checked = false;
            rbn_GtNu.Checked = false;
            tbt_DiaChi.Texts = "";
            tbt_ThanhPho.Texts = "";
            tbt_QuocGia.Texts = "";
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                id = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var x = _iKhachHangServices.GetAll().FirstOrDefault(x => x.Id == id);
                tbt_Ma.Texts = x.Ma;
                tbt_Ho.Texts = x.Ho;
                tbt_TenDem.Texts = x.TenDem;
                tbt_Ten.Texts = x.Ten;
                dtp_NgaySinh.Value = x.NgaySinh;
                if (x.GioiTinh == "Nam")
                {
                    rbn_GtNam.Checked = true;
                }
                else
                {
                    rbn_GtNu.Checked = true;
                }
                tbt_Sdt.Texts = x.Sdt;
                tbt_DiaChi.Texts = x.DiaChi;
                tbt_ThanhPho.Texts = x.ThanhPho;
                tbt_QuocGia.Texts = x.QuocGia;
            }
        }

        private void tbt_Search__TextChanged(object sender, EventArgs e)
        {

            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 12;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Họ";
            dtgv_Show.Columns[4].Name = "Tên đệm";
            dtgv_Show.Columns[5].Name = "Tên";
            dtgv_Show.Columns[6].Name = "Ngày sinh";
            dtgv_Show.Columns[7].Name = "Giới tính";
            dtgv_Show.Columns[8].Name = "Sđt";
            dtgv_Show.Columns[9].Name = "Địa chỉ";
            dtgv_Show.Columns[10].Name = "Thành phố";
            dtgv_Show.Columns[11].Name = "Quốc gia";
            var list = _iKhachHangServices.GetAll();
            if (tbt_Search.Texts != "")
            {
                list = _iKhachHangServices.GetAll().Where(x => x.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.Ho, item.TenDem, item.Ten, item.NgaySinh, item.GioiTinh, item.Sdt, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }
    }
}

