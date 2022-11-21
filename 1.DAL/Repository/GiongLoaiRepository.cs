using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class GiongLoaiRepository : IGiongLoaiRepository
    {
        PetShopDbContext _dbContext;
        public GiongLoaiRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(GiongLoai obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GiongLoai obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GiongLoai> GetAll()
        {
            return _dbContext.GiongLoai.ToList();
        }

        public bool Update(GiongLoai obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
