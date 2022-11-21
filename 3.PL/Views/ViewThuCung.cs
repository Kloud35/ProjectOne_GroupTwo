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
    public partial class ViewThuCung : UserControl
    {
        public ViewThuCung()
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
        private void tsmi_GiongLoai_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLGiongLoai());
            tsmi_GiongLoai.BackColor = Color.BlueViolet;
            tsmi_GiongLoai.ForeColor = Color.White;
            tsmi_ThuCung.BackColor = SystemColors.Control;
            tsmi_ThuCung.ForeColor = Color.Black;
            tsmi_MauSac.BackColor = SystemColors.Control;
            tsmi_MauSac.ForeColor = Color.Black;
            Title(tsmi_GiongLoai.Text);
        }

        private void tsmi_ThuCung_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLThuCung());
            tsmi_GiongLoai.BackColor = SystemColors.Control;
            tsmi_GiongLoai.ForeColor = Color.Black;
            tsmi_ThuCung.BackColor = Color.BlueViolet;
            tsmi_ThuCung.ForeColor = Color.White;
            tsmi_MauSac.BackColor = SystemColors.Control;
            tsmi_MauSac.ForeColor = Color.Black;
            Title(tsmi_ThuCung.Text);
        }

        private void tsmi_MauSac_Click(object sender, EventArgs e)
        {
            OpenUserControl(new QLMauSac());
            tsmi_MauSac.BackColor = Color.BlueViolet;
            tsmi_MauSac.ForeColor = Color.White;
            tsmi_ThuCung.BackColor = SystemColors.Control;
            tsmi_ThuCung.ForeColor = Color.Black;
            tsmi_GiongLoai.BackColor = SystemColors.Control;
            tsmi_GiongLoai.ForeColor = Color.Black;
            Title(tsmi_MauSac.Text);
        }
    }
}
