using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ThuCungView
    {
        public Guid IdTCCT { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public Guid IdThuCung { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdGiongLoai { get; set; }
        public decimal CanNang { get; set; }
        public decimal ChieuDai { get; set; }
        public string GioiTinh { get; set; }
        public int Tuoi { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string MauSac { get; set; }
        public string GiongLoai { get; set; }
        public string Image { get; set; }
    }
}