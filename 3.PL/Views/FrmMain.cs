using _2.BUS.IServices;
using _2.BUS.Services;
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
    public partial class FrmMain : Form
    {
        INhanVienServices _iNhanVienServices;
        NhanVienView nv;
        public FrmMain()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
            
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisableButton();
            
        }
        public delegate void PushNhanVien(NhanVienView nhanVienView);
        public PushNhanVien Push;
        private void DisableButton()
        {
            btn_NhanVien.Visible = false;
            btn_ThuCung.Visible = false;
            btn_DoChoi.Visible = false;
            btn_ThucAn.Visible = false;
            btn_KhachHang.Visible = false;
            btn_HoaDon.Visible = false;
            btn_GioHang.Visible = false;
            btn_ThongKe.Visible = false;
            btn_TaiKhoan.Visible = false;
        }
        

        private void OpenUserControl(UserControl userControl)
        {
            this.pn_Desktop.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            this.pn_Desktop.Controls.Add(userControl);
        }
        private void Login(NhanVienView viewLogin)
        {
            if(viewLogin.ChucVu == "admin")
            {
                btn_NhanVien.Visible = true;
                btn_ThuCung.Visible = true;
                btn_DoChoi.Visible = true;
                btn_ThucAn.Visible = true;
                btn_KhachHang.Visible = true;
                btn_HoaDon.Visible = true;
                btn_GioHang.Visible = true;
                btn_ThongKe.Visible = true;
                btn_TaiKhoan.Visible = true;
            }
            else
            {
                btn_NhanVien.Visible = false;
                btn_ThuCung.Visible = true;
                btn_DoChoi.Visible = true;
                btn_ThucAn.Visible = true;
                btn_KhachHang.Visible = true;
                btn_HoaDon.Visible = true;
                btn_GioHang.Visible = true;
                btn_ThongKe.Visible = false;
                btn_TaiKhoan.Visible = true;
            }
            nv = viewLogin;
            ptb_Avata.Image = new Bitmap(viewLogin.Image);
            lbl_TenNv.Text ="Chào "+ viewLogin.Ten;
            btn_Login.Image = Resources.logout_24;
            btn_Login.Text = "         Đăng xuất";
            lbl_Login.Text = "";
        }

        private void GetTitle(string title)
        {
            lbl_Title.Text = title;
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            //this.ddm_NhanVien.Show(pn_Control, new Point(247, 267));
            ViewNhanVien viewNhanVien = new ViewNhanVien();
            viewNhanVien.Title = new ViewNhanVien.GetTitle(GetTitle);
            OpenUserControl(viewNhanVien);
        }

        private void btn_ThuCung_Click(object sender, EventArgs e)
        {
            ViewThuCung viewThuCung = new ViewThuCung();
            viewThuCung.Title = new ViewThuCung.GetTitle(GetTitle);
            OpenUserControl(viewThuCung);
        }

        private void btn_DoChoi_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLDoChoi());
            lbl_Title.Text = "Đồ chơi";
        }

        private void btn_ThucAn_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLThucAn());
            lbl_Title.Text = "Thức ăn";
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLKhachHang());
            lbl_Title.Text = "Khách hàng";
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLHoaDon());
            lbl_Title.Text = "Hóa đơn";
        }

        private void btn_GioHang_Click(object sender, EventArgs e)
        {
            
            OpenUserControl(new QLGioHang(nv));
            lbl_Title.Text = "Giỏ hàng";
        }

        private void btn_ThongKe_Click(object sender, EventArgs e)
        {
            OpenUserControl(new ViewNhanVien());
            lbl_Title.Text = "Thống kê";
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            FrmThongTinTaiKhoan frmThongTinTaiKhoan = new FrmThongTinTaiKhoan();
            frmThongTinTaiKhoan.ShowDialog();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(btn_Login.Text == "         Đăng nhập")
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.OnLogin = new FrmLogin.Login(Login);
                frmLogin.ShowDialog();
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn đăng xuất ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    DisableButton();
                    btn_Login.Image = Resources.login_24;
                    btn_Login.Text = "         Đăng nhập";
                    lbl_TenNv.Text = "Shop thú cưng";
                    ptb_Avata.Image = Resources._829207;
                    lbl_Login.Text = "Đăng nhập để sử dụng";
                    lbl_Title.Text = "Dự án quản lý cửa hàng bán thú cưng - Nhóm 2";
                    pn_Desktop.Controls.Clear();
                    pn_Desktop.Controls.Add(ptb_OngVang);
                }
            }
        }

        private void btn_NhanVien_MouseHover(object sender, EventArgs e)
        {
            //this.ddm_NhanVien.Show(pn_Control, new Point(247, 267));
        }
    }
}
