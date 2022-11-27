using _1.DAL.IRepository;
using _1.DAL.Models;
using _1.DAL.Repository;
using _2.BUS.IServices;
using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.Services
{
    public class HoaDonChiTietServices : IHoaDonChiTietServices
    {
        IHoaDonChiTietRepository _iHoaDonChiTietRepository;

        public HoaDonChiTietServices()
        {
            _iHoaDonChiTietRepository = new HoaDonChiTietRepository();
        }

        public bool Add(HoaDonChiTietView obj)
        {
            if(obj == null) return false;
            var x = new HoaDonChiTiet()
            {
                Id = obj.Id,
                IdDoChoiChiTiet = obj.IdDoChoiChiTiet,
                IdHoaDon = obj.IdHoaDon,
                IdThucAnChiTiet = obj.IdThucAnChiTiet,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,
            };
            _iHoaDonChiTietRepository.Add(x);
            return true;
        }

        public bool Delete(HoaDonChiTietView obj)
        {
            throw new NotImplementedException();
        }

        public List<HoaDonChiTietView> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(HoaDonChiTietView obj)
        {
            throw new NotImplementedException();
        }
    }
}
