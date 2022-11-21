using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IThuCungRepository
    {
        bool Add(ThuCung obj);
        bool Update(ThuCung obj);
        bool Delete(ThuCung obj);
        List<ThuCung> GetAll();
    }
}
