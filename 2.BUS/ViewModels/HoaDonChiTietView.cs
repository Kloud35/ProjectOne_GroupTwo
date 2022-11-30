
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
        public Guid IdSp { get; set; }
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal TongTien { get; set; }
    }
}
