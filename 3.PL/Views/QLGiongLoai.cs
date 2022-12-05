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
    public partial class QLGiongLoai : UserControl
    {
         IGiongLoaiServices _igiongLoaiServices;
         Guid _id;
        public QLGiongLoai()
        {
            InitializeComponent();
            _igiongLoaiServices = new GiongLoaiServices();

        }

        public void LoadData()
        {
            int stt = 1;
            dtgv_Show.ColumnCount = 5;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Columns[4].Name = "Xuất xứ";
            dtgv_Show.Rows.Clear();

            var lstGiongLoai = _igiongLoaiServices.GetAll();
            if (tbt_Search.Texts != " ")
            {
                lstGiongLoai = lstGiongLoai.Where(x => x.Ten.ToLower().Contains(tbt_Search.Text.ToLower())).ToList();
            }
            foreach (var x in lstGiongLoai)
            {
                dtgv_Show.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.XuatXu);
            }
        }
        private void Clear()
        {
            tbt_Ma.Texts = "";
            tbt_Ten.Texts = "";
            tbt_Search.Texts = "";
            tbt_XuatXu.Texts = "";
            _id = Guid.Empty;
        }
        
        private void btn_Them_Click(object sender, EventArgs e)
        {
           var x = new GiongLoaiView()
            {
                Id = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts,
                XuatXu = tbt_XuatXu.Texts
            };
            if (_igiongLoaiServices.Add(x))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
                Clear();
            }
            else if (tbt_Ma.Texts == "" || tbt_Ten.Texts == "" || tbt_XuatXu.Texts == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để thêm");
            }else if(_igiongLoaiServices.GetAll().Any(x=> x.Ma == tbt_Ma.Texts))
            {
                MessageBox.Show("Mã giống loài này đã tồn tại");
                MessageBox.Show("Thêm không thành công");
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var x = _igiongLoaiServices.GetAll().FirstOrDefault(x => x.Id == _id);
                x.Ten = tbt_Ten.Texts;
                x.Ma = tbt_Ma.Texts;
                x.XuatXu = tbt_XuatXu.Texts;
                
                if (_igiongLoaiServices.Update(x))
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

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var x = _igiongLoaiServices.GetAll().FirstOrDefault(x => x.Id == _id);
                if (_igiongLoaiServices.Delete(x))
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
        }


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
            dtgv_Show.Rows.Clear();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                _id = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var x = _igiongLoaiServices.GetAll().FirstOrDefault(x => x.Id == _id);
                tbt_Ten.Texts = x.Ten;
                tbt_Ma.Texts = x.Ma;
                tbt_XuatXu.Texts = x.XuatXu;
            }

            //_id = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
            //var GL = _igiongLoaiServices.GetAll().FirstOrDefault(c => c.Id == _id);
            //tbt_Ma.Texts = GL.Ma;
            //tbt_Ten.Texts = GL.Ten;
            //tbt_XuatXu.Texts = GL.XuatXu;
        }

        private void tbt_Search__TextChanged_1(object sender, EventArgs e)
        {
            int stt = 1;
            dtgv_Show.ColumnCount = 5;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Columns[4].Name = "Xuất xứ";
            dtgv_Show.Rows.Clear();

            var lstGiongLoai = _igiongLoaiServices.GetAll();
            if (tbt_Search.Texts != " ")
            {
                lstGiongLoai = lstGiongLoai.Where(x => x.Ten.ToLower().Contains(tbt_Search.Text.ToLower())).ToList();
            }
            foreach (var x in lstGiongLoai)
            {
                dtgv_Show.Rows.Add(stt++, x.Id, x.Ma, x.Ten, x.XuatXu);
            }
        }
    }
}
