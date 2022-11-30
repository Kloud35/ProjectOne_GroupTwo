using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IHoaDonDoChoiCTRepository
    {
        bool Add(HoaDonDoChoiChiTiet obj);
        bool Update(HoaDonDoChoiChiTiet obj);
        bool Delete(HoaDonDoChoiChiTiet obj);
        List<HoaDonDoChoiChiTiet> GetAll();
    }
}
