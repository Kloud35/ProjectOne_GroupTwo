using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface ICuaHangServices
    {
        bool Add(CuaHangView obj);
        bool Delete(CuaHangView obj);
        bool Update(CuaHangView obj);
        List<CuaHangView> GetAll();
    }
}
