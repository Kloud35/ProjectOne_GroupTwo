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
    public partial class FrmThongTinTaiKhoan : Form
    {
        NhanVienView _view;
        public FrmThongTinTaiKhoan(NhanVienView nhanVienView)
        {
            InitializeComponent();
            _view = nhanVienView;
        }

        private void FrmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            lbl_Ten.Text = _view.HoVaTen;
            lbl_Sdt.Text = _view.Sdt;
            lbl_ChucVu.Text = _view.ChucVu;
            lbl_MatKhau.Text = _view.MatKhau;
            ptb_Avata.Image = Image.FromFile(_view.Image);
        }
    }
}
