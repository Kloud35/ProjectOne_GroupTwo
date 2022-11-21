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
    public partial class FrmLogin : Form
    {
        NhanVienView viewLogin;
        INhanVienServices _iNhanVienServices;
        public FrmLogin()
        {
            InitializeComponent();
            viewLogin = new NhanVienView();
            _iNhanVienServices = new NhanVienServices();
        }
        public delegate void Login(NhanVienView viewLogin);
        public Login OnLogin;
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            viewLogin = _iNhanVienServices.GetAll().FirstOrDefault(x => x.Sdt == tbt_Sdt.Texts && x.MatKhau == tbt_MatKhau.Texts);
            
            if (_iNhanVienServices.Login(viewLogin))
            {
                MessageBox.Show("Đăng nhập thành công");
                OnLogin(viewLogin);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
            }
        }
    }
}
