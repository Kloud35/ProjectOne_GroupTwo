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
    public class KhachHangServices : IKhachHangServices
    {
        IKhachHangRepository _iKhachHangRepository;
        public KhachHangServices()
        {
            _iKhachHangRepository = new KhachHangRepository();
        }
        public bool Add(KhachHangView obj)
        {
            if (obj == null) return false;
            var x = new KhachHang()
            {
                Id =  obj.Id,
                Ma = obj.Ma,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                Ten = obj.Ten,
                NgaySinh = obj.NgaySinh,
                GioiTinh = obj.GioiTinh,
                Sdt = obj.Sdt,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
            };
            _iKhachHangRepository.Add(x);
            return true;
        }

        public bool Delete(Guid idkh)
        {
            var x = _iKhachHangRepository.GetAll().FirstOrDefault(p => p.Id == idkh);
            _iKhachHangRepository.Delete(x);
            return true;
        }

        public List<KhachHangView> GetAll()
        {
            var list = (from a in _iKhachHangRepository.GetAll()
                        select new KhachHangView
                        {
                            Id = a.Id,
                            Ma = a.Ma,
                            Ho=a.Ho,
                            TenDem = a.TenDem,
                            Ten = a.Ten,
                            HoVaTen = a.Ho+" "+a.TenDem+" "+a.Ten,
                            NgaySinh = a.NgaySinh,
                            GioiTinh = a.GioiTinh,
                            Sdt = a.Sdt,
                            DiaChi = a.DiaChi,
                            ThanhPho = a.ThanhPho,
                            QuocGia = a.QuocGia,
                        }).ToList();
            return list;
        }

        public bool Update(KhachHangView obj)
        {
            var x = _iKhachHangRepository.GetAll().FirstOrDefault(p => p.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Ho = obj.Ho;
            x.TenDem = obj.TenDem;
            x.Ten = obj.Ten;
            x.NgaySinh = obj.NgaySinh;
            x.GioiTinh = obj.GioiTinh;
            x.Sdt = obj.Sdt;
            x.DiaChi = obj.DiaChi;
            x.ThanhPho = obj.ThanhPho;
            x.QuocGia = obj.QuocGia;
            _iKhachHangRepository.Update(x);
            return true;
        }
    }
}
