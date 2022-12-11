using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.Utilities;
using _2.BUS.ViewModels;
using _3.PL.Properties;
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
        string imgLocation;
        public QLKhachHang()
        {
            InitializeComponent();
            _iKhachHangServices = new KhachHangServices();
        }
        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 10;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Họ và tên";
            dtgv_Show.Columns[4].Name = "Ngày sinh";
            dtgv_Show.Columns[5].Name = "Giới tính";
            dtgv_Show.Columns[6].Name = "Sđt";
            dtgv_Show.Columns[7].Name = "Địa chỉ";
            dtgv_Show.Columns[8].Name = "Thành phố";
            dtgv_Show.Columns[9].Name = "Quốc gia";
            var list = _iKhachHangServices.GetAll();
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.HoVaTen, item.NgaySinh, item.GioiTinh, item.Sdt, item.DiaChi, item.ThanhPho, item.QuocGia);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            
            if (_iKhachHangServices.GetAll().Any(x=>x.Ma==tbt_Ma.Texts))
            {
                MessageBox.Show("Mã khách hàng đã tồn tại");
            }
            else if (tbt_Ma.Texts == "" || tbt_Ho.Texts == "" || tbt_TenDem.Texts == "" || tbt_Ten.Texts == "" || tbt_Sdt.Texts == "" || tbt_DiaChi.Texts == "" || tbt_ThanhPho.Texts == "" || tbt_QuocGia.Texts == "")
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin !");
            }
            else
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
                    Image = imgLocation

                };
                _iKhachHangServices.Add(x);
                MessageBox.Show("Thêm khách hàng thành công");
                LoadData();
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
                Image = imgLocation
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
            ptb_Image.Image = Resources.illustration_profile_icon_avatar_inhabitant_male_illustration_profile_icon_avata_237916010;
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tbt_Ma__TextChanged(object sender, EventArgs e)
        {
            lb_Checkma.Text = Validates.CheckEmpty(tbt_Ma.Texts);
            lb_Checkma.ForeColor = Color.Red;
            lb_Checkma.Font = new Font(lb_Checkma.Font, lb_Checkma.Font.Style | FontStyle.Italic);
        }

        private void tbt_Ho__TextChanged(object sender, EventArgs e)
        {
            lb_Checkho.Text = Validates.CheckEmpty(tbt_Ho.Texts);
            lb_Checkho.ForeColor = Color.Red;
            lb_Checkho.Font = new Font(lb_Checkho.Font, lb_Checkho.Font.Style | FontStyle.Italic);
        }

        private void tbt_TenDem__TextChanged(object sender, EventArgs e)
        {
            lb_checktendem.Text = Validates.CheckEmpty(tbt_TenDem.Texts);
            lb_checktendem.ForeColor = Color.Red;
            lb_checktendem.Font = new Font(lb_checktendem.Font, lb_checktendem.Font.Style | FontStyle.Italic);
        }

        private void tbt_Ten__TextChanged(object sender, EventArgs e)
        {
            lb_Checkten.Text = Validates.CheckEmpty(tbt_Ten.Texts);
            lb_Checkten.ForeColor = Color.Red;
            lb_Checkten.Font = new Font(lb_Checkten.Font, lb_Checkten.Font.Style | FontStyle.Italic);
        }

        private void tbt_Sdt__TextChanged(object sender, EventArgs e)
        {
            lb_Checksdt.Text = Validates.CheckSdt(tbt_Sdt.Texts);
            lb_Checksdt.ForeColor = Color.Red;
            lb_Checksdt.Font = new Font(lb_Checksdt.Font, lb_Checksdt.Font.Style | FontStyle.Italic);
        }

        private void tbt_DiaChi__TextChanged(object sender, EventArgs e)
        {
            lb_Checkdiachi.Text = Validates.CheckEmpty(tbt_DiaChi.Texts);
            lb_Checkdiachi.ForeColor = Color.Red;
            lb_Checkdiachi.Font = new Font(lb_Checkdiachi.Font, lb_Checkdiachi.Font.Style | FontStyle.Italic);
        }

        private void tbt_ThanhPho__TextChanged(object sender, EventArgs e)
        {
            lb_Checkthanhpho.Text = Validates.CheckEmpty(tbt_ThanhPho.Texts);
            lb_Checkthanhpho.ForeColor = Color.Red;
            lb_Checkthanhpho.Font = new Font(lb_Checkthanhpho.Font, lb_Checkthanhpho.Font.Style | FontStyle.Italic);
        }

        private void tbt_QuocGia__TextChanged(object sender, EventArgs e)
        {
            lb_Checkquocgia.Text = Validates.CheckEmpty(tbt_QuocGia.Texts);
            lb_Checkquocgia.ForeColor = Color.Red;
            lb_Checkquocgia.Font = new Font(lb_Checkquocgia.Font, lb_Checkquocgia.Font.Style | FontStyle.Italic);
        }

        private void dtgv_Show_CellClick_1(object sender, DataGridViewCellEventArgs e)
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
                ptb_Image.Image = Image.FromFile(x.Image);
                imgLocation = x.Image;
            }
        }

        private void ptb_Image_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                ptb_Image.Image = Image.FromFile(fileDialog.FileName);
                imgLocation = fileDialog.FileName;
            }
        }
    }
}

