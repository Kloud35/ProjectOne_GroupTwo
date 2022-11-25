using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IThuCungServices
    {
        bool Add(ThuCungView obj);
        bool Delete(ThuCungView obj);
        bool Update(ThuCungView obj);
        List<ThuCungView> GetAll();

    }
}