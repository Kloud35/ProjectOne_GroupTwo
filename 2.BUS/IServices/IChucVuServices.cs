using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IChucVuServices
    {
        bool Add(ChucVuView obj);
        bool Delete(ChucVuView obj);
        bool Update(ChucVuView obj);
        List<ChucVuView> GetAll();
    }
}
