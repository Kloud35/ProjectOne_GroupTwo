using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ThucAnChiTietRepository : IThucAnChiTietRepository
    {
        PetShopDbContext _dbContext;
        public ThucAnChiTietRepository()
        {
            _dbContext = new PetShopDbContext();
        }
        public bool Add(ThucAnChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ThucAnChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ThucAnChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ThucAnChiTiet> GetAll()
        {
            return _dbContext.ThucAnChiTiet.ToList();
        }


    }
}