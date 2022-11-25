using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ThucAnView
    {
        public Guid Id { get; set; }
        public Guid IdThucAn { get; set; }
        public string Ma { get; set; }
        public string Ten { get; set; }
        public string Loai { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string Nsx { get; set; }

    }
}