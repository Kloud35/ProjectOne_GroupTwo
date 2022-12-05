using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QLDoChoi : UserControl
    {
        IDoChoiServices _iDoChoiServices;
        Guid _id;
        private string imgLocation;
        private string barcodeLocation;
        public QLDoChoi()
        {
            InitializeComponent();
            _iDoChoiServices = new DoChoiServices();

        }
        
        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 9;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã ";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Columns[4].Name = "Loại";
            dtgv_Show.Columns[5].Name = "Số lượng tồn";
            dtgv_Show.Columns[6].Name = "Giá Nhập";
            dtgv_Show.Columns[7].Name = "Giá Bán";
            dtgv_Show.Columns[8].Name = "NSX";
            var list = _iDoChoiServices.GetAll();

            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.Ten, item.Loai, item.SoLuongTon, item.GiaNhap, item.GiaBan,item.Nsx);
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void QLDoChoi_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var y = new DoChoiView()
            {
                Id = Guid.NewGuid(),
                IdDoChoi = Guid.NewGuid(),
                Loai = tbt_Loai.Texts,
                Nsx = tbt_Nsx.Texts,
                SoLuongTon = Convert.ToInt32(tbt_SoLuong.Texts),
                GiaNhap = Convert.ToInt32(tbt_GiaNhap.Texts),
                GiaBan = Convert.ToInt32(tbt_GiaBan.Texts),
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts,
                Image = imgLocation,
                Barcode = barcodeLocation
            };
            if (_iDoChoiServices.Add(y))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
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
            dtgv_Show.Rows.Clear();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var x = _iDoChoiServices.GetAll().FirstOrDefault(p => p.Id.Equals(_id));
            x.Ma = tbt_Ma.Texts;
            x.Ten = tbt_Ten.Texts;
            x.Loai = tbt_Loai.Texts;
            x.GiaNhap = Convert.ToDecimal(tbt_GiaNhap.Texts);
            x.GiaBan = Convert.ToDecimal(tbt_GiaBan.Texts);
            x.SoLuongTon = Convert.ToInt32(tbt_SoLuong.Texts);
            x.Nsx = tbt_Nsx.Texts;
            x.Image = imgLocation;
            x.Barcode = barcodeLocation;
            if (_iDoChoiServices.Update(x))
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                _id = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var obj = _iDoChoiServices.GetAll().FirstOrDefault(p => p.Id.Equals(_id));
                tbt_Ma.Texts = obj.Ma;
                tbt_Ten.Texts = obj.Ten;
                tbt_Loai.Texts = obj.Loai;
                tbt_GiaBan.Texts = obj.GiaBan.ToString();
                tbt_GiaNhap.Texts = obj.GiaNhap.ToString();
                tbt_SoLuong.Texts = obj.SoLuongTon.ToString();
                tbt_Nsx.Texts = obj.Nsx;
                ptb_Image.Image = Image.FromFile(obj.Image);
                ptb_Barcode.Image = Image.FromFile(obj.Barcode);
                tbt_ImagePath.Texts = obj.Image;
                imgLocation = obj.Image;
                barcodeLocation = obj.Barcode;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var x = _iDoChoiServices.GetAll().FirstOrDefault(p => p.Id.Equals(_id));
            if (_iDoChoiServices.Delete(x))
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
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;*.png)|*.jpg; *.jpeg; *.gif; *.bmp;*.png";
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
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ptb_Barcode.Image = Image.FromFile(fileDialog.FileName);
                barcodeLocation = fileDialog.FileName;
            }
        }

        
    }
}
