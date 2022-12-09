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
    public class HDTACTServices : IHDTACTServices
    {
        IHoaDonThucAnCTRepository _iHoaDonThucAnCTRepository;
        IHoaDonRepository _iHoaDonRepository;
        IThucAnChiTietRepository _iThucAnChiTietRepository;
        IThucAnRepository _iThucAnRepository;
        public HDTACTServices()
        {
            _iHoaDonThucAnCTRepository = new HoaDonThucAnCTRepository();
            _iHoaDonRepository = new HoaDonRepository();
            _iThucAnChiTietRepository = new ThucAnChiTietRepository();
            _iThucAnRepository = new ThucAnRepository();
        }

        public bool Add(HoaDonChiTietView obj)
        {
            if (obj == null) return false;
            var x = new HoaDonThucAnChiTiet()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                IdThucAnChiTiet = obj.IdSp,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,
            };
            _iHoaDonThucAnCTRepository.Add(x);
            return true;
        }

        public bool Delete(HoaDonChiTietView obj)
        {
            if (obj == null) return false;
            var x = _iHoaDonThucAnCTRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            _iHoaDonThucAnCTRepository.Delete(x);
            return true;
        }

        public List<HoaDonChiTietView> GetAll()
        {
            var list = (from a in _iHoaDonThucAnCTRepository.GetAll()
                        join b in _iHoaDonRepository.GetAll() on a.IdHoaDon equals b.Id
                        join c in _iThucAnChiTietRepository.GetAll() on a.IdThucAnChiTiet equals c.Id
                        join d in _iThucAnRepository.GetAll() on c.IdThucAn equals d.Id
                        select new HoaDonChiTietView()
                        {
                            Id = a.Id,
                            IdHoaDon = b.Id,
                            IdSp = c.Id,
                            SoLuong = a.SoLuong,
                            DonGia = a.DonGia,
                            TongTien = a.SoLuong * a.DonGia,
                            Ten = d.Ten
                        }).ToList();
            return list;
        }

        public bool Update(HoaDonChiTietView obj)
        {
            if (obj == null) return false;
            var x = _iHoaDonThucAnCTRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            x.SoLuong = obj.SoLuong;
            _iHoaDonThucAnCTRepository.Update(x);
            return true;
        }
    }
}
