using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class HoaDonDoChoiCTRepository : IHoaDonDoChoiCTRepository
    {
        PetShopDbContext _dbContext;

        public HoaDonDoChoiCTRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(HoaDonDoChoiChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonDoChoiChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDonDoChoiChiTiet> GetAll()
        {
            return _dbContext.HoaDonDoChoiChiTiet.ToList();
        }

        public bool Update(HoaDonDoChoiChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
