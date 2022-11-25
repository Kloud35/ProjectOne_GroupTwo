using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IThucAnServices
    {
        bool Add(ThucAnView obj);
        bool Delete(ThucAnView obj);
        bool Update(ThucAnView obj);
        List<ThucAnView> GetAll();
    }
}