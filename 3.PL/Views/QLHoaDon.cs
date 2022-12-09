using _2.BUS.IServices;
using _2.BUS.Services;
using _2.BUS.ViewModels;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = iTextSharp.text.Font;

namespace _3.PL.Views
{
    public partial class QLHoaDon : UserControl
    {
        IHoaDonServices _iHoaDonServices;
        IHDTCCTServices _iHDTCCTServices;
        IHDDCCTServices _iHDDCCTServices;
        IHDTACTServices _iHDTACTServices;
        List<HoaDonChiTietView> hdct;
        Guid idhd;
        decimal thanhtien;
        public QLHoaDon()
        {
            InitializeComponent();
            _iHoaDonServices = new HoaDonServices();
            _iHDTCCTServices = new HDTCCTServices();
            _iHDDCCTServices = new HDDCCTServices();
            _iHDTACTServices = new HDTACTServices();
            hdct = new List<HoaDonChiTietView>();
        }
        private void LoadData()
        {
            //Hóa đơn
            dtgv_HoaDon.ColumnCount = 6;
            dtgv_HoaDon.Columns[0].Name = "ID";
            dtgv_HoaDon.Columns[0].Visible = false;
            dtgv_HoaDon.Columns[1].Name = "Mã hóa đơn";
            dtgv_HoaDon.Columns[2].Name = "Tên nhân viên";
            dtgv_HoaDon.Columns[3].Name = "Ngày tạo";
            dtgv_HoaDon.Columns[4].Name = "Ngày thanh toán";
            dtgv_HoaDon.Columns[5].Name = "Trạng thái";
            foreach (var x in _iHoaDonServices.GetAll())
            {
                dtgv_HoaDon.Rows.Add(x.Id, x.Ma, x.TenNv, x.NgayTao,x.NgayThanhToan, x.TinhTrang == 0 ? "Chưa thanh toán" : "Đã thanh toán");
            }
        }

        private void dtgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv_HoaDon.CurrentCell != null && dtgv_HoaDon.CurrentCell.Value != null)
            {
                hdct.Clear();
                idhd = Guid.Parse(dtgv_HoaDon.CurrentRow.Cells[0].Value.ToString());
                var x = _iHoaDonServices.GetAll().FirstOrDefault(x => x.Id == idhd);
                var dcct = _iHDDCCTServices.GetAll().Where(p => p.IdHoaDon == idhd).ToList();
                foreach (var dc in dcct)
                {
                    hdct.Add(dc);
                }

                var tact = _iHDTACTServices.GetAll().Where(p => p.IdHoaDon == idhd);
                foreach (var ta in tact)
                {
                    hdct.Add(ta);
                }
                var tcct = _iHDTCCTServices.GetAll().Where(p => p.IdHoaDon == idhd);
                foreach (var tc in tcct)
                {
                    hdct.Add(tc);
                }
                LoadHDCT();
            }
        }
        private void LoadHDCT()
        {
            thanhtien = 0;
            dtgv_HoaDonCt.Rows.Clear();
            int sc = dtgv_HoaDon.Rows.Count;
            int i = 0;
            foreach (var x in hdct)
            {
                dtgv_HoaDonCt.Rows.Add(x.IdSp, x.Ten, x.SoLuong, ChangeFormatMoney(x.DonGia), ChangeFormatMoney(x.TongTien));
                thanhtien += x.TongTien;
                i++;
            }
            dtgv_HoaDonCt.Rows[i].Cells[4].Value = ChangeFormatMoney(thanhtien);
        }

        private string ChangeFormatMoney(decimal value)
        {
            return string.Format(new CultureInfo("vi-VN"), "{0:#,##0.00}", value);
        }
        private void QLHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dtgv_HoaDonCt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_In_Click(object sender, EventArgs e)
        {
           
            PdfPTable pdfTable = new PdfPTable(dtgv_HoaDonCt.ColumnCount-1);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 90;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            
            foreach (DataGridViewColumn column in dtgv_HoaDonCt.Columns)
            {
                if (column.Index != 0)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    pdfTable.AddCell(cell);
                }
            }
            foreach (DataGridViewRow row in dtgv_HoaDonCt.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if(cell.ColumnIndex != 0)
                    {
                        if (cell.Value != null)
                        {
                            pdfTable.AddCell(cell.Value.ToString());
                        }
                        
                    }
                }
                
            }
            var path = "E:\\Pic\\HoaDon\\";
            var x = _iHoaDonServices.GetAll().FirstOrDefault(x => x.Id == idhd);
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (FileStream stream = new FileStream(path + $"{x.Ma}.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arialbd.ttf");

                //Create a base font object making sure to specify IDENTITY-H
                BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                //Create a specific font object
                Font f = new Font(bf, 12, iTextSharp.text.Font.NORMAL);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Paragraph("Hóa đơn"));
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(new Paragraph($"Tổng tiền: {thanhtien}"));
                pdfDoc.Close();
            }
            MessageBox.Show("Xuất hóa đơn thành công");
        }
    }
}
