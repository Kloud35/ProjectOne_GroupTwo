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
        private Guid _id;
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            _imauSacService.Delete(_id);
            LoadData();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            MauSacView a = new MauSacView()
            {
                Id = _id,
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts

            };
            _imauSacService.Update(a);
            LoadData();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            tbt_Ma.Texts = "";
            tbt_Ten.Texts = "";

        }

        private void tbt_Search__TextChanged(object sender, EventArgs e)
        {

        }
        

        private void dtg_MauSac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}
