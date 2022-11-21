using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdHoaDon { get; set; }
        public Guid IdThuCungChiTiet { get; set; }
        public Guid IdThucAnChiTiet { get; set; }
        public Guid IdDoChoiChiTiet { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public virtual HoaDon HoaDon { get; set; }
        public virtual ThucAnChiTiet ThucAnChiTiet { get; set; }
        public virtual ThuCungChiTiet ThuCungChiTiet { get; set; }
        public virtual DoChoiChiTiet DoChoiChiTiet { get; set; }
    }
}
