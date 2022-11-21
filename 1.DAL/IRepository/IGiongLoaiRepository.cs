using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IGiongLoaiRepository
    {
        bool Add(GiongLoai obj);
        bool Update(GiongLoai obj);
        bool Delete(GiongLoai obj);
        List<GiongLoai> GetAll();
    }
}
