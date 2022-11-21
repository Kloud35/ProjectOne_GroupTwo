using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class MauSacRepository : IMauSacRepository
    {
        PetShopDbContext _dbContext;
        public MauSacRepository()
        {
            _dbContext = new PetShopDbContext();
        }
        public bool Add(MauSac obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<MauSac> GetAll()
        {
            return _dbContext.MauSac.ToList();
        }

        public bool Update(MauSac obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}