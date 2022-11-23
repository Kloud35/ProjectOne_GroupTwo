using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using SixLabors.ImageSharp.Drawing.Processing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _3.PL.Views
{
    public partial class QLNhanVien : UserControl
    {
        INhanVienServices _iNhanVienServices;
        IChucVuServices _iChucVuServices;
        ICuaHangServices _iCuaHangServices;
        Guid currentId;
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
            if (tbt_Search.Texts != "")
            {
                list = _iNhanVienServices.GetAll().Where(x => x.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.HoVaTen, item.NgaySinh, item.GioiTinh, item.Sdt, item.Email, item.MatKhau, item.ChucVu, item.CuaHang, item.DiaChi, item.ThanhPho, item.QuocGia, item.TrangThai == 0 ? "Hoạt động" : "Không hoạt động");
            }
        }
        private void LoadToCombobox()
        {
            foreach (var item in _iChucVuServices.GetAll())
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
                TrangThai = cbb_TrangThai.SelectedIndex,
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


        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                var x = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Id == currentId);
                x.Ma = tbt_Ma.Texts;
                x.Ho = tbt_Ho.Texts;
                x.TenDem = tbt_TenDem.Texts;
                x.Ten = tbt_Ten.Texts;
                x.NgaySinh = dtp_NgaySinh.Value;
                x.GioiTinh = rbn_GtNam.Checked ? "Nam" : "Nữ";
                x.Sdt = tbt_Sdt.Texts;
                x.Email = tbt_Email.Texts;
                x.DiaChi = tbt_DiaChi.Texts;
                x.ThanhPho = tbt_ThanhPho.Texts;
                x.QuocGia = tbt_QuocGia.Texts;
                x.MatKhau = tbt_MatKhau.Texts;
                x.TrangThai = cbb_TrangThai.SelectedIndex;
                x.IdCh = _iCuaHangServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_CuaHang.Texts)).Id;
                x.IdCv = _iChucVuServices.GetAll().FirstOrDefault(x => x.Ten.Equals(cbb_ChucVu.Texts)).Id;
                if (_iNhanVienServices.Update(x))
                {
                    MessageBox.Show("Sửa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var x = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Id == currentId);
                if (_iNhanVienServices.Delete(x))
                {
                    MessageBox.Show("Xóa thành công");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                currentId = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var x = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Id == currentId);
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
                tbt_Email.Texts = x.Email;
                tbt_DiaChi.Texts = x.DiaChi;
                tbt_ThanhPho.Texts = x.ThanhPho;
                tbt_QuocGia.Texts = x.QuocGia;
                tbt_MatKhau.Texts = x.MatKhau;
                if (x.TrangThai == 0)
                {
                    cbb_TrangThai.SelectedIndex = 0;
                }
                else
                {
                    cbb_TrangThai.SelectedIndex = 1;
                }
                cbb_ChucVu.Texts = x.ChucVu;
                cbb_CuaHang.Texts = x.CuaHang;
            }
        }
    }
}
