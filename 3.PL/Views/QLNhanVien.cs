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
    public partial class QLNhanVien : UserControl
    {
        INhanVienServices _iNhanVienServices;
        IChucVuServices _iChucVuServices;
        ICuaHangServices _iCuaHangServices;
        public QLNhanVien()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            _iChucVuServices = new ChucVuServices();
            _iCuaHangServices = new CuaHangServices();
        }

        private void QLNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadToCombobox();
        }

        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 14;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Họ và tên";
            dtgv_Show.Columns[3].Name = "Ngày sinh";
            dtgv_Show.Columns[4].Name = "Giới tính";
            dtgv_Show.Columns[5].Name = "Sđt";
            dtgv_Show.Columns[6].Name = "Email";
            dtgv_Show.Columns[7].Name = "Mật khẩu";
            dtgv_Show.Columns[8].Name = "Chức vụ";
            dtgv_Show.Columns[9].Name = "Cửa hàng";
            dtgv_Show.Columns[10].Name = "Địa chỉ";
            dtgv_Show.Columns[11].Name = "Thành phố";
            dtgv_Show.Columns[12].Name = "Quốc gia";
            dtgv_Show.Columns[13].Name = "Trạng thái";
            var list = _iNhanVienServices.GetAll();
            foreach(var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.HoVaTen, item.NgaySinh, item.GioiTinh, item.Sdt, item.Email, item.MatKhau, item.ChucVu, item.CuaHang, item.DiaChi, item.ThanhPho, item.QuocGia, item.TrangThai);
            }
        }
        private void LoadToCombobox()
        {
            foreach(var item in _iChucVuServices.GetAll())
            {
                cbb_ChucVu.Items.Add(item.Ten);
            }
            foreach (var item in _iCuaHangServices.GetAll())
            {
                cbb_CuaHang.Items.Add(item.Ten);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new NhanVienView()
            {
                Id = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ho = tbt_Ho.Texts,
                TenDem = tbt_TenDem.Texts,
                Ten = tbt_Ten.Texts,
                NgaySinh = dtp_NgaySinh.Value,
                GioiTinh = rbn_GtNam.Checked ? "Nam" : "Nữ",
                Sdt = tbt_Sdt.Texts,
                Email = tbt_Email.Texts,
                DiaChi = tbt_DiaChi.Texts,
                ThanhPho = tbt_ThanhPho.Texts,
                QuocGia = tbt_QuocGia.Texts,
                MatKhau = tbt_MatKhau.Texts,
                TrangThai = Convert.ToInt32(cbb_TrangThai.Texts),
                IdCh = _iCuaHangServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_CuaHang.Texts)).Id,
                IdCv = _iChucVuServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_ChucVu.Texts)).Id
            };
            if (_iNhanVienServices.Add(x))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
