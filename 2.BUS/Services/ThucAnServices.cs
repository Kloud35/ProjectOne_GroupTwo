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
    public class ThucAnServices : IThucAnServices
    {
        IThucAnRepository _ithucAnRepository;
        IThucAnChiTietRepository _ithucAnChiTietRepository;
        public ThucAnServices()
        {
            _ithucAnRepository = new ThucAnRepository();
            _ithucAnChiTietRepository = new ThucAnChiTietRepository();
        }


        public bool Add(ThucAnView obj)
        {
            if (obj == null) return false;
            var p = new ThucAn()
            {
                Id = obj.IdThucAn,
                Ten = obj.Ten,
                Ma = obj.Ma

            };
            var x = new ThucAnChiTiet()
            {
                Id = obj.Id,
                IdThucAn = obj.IdThucAn,
                Loai = obj.Loai,
                SoLuongTon = obj.SoLuongTon,
                GiaBan = obj.GiaBan,
                GiaNhap = obj.GiaNhap,
                Nsx = obj.Nsx,
            };
            _ithucAnRepository.Add(p);
            _ithucAnChiTietRepository.Add(x);
            return true;
        }

        public bool Delete(ThucAnView obj)
        {
            if (obj == null) return false;
            var x = _ithucAnRepository.GetAll().FirstOrDefault(p => p.Id == obj.IdThucAn);
            var p = _ithucAnChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            _ithucAnChiTietRepository.Delete(p);
            _ithucAnRepository.Delete(x);
            return true;
        }

        public List<ThucAnView> GetAll()
        {
            List<ThucAnView> list = new List<ThucAnView>();
            list = (from a in _ithucAnChiTietRepository.GetAll()
                    join b in _ithucAnRepository.GetAll() on a.IdThucAn equals b.Id
                    select new ThucAnView
                    {
                        Id = a.Id,
                        IdThucAn = a.IdThucAn,
                        Ma = b.Ma,
                        Ten = b.Ten,
                        Loai = a.Loai,
                        GiaNhap = a.GiaNhap,
                        GiaBan = a.GiaBan,
                        Nsx = a.Nsx,
                        SoLuongTon = a.SoLuongTon,
                    }).ToList();
            return list;
        }

        public bool Update(ThucAnView obj)
        {
            if (obj == null) return false;
            var x = _ithucAnRepository.GetAll().FirstOrDefault(p => p.Id == obj.IdThucAn);
            x.Ten = obj.Ten;
            x.Ma = obj.Ma;
            var p = _ithucAnChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            p.Loai = obj.Loai;
            p.GiaNhap = obj.GiaNhap;
            p.GiaBan = obj.GiaBan;
            p.Nsx = obj.Nsx;
            p.SoLuongTon = obj.SoLuongTon;
            _ithucAnRepository.Update(x);
            _ithucAnChiTietRepository.Update(p);
            return true;
        }
    }
}