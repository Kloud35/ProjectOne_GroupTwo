using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IHoaDonThuCungCTepository
    {
        bool Add(HoaDonThuCungChiTiet obj);
        bool Update(HoaDonThuCungChiTiet obj);
        bool Delete(HoaDonThuCungChiTiet obj);
        List<HoaDonThuCungChiTiet> GetAll();
    }
}
