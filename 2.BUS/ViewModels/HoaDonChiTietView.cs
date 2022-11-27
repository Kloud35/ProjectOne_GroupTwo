
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class HoaDonChiTietView
    {
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdThuCungChiTiet { get; set; }
        public Guid IdThucAnChiTiet { get; set; }
        public Guid IdDoChoiChiTiet { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
    }
}
