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
    public partial class QLThucAn : UserControl
    {
        IThucAnServices _iThucAnServices;
        Guid _id;
        private string imgLocation;
        private string barcodeLocation;

        public QLThucAn()
        {
            InitializeComponent();
            _iThucAnServices = new ThucAnServices();
        }
        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 9;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Columns[4].Name = "Loại";
            dtgv_Show.Columns[5].Name = "Số lượng tồn";
            dtgv_Show.Columns[6].Name = "Nhà sản xuất";
            dtgv_Show.Columns[7].Name = "Giá nhập";
            dtgv_Show.Columns[8].Name = "Giá bán";
            List<ThucAnView> list = _iThucAnServices.GetAll();
            if (tbt_Search.Texts != "")
            {
                list = _iThucAnServices.GetAll().Where(p => p.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.Ten, item.Loai, item.SoLuongTon, item.Nsx,
                    item.GiaNhap, item.GiaBan);
            }
        }



        private void QLThucAn_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new ThucAnView()
            {
                Id = Guid.NewGuid(),
                IdThucAn = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts,
                Loai = tbt_Loai.Texts,
                GiaNhap = Convert.ToDecimal(tbt_GiaNhap.Texts),
                GiaBan = Convert.ToDecimal(tbt_GiaBan.Texts),
                SoLuongTon = Convert.ToInt32(tbt_SoLuong.Texts),
                Nsx = tbt_Nsx.Texts,
                Image = imgLocation,
                Barcode = barcodeLocation
            };
            if (_iThucAnServices.Add(x))
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
            var x = _iThucAnServices.GetAll().FirstOrDefault(p => p.Id.Equals(_id));
            x.Ma = tbt_Ma.Texts;
            x.Ten = tbt_Ten.Texts;
            x.Loai = tbt_Loai.Texts;
            x.GiaNhap = Convert.ToDecimal(tbt_GiaNhap.Texts);
            x.GiaBan = Convert.ToDecimal(tbt_GiaBan.Texts);
            x.SoLuongTon = Convert.ToInt32(tbt_SoLuong.Texts);
            x.Nsx = tbt_Nsx.Texts;
            x.Image = imgLocation;
            x.Barcode = barcodeLocation;
            if (_iThucAnServices.Update(x))
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var x = _iThucAnServices.GetAll().FirstOrDefault(p => p.Id.Equals(_id));
            if (_iThucAnServices.Delete(x))
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                _id = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var obj = _iThucAnServices.GetAll().FirstOrDefault(p => p.Id.Equals(_id));
                tbt_Ma.Texts = obj.Ma;
                tbt_Ten.Texts = obj.Ten;
                tbt_Loai.Texts = obj.Loai;
                tbt_GiaBan.Texts = obj.GiaBan.ToString();
                tbt_GiaNhap.Texts = obj.GiaNhap.ToString();
                tbt_SoLuong.Texts = obj.SoLuongTon.ToString();
                tbt_Nsx.Texts = obj.Nsx;
                ptb_Image.Image = Image.FromFile(obj.Image);
                ptb_Barcode.Image = Image.FromFile(obj.Image);
                imgLocation = obj.Image;
                barcodeLocation = obj.Barcode;
            }
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ptb_Image.Image = Image.FromFile(fileDialog.FileName);
                imgLocation = fileDialog.FileName;
                tbt_ImagePath.Texts = imgLocation;
            }
        }

        private void btn_AddBarcode_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ptb_Barcode.Image = Image.FromFile(fileDialog.FileName);
                barcodeLocation = fileDialog.FileName;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Texts = "";
            tbt_Ten.Texts = "";
            tbt_Loai.Texts = "";
            tbt_SoLuong.Texts = "";
            tbt_GiaNhap.Texts = "";
            tbt_GiaBan.Texts = "";
            tbt_Search.Texts = "";
            tbt_Nsx.Texts = "";
            ptb_Image.Image = null;
            ptb_Barcode.Image = null;
            dtgv_Show.Rows.Clear();
        }

        private void tbt_Search__TextChanged(object sender, EventArgs e)
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 9;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Columns[4].Name = "Loại";
            dtgv_Show.Columns[5].Name = "Số lượng tồn";
            dtgv_Show.Columns[6].Name = "Nhà sản xuất";
            dtgv_Show.Columns[7].Name = "Giá nhập";
            dtgv_Show.Columns[8].Name = "Giá bán";
            List<ThucAnView> list = _iThucAnServices.GetAll();
            if (tbt_Search.Texts != "")
            {
                list = _iThucAnServices.GetAll().Where(p => p.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.Ten, item.Loai, item.SoLuongTon, item.Nsx,
                    item.GiaNhap, item.GiaBan);
            }
        }
    }
}