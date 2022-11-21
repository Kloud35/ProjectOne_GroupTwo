using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ThucAnRepository : IThucAnRepository
    {
        PetShopDbContext _dbContext;
        public ThucAnRepository()
        {
            _dbContext = new PetShopDbContext();
        }
        public bool Add(ThucAn obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ThucAn obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ThucAn> GetAll()
        {
            return _dbContext.ThucAn.ToList();
        }

        public bool Update(ThucAn obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}