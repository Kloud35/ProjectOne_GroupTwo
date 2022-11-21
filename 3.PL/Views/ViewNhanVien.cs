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
    public partial class ViewNhanVien : UserControl
    {
        public ViewNhanVien()
        {
            InitializeComponent();
        }
        public delegate void GetTitle(string title);
        public GetTitle Title;
        private void OpenUserControl(UserControl userControl)
        {
            this.pn_Desktop.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            this.pn_Desktop.Controls.Add(userControl);
        }
        private void tsmi_NhanVien_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLNhanVien());
            tsmi_NhanVien.BackColor = Color.BlueViolet;
            tsmi_NhanVien.ForeColor = Color.White;
            tsmi_ChuVu.BackColor = SystemColors.Control;
            tsmi_ChuVu.ForeColor = Color.Black;
            tsmi_CuaHang.BackColor = SystemColors.Control;
            tsmi_CuaHang.ForeColor = Color.Black;
            Title(tsmi_NhanVien.Text);
        }

        private void tsmi_ChuVu_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLChucVu());
            tsmi_ChuVu.BackColor = Color.BlueViolet;
            tsmi_ChuVu.ForeColor = Color.White;
            tsmi_NhanVien.BackColor = SystemColors.Control;
            tsmi_NhanVien.ForeColor = Color.Black;
            tsmi_CuaHang.BackColor = SystemColors.Control;
            tsmi_CuaHang.ForeColor = Color.Black;
            Title(tsmi_ChuVu.Text);
        }

        private void tsmi_CuaHang_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLCuaHang());
            tsmi_CuaHang.BackColor = Color.BlueViolet;
            tsmi_CuaHang.ForeColor = Color.White;
            tsmi_ChuVu.BackColor = SystemColors.Control;
            tsmi_ChuVu.ForeColor = Color.Black;
            tsmi_NhanVien.BackColor = SystemColors.Control;
            tsmi_NhanVien.ForeColor = Color.Black;
            Title(tsmi_CuaHang.Text);
        }

    }
}
