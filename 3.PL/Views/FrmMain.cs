﻿using _2.BUS.IServices;
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
    public partial class FrmMain : Form
    {
        INhanVienServices _iNhanVienServices;
        public FrmMain()
        {
            InitializeComponent();
            _iNhanVienServices = new NhanVienServices();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DisableButton();
        }
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
            OpenUserControl(new QLGioHang());
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
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.OnLogin = new FrmLogin.Login(Login);
            frmLogin.ShowDialog();
           
        }

        private void btn_NhanVien_MouseHover(object sender, EventArgs e)
        {
            //this.ddm_NhanVien.Show(pn_Control, new Point(247, 267));
        }
    }
}
