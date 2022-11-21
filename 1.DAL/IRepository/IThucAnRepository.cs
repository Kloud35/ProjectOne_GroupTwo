using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IThucAnRepository
    {
        bool Add(ThucAn obj);
        bool Update(ThucAn obj);
        bool Delete(ThucAn obj);
        List<ThucAn> GetAll();
    }
}
