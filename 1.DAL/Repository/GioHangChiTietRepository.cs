using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class GioHangChiTietRepository : IGioHangChiTietRepository
    {
        PetShopDbContext _dbContext;
        public GioHangChiTietRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<GioHangChiTiet> GetAll()
        {
            return _dbContext.GioHangChiTiet.ToList();
        }

        public bool Update(GioHangChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
