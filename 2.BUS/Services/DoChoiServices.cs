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
    public class DoChoiServices : IDoChoiServices
    {
        IDoChoiChiTietRepository _iDoChoiChiTietRepository;
        IDoChoiRepository _iDoChoiRepository;
        public DoChoiServices()
        {
            _iDoChoiRepository = new DoChoiRepository();
            _iDoChoiChiTietRepository = new DoChoiChiTietRepository();
        }

        public bool Add(DoChoiView obj)
        {
            if (obj == null) return false;
            var y = new DoChoi()
            {
                Id = obj.IdDoChoi,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            var x = new DoChoiChiTiet()
            {
                Id = obj.Id,
                IdDoChoi = obj.IdDoChoi,
                Loai = obj.Loai,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                Nsx = obj.Nsx,
                Image = obj.Image,
                Barcode = obj.Barcode
            };
            _iDoChoiRepository.Add(y);
            _iDoChoiChiTietRepository.Add(x);
            return true;
        }

        public bool Delete(DoChoiView obj)
        {
            if (obj == null) return false;
            var x = _iDoChoiRepository.GetAll().FirstOrDefault(p => p.Id == obj.IdDoChoi);
            var p = _iDoChoiChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);

            _iDoChoiChiTietRepository.Delete(p);
            _iDoChoiRepository.Delete(x);
            return true;
        }

        public List<DoChoiView> GetAll()
        {
            List<DoChoiView> list = new List<DoChoiView>();
            list = (from a in _iDoChoiChiTietRepository.GetAll()
                    join b in _iDoChoiRepository.GetAll() on a.IdDoChoi equals b.Id
                    select new DoChoiView
                    {
                        Id = a.Id,
                        IdDoChoi = a.IdDoChoi,
                        Ma = b.Ma,
                        Ten = b.Ten,
                        Loai = a.Loai,
                        GiaNhap = a.GiaNhap,
                        GiaBan = a.GiaBan,
                        Nsx = a.Nsx,
                        SoLuongTon = a.SoLuongTon,
                        Image = a.Image,
                        Barcode = a.Barcode
                    }).ToList();
            return list;
        }

        public bool Update(DoChoiView obj)
        {
            if (obj == null) return false;
            var x = _iDoChoiRepository.GetAll().FirstOrDefault(p => p.Id == obj.IdDoChoi);
            x.Ten = obj.Ten;
            x.Ma = obj.Ma;
            var p = _iDoChoiChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            p.Loai = obj.Loai;
            p.GiaNhap = obj.GiaNhap;
            p.GiaBan = obj.GiaBan;
            p.Nsx = obj.Nsx;
            p.SoLuongTon = obj.SoLuongTon;
            p.Image = obj.Image;
            p.Barcode = obj.Barcode;
            _iDoChoiRepository.Update(x);
            _iDoChoiChiTietRepository.Update(p);
            return true;
        }   
    }
}
