using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IGiongLoaiServices
    {
        bool Add(GiongLoaiView obj);
        bool Delete(GiongLoaiView obj);
        bool Update(GiongLoaiView obj);
        List<GiongLoaiView> GetAll();
    }
}
