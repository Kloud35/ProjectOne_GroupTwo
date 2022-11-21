using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class GioHangRepository : IGioHangRepository
    {
        PetShopDbContext _dbContext;
        public GioHangRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(GioHang obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHang obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GioHang> GetAll()
        {
            return _dbContext.GioHang.ToList();
        }

        public bool Update(GioHang obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
