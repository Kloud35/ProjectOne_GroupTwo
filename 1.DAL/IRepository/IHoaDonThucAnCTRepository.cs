using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IHoaDonThucAnCTRepository
    {
        bool Add(HoaDonThucAnChiTiet obj);
        bool Update(HoaDonThucAnChiTiet obj);
        bool Delete(HoaDonThucAnChiTiet obj);
        List<HoaDonThucAnChiTiet> GetAll();
    }
}
