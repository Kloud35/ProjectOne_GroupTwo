using System;
using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace _3.PL.Views
{
    public partial class QLThuCung : UserControl
    {
        IThuCungServices _iThuCungSv;
        IMauSacService _iMauSacService;
        IGiongLoaiServices _iGiongLoaiServices;
        Guid _id;
        string imgLocation;
        public QLThuCung()
        {
            InitializeComponent();
            _iThuCungSv = new ThuCungServices();
            _iMauSacService = new MauSacService();
            _iGiongLoaiServices = new GiongLoaiServices();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new ThuCungView()
            {
                IdTCCT = Guid.NewGuid(),
                IdThuCung = Guid.NewGuid(),
                IdMauSac = _iMauSacService.GetAll().FirstOrDefault(x => x.Ten == cbb_MauSac.Texts).Id,
                IdGiongLoai = _iGiongLoaiServices.GetAll().FirstOrDefault(x => x.Ten == cbb_GiongLoai.Texts).Id,
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts,
                GiongLoai = cbb_GiongLoai.Texts,
                MauSac = cbb_MauSac.Texts,
                CanNang = Convert.ToDecimal(tbt_CanNang.Texts),
                ChieuDai = Convert.ToDecimal(tbt_ChieuDai.Texts),
                GioiTinh = rbn_GtDuc.Checked ? "Đực" : "Cái",
                SoLuong = Convert.ToInt32(tbt_SoLuong.Texts),
                GiaNhap = Convert.ToDecimal(tbt_GiaNhap.Texts),
                GiaBan = Convert.ToDecimal(tbt_GiaBan.Texts),
                TrangThai = cbb_TrangThai.SelectedIndex,
                Image = imgLocation
            };
            if (_iThuCungSv.Add(x))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void LoadData()
        {
            int stt = 1;
            dtgv_Show.Rows.Clear();
            dtgv_Show.ColumnCount = 13;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Columns[4].Name = "Giống loài";
            dtgv_Show.Columns[5].Name = "Màu sắc";
            dtgv_Show.Columns[6].Name = "Cân nặng";
            dtgv_Show.Columns[7].Name = "Chiều dài";
            dtgv_Show.Columns[8].Name = "Giới tính";
            dtgv_Show.Columns[9].Name = "Số lượng";
            dtgv_Show.Columns[10].Name = "Giá nhập";
            dtgv_Show.Columns[11].Name = "Giá bán";
            dtgv_Show.Columns[12].Name = "Trạng thái";

            List<ThuCungView> list = _iThuCungSv.GetAll();
            if (tbt_Search.Texts != "")
            {
                list = _iThuCungSv.GetAll().Where(p => p.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var x in list)
            {
                dtgv_Show.Rows.Add(stt++, x.IdTCCT, x.Ma, x.Ten, x.GiongLoai, x.MauSac, x.CanNang,
                                    x.ChieuDai, x.GioiTinh, x.SoLuong, x.GiaNhap, x.GiaBan, x.TrangThai == 0 ? "Khỏe mạnh" : "Ốm");
            }
        }
        private void LoadToCombobox()
        {
            foreach (var x in _iMauSacService.GetAll())
            {
                cbb_MauSac.Items.Add(x.Ten);
            }
            foreach (var x in _iGiongLoaiServices.GetAll())
            {
                cbb_GiongLoai.Items.Add(x.Ten);
            }
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_CanNang.Texts = "";
            tbt_Ma.Texts = "";
            tbt_Ten.Texts = "";
            cbb_GiongLoai.Texts = "";
            cbb_MauSac.Texts = "";
            tbt_CanNang.Texts = "";
            tbt_ChieuDai.Texts = "";
            rbn_GtCai.Checked = false;
            rbn_GtDuc.Checked = false;
            tbt_SoLuong.Texts = "";
            tbt_GiaBan.Texts = "";
            cbb_TrangThai.Texts = "";
            tbt_Search.Texts = "";
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var x = _iThuCungSv.GetAll().FirstOrDefault(p => p.IdTCCT.Equals(_id));
            x.IdMauSac = _iMauSacService.GetAll().FirstOrDefault(x => x.Ten == cbb_MauSac.Texts).Id;
            x.IdGiongLoai = _iGiongLoaiServices.GetAll().FirstOrDefault(x => x.Ten == cbb_GiongLoai.Texts).Id;
            x.Ma = tbt_Ma.Texts;
            x.Ten = tbt_Ten.Texts;
            x.GiongLoai = cbb_GiongLoai.Texts;
            x.MauSac = cbb_MauSac.Text;
            x.CanNang = Convert.ToDecimal(tbt_CanNang.Texts);
            x.ChieuDai = Convert.ToDecimal(tbt_ChieuDai.Texts);
            x.GioiTinh = (rbn_GtDuc.Checked ? "Đực" : "Cái");
            x.SoLuong = Convert.ToInt32(tbt_SoLuong.Texts);
            x.GiaNhap = Convert.ToDecimal(tbt_GiaNhap.Texts);
            x.GiaBan = Convert.ToDecimal(tbt_GiaBan.Texts);
            x.TrangThai = cbb_TrangThai.SelectedIndex;
            x.Image = imgLocation;

            if (_iThuCungSv.Update(x))
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void QLThuCung_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadToCombobox();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var x = _iThuCungSv.GetAll().FirstOrDefault(p => p.IdTCCT.Equals(_id));
            if (_iThuCungSv.Delete(x))
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ptb_Image.Image = new Bitmap(fileDialog.FileName);
                imgLocation = fileDialog.FileName;
            }
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                _id = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var TC = _iThuCungSv.GetAll().FirstOrDefault(p => p.IdTCCT.Equals(_id));
                tbt_Ma.Texts = TC.Ma;
                tbt_Ten.Texts = TC.Ten;
                cbb_GiongLoai.Texts = TC.GiongLoai;
                cbb_MauSac.Texts = TC.MauSac;
                tbt_CanNang.Texts = TC.CanNang.ToString();
                tbt_ChieuDai.Texts = TC.ChieuDai.ToString();
                TC.GioiTinh = (rbn_GtDuc.Checked ? "Đực" : "Cái");
                tbt_SoLuong.Texts = TC.SoLuong.ToString();
                tbt_GiaNhap.Texts = TC.GiaNhap.ToString();
                tbt_GiaBan.Texts = TC.GiaBan.ToString();
                cbb_TrangThai.SelectedIndex = TC.TrangThai;
                ptb_Image.Image = new Bitmap(TC.Image);
                imgLocation = TC.Image;
            }
        }
    }
}