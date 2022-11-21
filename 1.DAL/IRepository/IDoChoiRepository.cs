using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.IRepository
{
    public interface IDoChoiRepository
    {
        bool Add(DoChoi obj);
        bool Update(DoChoi obj);
        bool Delete(DoChoi obj);
        List<DoChoi> GetAll();
    }
}
