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
    public class HDDCCTServices : IHDDCCTServices
    {
        IHoaDonDoChoiCTRepository _iHoaDonDoChoiCTRepository;
        IHoaDonRepository _iHoaDonRepository;
        IDoChoiChiTietRepository _iDoChoiChiTietRepository;
        IDoChoiRepository _iDoChoiRepository;
        public HDDCCTServices()
        {
            _iHoaDonDoChoiCTRepository = new HoaDonDoChoiCTRepository();
            _iHoaDonRepository = new HoaDonRepository();
            _iDoChoiChiTietRepository = new DoChoiChiTietRepository();
            _iDoChoiRepository = new DoChoiRepository();
        }

        public bool Add(HoaDonChiTietView obj)
        {
            if (obj == null) return false;
            var x = new HoaDonDoChoiChiTiet()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                IdDoChoiChiTiet = obj.IdSp,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,
            };
            _iHoaDonDoChoiCTRepository.Add(x);
            return true;
        }

        public bool Delete(HoaDonChiTietView obj)
        {
            if (obj == null) return false;
            var x = _iHoaDonDoChoiCTRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            _iHoaDonDoChoiCTRepository.Delete(x);
            return true;
        }

        public List<HoaDonChiTietView> GetAll()
        {
            var list = (from a in _iHoaDonDoChoiCTRepository.GetAll()
                        join b in _iHoaDonRepository.GetAll() on a.IdHoaDon equals b.Id
                        join c in _iDoChoiChiTietRepository.GetAll() on a.IdDoChoiChiTiet equals c.Id
                        join d in _iDoChoiRepository.GetAll() on c.IdDoChoi equals d.Id
                        select new HoaDonChiTietView()
                        {
                            Id = a.Id,
                            IdHoaDon = b.Id,
                            IdSp = a.IdDoChoiChiTiet,
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
            var x = _iHoaDonDoChoiCTRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            x.SoLuong = obj.SoLuong;
            _iHoaDonDoChoiCTRepository.Update(x);
            return true;
        }
    }
}
