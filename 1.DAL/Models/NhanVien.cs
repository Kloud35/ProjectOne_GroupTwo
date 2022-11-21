using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class NhanVien
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string Ho { get; set; }
        public string TenDem { get; set; }
        public string Ten { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string DiaChi { get; set; }
        public string ThanhPho { get; set; }
        public string QuocGia { get; set; }
        public string MatKhau { get; set; }
        public int TrangThai { get; set; }
        public Guid IdChucVu { get; set; }
        public Guid IdCuaHang { get; set; }

        public virtual CuaHang CuaHang { get; set; }
        public virtual ChucVu ChucVu { get; set; }
    }
}
