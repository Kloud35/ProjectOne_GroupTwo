using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface INhanVienServices
    {
        bool Add(NhanVienView obj);
        bool Delete(NhanVienView obj);
        bool Update(NhanVienView obj);
        List<NhanVienView> GetAll();
        bool Login(NhanVienView obj);
        
    }
}
