using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public DateTime NgayNhan { get; set; }
        public decimal TienCoc { get; set; }
        public decimal TienShip { get; set; }
        public string TenNguoiNhan { get; set; }
        public int TinhTrang { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public decimal PhanTramGiamGia { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
