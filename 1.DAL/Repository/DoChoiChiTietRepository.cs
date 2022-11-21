using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class DoChoiChiTietRepository : IDoChoiChiTietRepository
    {
        PetShopDbContext _dbContext;
        public DoChoiChiTietRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(DoChoiChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DoChoiChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<DoChoiChiTiet> GetAll()
        {
            return _dbContext.DoChoiChiTiet.ToList();
        }

        public bool Update(DoChoiChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
