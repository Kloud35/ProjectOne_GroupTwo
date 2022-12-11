using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class HoaDonThuCungCTRepository : IHoaDonThuCungCTepository
    {
        PetShopDbContext _dbContext;
        public HoaDonThuCungCTRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(HoaDonThuCungChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonThuCungChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<HoaDonThuCungChiTiet> GetAll()
        {
            return _dbContext.HoaDonThuCungChiTiet.ToList();
        }

        public bool Update(HoaDonThuCungChiTiet obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
