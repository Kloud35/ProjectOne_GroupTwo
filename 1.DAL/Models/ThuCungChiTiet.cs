using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class ThuCungChiTiet
    {
        public Guid Id { get; set; }
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
        public string Image { get; set; }
        public virtual ThuCung ThuCung { get; set;}
        public virtual MauSac MauSac { get; set; }
        public virtual GiongLoai GiongLoai { get; set;}
    }
}
