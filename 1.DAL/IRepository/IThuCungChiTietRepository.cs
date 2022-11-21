using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IThuCungChiTietRepository
    {
        bool Add(ThuCungChiTiet obj);
        bool Update(ThuCungChiTiet obj);
        bool Delete(ThuCungChiTiet obj);
        List<ThuCungChiTiet> GetAll();
    }
}

