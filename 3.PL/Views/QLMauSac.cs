using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Views
{
    public partial class QLMauSac : UserControl
    {
        IMauSacService _imauSacService;
        Guid _id;
        public QLMauSac()
        {
            InitializeComponent();
            _imauSacService = new MauSacService();

        }
        public void LoadData()
        {
            int stt = 1;
            dtgv_Show.ColumnCount = 4;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "Id";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Rows.Clear();
            var lstMauSac = _imauSacService.GetAll();
            if (tbt_Search.Texts != "")
            {
                lstMauSac = lstMauSac.Where(x => x.Ten.ToLower().Contains(tbt_Search.Text.ToLower())).ToList();
            }
            foreach (var x in lstMauSac)
            {
                dtgv_Show.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }

        private void Clear()
        {
            tbt_Ma.Texts = "";
            tbt_Search.Texts = "";
            tbt_Ten.Texts = "";
            _id = Guid.Empty;
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new MauSacView()
            {
                Id = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts
            };
            if (_imauSacService.Add(x))
            {
                MessageBox.Show("Thêm thành công");
                Clear();
                LoadData();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Texts = "";
            tbt_Ten.Texts = "";
            tbt_Search.Texts = "";
            dtgv_Show.Rows.Clear();
        }

        private void dtg_MauSac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex == 0)
            //{
            //    DataGridViewRow r = dtg_MauSac.Rows[e.RowIndex];
            //    tbt_Ma.Texts = r.Cells[1].Value.ToString();
            //    tbt_Ten.Texts = r.Cells[2].Value.ToString();
            //    _id = Guid.Parse(r.Cells[0].Value.ToString());

            //}
            _id = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
            var x = _imauSacService.GetAll().FirstOrDefault(x => x.Id == _id);
            tbt_Ma.Texts = x.Ma;
            tbt_Ten.Texts = x.Ten;
        }

        private void tbt_Search__TextChanged_1(object sender, EventArgs e)
        {
            int stt = 1;
            dtgv_Show.ColumnCount = 4;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "Id";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            dtgv_Show.Rows.Clear();
            var lstMauSac = _imauSacService.GetAll();
            if (tbt_Search.Texts != "")
            {
                lstMauSac = lstMauSac.Where(x => x.Ten.ToLower().Contains(tbt_Search.Text.ToLower())).ToList();
            }
            foreach (var x in lstMauSac)
            {
                dtgv_Show.Rows.Add(stt++, x.Id, x.Ma, x.Ten);
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var x = _imauSacService.GetAll().FirstOrDefault(x => x.Id == _id);
                x.Ten = tbt_Ten.Texts;
                x.Ma = tbt_Ma.Texts;

                if (_imauSacService.Update(x))
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
                var x = _imauSacService.GetAll().FirstOrDefault(x => x.Id == _id);
                if (_imauSacService.Delete(x))
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
    }
}
