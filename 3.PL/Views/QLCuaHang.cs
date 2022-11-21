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
    public partial class QLCuaHang : UserControl
    {
        ICuaHangServices _iCuaHangServices;
        public QLCuaHang()
        {
            InitializeComponent();
            _iCuaHangServices = new CuaHangServices();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new CuaHangView()
            {
                Id = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts,
                DiaChi = tbt_DiaChi.Texts,
                Sdt = tbt_Sdt.Texts
            };
            if (_iCuaHangServices.Add(x))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
    }
}
