using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class CuaHangRepository : ICuaHangRepository
    {
        PetShopDbContext _dbContext;
        public CuaHangRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(CuaHang obj)
        {
            if(obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHang.ToList();
        }

        public bool Update(CuaHang obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
