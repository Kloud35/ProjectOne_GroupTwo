using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HoaDonThuCungChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdThuCungChiTiet { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ThuCungChiTiet ThuCungChiTiet { get; set; }
    }
}
