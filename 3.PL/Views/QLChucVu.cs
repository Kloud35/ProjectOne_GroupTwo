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
    public partial class QLChucVu : UserControl
    {
        IChucVuServices _iChucVuServices;
        Guid currentId;
        public QLChucVu()
        {
            InitializeComponent();
            _iChucVuServices = new ChucVuServices();
        }

        private void QLChucVu_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 4;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            var list = _iChucVuServices.GetAll();
            if (tbt_Search.Texts != "")
            {
                list = _iChucVuServices.GetAll().Where(x => x.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.Ten);
            }
        }
        private void CLear()
        {
            tbt_Ten.Texts = "";
            tbt_Ma.Texts = "";
            tbt_Search.Texts = "";
            currentId = Guid.Empty;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            var x = new ChucVuView()
            {
                Id = Guid.NewGuid(),
                Ma = tbt_Ma.Texts,
                Ten = tbt_Ten.Texts
            };
            if (_iChucVuServices.Add(x))
            {
                MessageBox.Show("Thêm thành công");
                LoadData();
                CLear();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
                CLear();
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            var x = _iChucVuServices.GetAll().FirstOrDefault(x => x.Id == currentId);
            x.Ma = tbt_Ma.Texts;
            x.Ten = tbt_Ten.Texts;
            if (_iChucVuServices.Update(x))
            {
                MessageBox.Show("Sửa thành công");
                LoadData();
                CLear();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var x = _iChucVuServices.GetAll().FirstOrDefault(x => x.Id == currentId);
            if (_iChucVuServices.Delete(x))
            {
                MessageBox.Show("Xóa thành công");
                LoadData();
                CLear();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            CLear();
            dtgv_Show.Rows.Clear();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void tbt_Search__TextChanged(object sender, EventArgs e)
        {
            dtgv_Show.Rows.Clear();
            int stt = 1;
            dtgv_Show.ColumnCount = 4;
            dtgv_Show.Columns[0].Name = "STT";
            dtgv_Show.Columns[1].Name = "ID";
            dtgv_Show.Columns[1].Visible = false;
            dtgv_Show.Columns[2].Name = "Mã";
            dtgv_Show.Columns[3].Name = "Tên";
            var list = _iChucVuServices.GetAll();
            if (tbt_Search.Texts != "")
            {
                list = _iChucVuServices.GetAll().Where(x => x.Ten.ToLower().Contains(tbt_Search.Texts.ToLower())).ToList();
            }
            foreach (var item in list)
            {
                dtgv_Show.Rows.Add(stt++, item.Id, item.Ma, item.Ten);
            }
        }

        private void dtgv_Show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_Show.CurrentCell != null && dtgv_Show.CurrentCell.Value != null)
            {
                currentId = Guid.Parse(dtgv_Show.CurrentRow.Cells[1].Value.ToString());
                var x = _iChucVuServices.GetAll().FirstOrDefault(x => x.Id == currentId);
                tbt_Ten.Texts = x.Ten;
                tbt_Ma.Texts = x.Ma;
            }
        }
    }
}
