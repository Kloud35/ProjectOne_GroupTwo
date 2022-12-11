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
    public class HDTCCTServices : IHDTCCTServices
    {
        IHoaDonThuCungCTepository _iHoaDonChiTietRepository;
        IHoaDonRepository _iHoaDonRepository;
        IThuCungChiTietRepository _iThuCungChiTietRepository;
        IThuCungRepository _iThuCungRepository;
        public HDTCCTServices()
        {
            _iHoaDonChiTietRepository = new HoaDonThuCungCTRepository();
            _iHoaDonRepository = new HoaDonRepository();
            _iThuCungChiTietRepository = new ThuCungChiTietRepository();
            _iThuCungRepository = new ThuCungRepository();
        }

        public bool Add(HoaDonChiTietView obj)
        {
            if (obj == null) return false;
            var x = new HoaDonThuCungChiTiet()
            {
                Id = obj.Id,
                IdHoaDon = obj.IdHoaDon,
                IdThuCungChiTiet = obj.IdSp,
                SoLuong = obj.SoLuong,
                DonGia = obj.DonGia,
            };
            _iHoaDonChiTietRepository.Add(x);
            return true;
        }

        public bool Delete(HoaDonChiTietView obj)
        {
            if (obj == null) return false;
            var x = _iHoaDonChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            _iHoaDonChiTietRepository.Delete(x);
            return true;
        }

        public List<HoaDonChiTietView> GetAll()
        {
            var list = (from a in _iHoaDonChiTietRepository.GetAll()
                        join b in _iHoaDonRepository.GetAll() on a.IdHoaDon equals b.Id
                        join c in _iThuCungChiTietRepository.GetAll() on a.IdThuCungChiTiet equals c.Id
                        join d in _iThuCungRepository.GetAll() on c.IdThuCung equals d.Id
                        select new HoaDonChiTietView()
                        {
                            Id = a.Id,
                            IdHoaDon = b.Id,
                            IdSp = a.IdThuCungChiTiet,
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
            var x = _iHoaDonChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            x.SoLuong = obj.SoLuong;
            _iHoaDonChiTietRepository.Update(x);
            return true;
        }
    }
}
