using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ThuCungRepository : IThuCungRepository
    {
        PetShopDbContext _dbContext;
        public ThuCungRepository()
        {
            _dbContext = new PetShopDbContext();
        }
        public bool Add(ThuCung obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ThuCung obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ThuCung> GetAll()
        {
            return _dbContext.ThuCung.ToList();
        }

        public bool Update(ThuCung obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}