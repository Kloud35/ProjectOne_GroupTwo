using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IHoaDonChiTietServices
    {
        bool Add(HoaDonChiTietView obj);
        bool Update(HoaDonChiTietView obj);
        bool Delete(HoaDonChiTietView obj);
        List<HoaDonChiTietView> GetAll();
    }
}
