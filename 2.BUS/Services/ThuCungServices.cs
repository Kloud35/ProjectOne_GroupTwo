using _1.DAL.Configuations;
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
    public class ThuCungServices : IThuCungServices
    {
        IThuCungRepository _iThuCungRepository;
        IThuCungChiTietRepository _iThuCungChiTietRepository;
        IMauSacRepository _iMauSacRepository;
        IGiongLoaiRepository _iGiongLoaiRepository;
        public ThuCungServices()
        {
            _iThuCungRepository = new ThuCungRepository();
            _iThuCungChiTietRepository = new ThuCungChiTietRepository();
            _iMauSacRepository = new MauSacRepository();
            _iGiongLoaiRepository = new GiongLoaiRepository();
        }
        public bool Add(ThuCungView obj)
        {
            if (obj == null) return false;
            var p = new ThuCung()
            {
                Id = obj.IdThuCung,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            _iThuCungRepository.Add(p);

            var x = new ThuCungChiTiet()
            {
                Id = obj.IdTCCT,
                IdThuCung = obj.IdThuCung,
                IdMauSac = obj.IdMauSac,
                IdGiongLoai = obj.IdGiongLoai,
                CanNang = obj.CanNang,
                ChieuDai = obj.ChieuDai,
                GioiTinh = obj.GioiTinh,
                Tuoi = obj.Tuoi,
                SoLuong = obj.SoLuong,
                TrangThai = obj.TrangThai,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                Image = obj.Image
            };
            _iThuCungChiTietRepository.Add(x);

            return true;
        }

        public bool Delete(ThuCungView obj)
        {
            if (obj == null) return false;
            var x = _iThuCungRepository.GetAll().FirstOrDefault(p => p.Id == obj.IdThuCung);
            var p = _iThuCungChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.IdTCCT);
            _iThuCungChiTietRepository.Delete(p);
            _iThuCungRepository.Delete(x);
            return true;
        }

        public List<ThuCungView> GetAll()
        {
            List<ThuCungView> list = new List<ThuCungView>();
            list = (from a in _iThuCungChiTietRepository.GetAll()
                    join b in _iThuCungRepository.GetAll() on a.IdThuCung equals b.Id
                    join c in _iMauSacRepository.GetAll() on a.IdMauSac equals c.Id
                    join d in _iGiongLoaiRepository.GetAll() on a.IdGiongLoai equals d.Id
                    select new ThuCungView
                    {
                        IdTCCT = a.Id,
                        IdThuCung = a.IdThuCung,
                        Ma = b.Ma,
                        Ten = b.Ten,
                        IdMauSac = a.IdMauSac,
                        IdGiongLoai = a.IdGiongLoai,
                        CanNang = a.CanNang,
                        ChieuDai = a.ChieuDai,
                        GioiTinh = a.GioiTinh,
                        Tuoi = a.Tuoi,
                        SoLuong = a.SoLuong,
                        TrangThai = a.TrangThai,
                        GiaNhap = a.GiaNhap,
                        GiaBan = a.GiaBan,
                        MauSac = c.Ten,
                        GiongLoai = c.Ten,
                        Image = a.Image
                    }).ToList();
            return list;
        }

        public bool Update(ThuCungView obj)
        {
            if (obj == null) return false;
            var x = _iThuCungRepository.GetAll().FirstOrDefault(p => p.Id == obj.IdThuCung);
            x.Ten = obj.Ten;
            x.Ma = obj.Ma;
            var p = _iThuCungChiTietRepository.GetAll().FirstOrDefault(x => x.Id == obj.IdTCCT);
            p.IdMauSac = obj.IdMauSac;
            p.IdGiongLoai = obj.IdGiongLoai;
            p.CanNang = obj.CanNang;
            p.ChieuDai = obj.GiaNhap;
            p.GioiTinh = obj.GioiTinh;
            p.Tuoi = obj.Tuoi;
            p.SoLuong = obj.SoLuong;
            p.TrangThai = obj.TrangThai;
            p.GiaBan = obj.GiaBan;
            p.GiaNhap = obj.GiaNhap;
            p.Image = obj.Image;
            _iThuCungRepository.Update(x);
            _iThuCungChiTietRepository.Update(p);
            return true;
        }
    }
}