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
        Guid currentId;
        public QLCuaHang()
        {
            InitializeComponent();
            _iCuaHangServices = new CuaHangServices();
        }

        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 6;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Columns[4].Name = "Địa chỉ";
            dtgv_Show.Columns[5].Name = "SĐT";
            var list = _iCuaHangServices.GetAll();
            if(tbt_Search.Texts != "")
            {
                list = _iCuaHangServices.GetAll().Where(x => x.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach(var item in list)
            {
                dtgv_Show.Rows.Add(stt++,item.Id,item.Ma,item.Ten,item.DiaChi,item.Sdt);
            }
        }
        private void Clear()
        {
            tbt_Ma.Texts = "";
            tbt_Ten.Texts = "";
            tbt_Sdt.Texts = "";
            tbt_DiaChi.Texts = "";
            currentId = Guid.Empty;
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
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var x = _iCuaHangServices.GetAll().FirstOrDefault(x => x.Id == currentId);
            x.Ten = tbt_Ten.Texts;
            x.DiaChi = tbt_DiaChi.Texts;
            x.Ma = tbt_Ma.Texts;
            x.Sdt = tbt_Sdt.Texts;
            if (_iCuaHangServices.Update(x))
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var x = _iCuaHangServices.GetAll().FirstOrDefault(x => x.Id == currentId);
            if (_iCuaHangServices.Delete(x))
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
                Clear();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                currentId = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var x = _iCuaHangServices.GetAll().FirstOrDefault(x => x.Id == currentId);
                tbt_Ten.Texts = x.Ten;
                tbt_Ma.Texts = x.Ma;
                tbt_DiaChi.Texts = x.DiaChi;
                tbt_Sdt.Texts = x.Sdt;
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbt_Search__TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
