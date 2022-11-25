using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IDoChoiServices
    {
        bool Add(DoChoiView obj);
        bool Update(DoChoiView obj);
        bool Delete(DoChoiView obj);
        List<DoChoiView> GetAll();
    }
}
