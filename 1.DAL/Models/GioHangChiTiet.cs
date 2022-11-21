using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class GioHangChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdGioHang { get; set; }
        public Guid IdThuCungChiTiet { get; set; }
        public Guid IdThucAnChiTiet { get; set; }
        public Guid IdDoChoiChiTiet { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal Voucher { get; set; }
        public virtual GioHang GioHang { get; set; }
        public virtual ThucAnChiTiet ThucAnChiTiet { get; set; }
        public virtual ThuCungChiTiet ThuCungChiTiet { get; set; }
        public virtual DoChoiChiTiet DoChoiChiTiet { get; set; }
    }
}
