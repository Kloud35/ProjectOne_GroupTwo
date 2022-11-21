using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IDoChoiChiTietRepository
    {
        bool Add(DoChoiChiTiet obj);
        bool Update(DoChoiChiTiet obj);
        bool Delete(DoChoiChiTiet obj);
        List<DoChoiChiTiet> GetAll();
    }
}
