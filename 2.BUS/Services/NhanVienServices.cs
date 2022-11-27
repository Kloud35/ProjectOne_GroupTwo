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
    public class NhanVienServices : INhanVienServices
    {
        INhanVienRepository _iNhanVienRepository;
        IChucVuRepository _iChucVuRepository;
        ICuaHangRepository _iCuaHangRepository;
        public NhanVienServices()
        {
            _iNhanVienRepository = new NhanVienRepository();
            _iChucVuRepository = new ChucVuRepository();
            _iCuaHangRepository = new CuaHangRepository();
        }

        public bool Add(NhanVienView obj)
        {
            if (obj == null) return false;
            var x = new NhanVien()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ho = obj.Ho,
                TenDem = obj.TenDem,
                Ten = obj.Ten,
                NgaySinh = obj.NgaySinh,
                GioiTinh = obj.GioiTinh,
                Sdt = obj.Sdt,
                Email = obj.Email,
                DiaChi = obj.DiaChi,
                ThanhPho = obj.ThanhPho,
                QuocGia = obj.QuocGia,
                MatKhau = obj.MatKhau,
                TrangThai = obj.TrangThai,
                IdCuaHang = obj.IdCh,
                IdChucVu = obj.IdCv,
                Image = obj.Image
            };
            _iNhanVienRepository.Add(x);
            return true;
        }

        public bool Delete(NhanVienView obj)
        {
            if (obj == null) return false;
            var x = _iNhanVienRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            _iNhanVienRepository.Delete(x);
            return true;
        }

        public List<NhanVienView> GetAll()
        {
            var list = (from a in _iNhanVienRepository.GetAll()
                        join b in _iChucVuRepository.GetAll() on a.IdChucVu equals b.Id
                        join c in _iCuaHangRepository.GetAll() on a.IdCuaHang equals c.Id
                        select new NhanVienView
                        {
                            Id = a.Id,
                            IdCh = a.IdCuaHang,
                            IdCv = a.IdChucVu,
                            ChucVu = b.Ten,
                            CuaHang = c.Ten,
                            Ma = a.Ma,
                            Ho = a.Ho,
                            TenDem = a.TenDem,
                            Ten = a.Ten,
                            HoVaTen = a.Ho + " " + a.TenDem + " " + a.Ten,
                            NgaySinh = a.NgaySinh,
                            GioiTinh = a.GioiTinh,
                            Sdt = a.Sdt,
                            Email = a.Email,
                            MatKhau = a.MatKhau,
                            DiaChi = a.DiaChi,
                            ThanhPho = a.ThanhPho,
                            QuocGia = a.QuocGia,
                            TrangThai = a.TrangThai,
                            Image = a.Image
                        }
                        ).ToList();
            return list;
        }

        public bool Login(NhanVienView obj)
        {
            if (obj == null) return false;
            if (_iNhanVienRepository.GetAll().FirstOrDefault(x => x.Sdt == obj.Sdt && x.MatKhau == obj.MatKhau && x.TrangThai == 0) != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Update(NhanVienView obj)
        {
            if (obj == null) return false;
            var x = _iNhanVienRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            x.Id = obj.Id;
            x.Ma = obj.Ma;
            x.Ho = obj.Ho;
            x.TenDem = obj.TenDem;
            x.Ten = obj.Ten;
            x.NgaySinh = obj.NgaySinh;
            x.GioiTinh = obj.GioiTinh;
            x.Sdt = obj.Sdt;
            x.Email = obj.Email;
            x.DiaChi = obj.DiaChi;
            x.ThanhPho = obj.ThanhPho;
            x.QuocGia = obj.QuocGia;
            x.MatKhau = obj.MatKhau;
            x.TrangThai = obj.TrangThai;
            x.IdCuaHang = obj.IdCh;
            x.IdChucVu = obj.IdCv;
            x.Image = obj.Image;
            _iNhanVienRepository.Update(x);
            return true;
        }
    }
}
