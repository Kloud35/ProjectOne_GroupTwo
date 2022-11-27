using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class ThucAnChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdThucAn { get; set; }
        public string Loai { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string Nsx { get; set; }
        public string Image { get; set; }
        public string Barcode { get; set; }

        public virtual ThucAn ThucAn { get; set; }
    }
}
