using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class HoaDonThucAnCTRepository : IHoaDonThucAnCTRepository
    {
        PetShopDbContext _dbContext;

        public HoaDonThucAnCTRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(HoaDonThucAnChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonThucAnChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDonThucAnChiTiet> GetAll()
        {
            return _dbContext.HoaDonThucAnChiTiet.ToList();
        }

        public bool Update(HoaDonThucAnChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
