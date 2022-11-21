using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class ThuCungChiTietRepository : IThuCungChiTietRepository
    {
        PetShopDbContext _dbContext;
        public ThuCungChiTietRepository()
        {
            _dbContext = new PetShopDbContext();
        }
        public bool Add(ThuCungChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ThuCungChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<ThuCungChiTiet> GetAll()
        {
            return _dbContext.ThuCungChiTiet.ToList();
        }

        public bool Update(ThuCungChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}