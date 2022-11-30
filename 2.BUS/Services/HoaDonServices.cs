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
    public class HoaDonServices : IHoaDonServices
    {
        IHoaDonRepository _iHoaDonRepository;
        IKhachHangRepository _iKhachHangRepository;
        INhanVienRepository _iNhanVienRepository;
        IHoaDonChiTietRepository _iHoaDonChiTietRepository;
        IHoaDonDoChoiCTRepository _iHoaDonDoChoiCTRepository;
        IHoaDonThucAnCTRepository _iHoaDonThucAnCTRepository;
        public HoaDonServices()
        {
            _iHoaDonRepository = new HoaDonRepository();
            _iKhachHangRepository = new KhachHangRepository();
            _iNhanVienRepository = new NhanVienRepository();
            _iHoaDonChiTietRepository = new HoaDonChiTietRepository();
            _iHoaDonDoChoiCTRepository = new HoaDonDoChoiCTRepository();
            _iHoaDonThucAnCTRepository = new HoaDonThucAnCTRepository();
        }

        public bool Add(HoaDonView obj)
        {
            if (obj == null) return false;
            var x = new HoaDon()
            {
                Id = obj.Id,
                IdKhachHang = obj.IdKhachHang,
                IdNhanVien = obj.IdNhanVien,
                Ma = obj.Ma,
                NgayTao = obj.NgayTao,
                NgayThanhToan = obj.NgayThanhToan,
                NgayGiaoHang = obj.NgayGiaoHang,
                NgayNhan = obj.NgayNhan,
                TienCoc = obj.TienCoc,
                TienShip = obj.TienShip,
                TenNguoiNhan = obj.TenNguoiNhan,
                TinhTrang = obj.TinhTrang,
                DiaChi = obj.DiaChi,
                Sdt = obj.Sdt,
                PhanTramGiamGia = obj.PhanTramGiamGia
            };
            _iHoaDonRepository.Add(x);
            return true;
        }

        public bool Delete(HoaDonView obj)
        {
            if (obj == null) return false;
            var x = _iHoaDonRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            _iHoaDonRepository.Delete(x);
            return true;
        }

        public List<HoaDonView> GetAll()
        {
            var list = (from a in _iHoaDonRepository.GetAll()
                        join b in _iNhanVienRepository.GetAll() on a.IdNhanVien equals b.Id
                        join c in _iKhachHangRepository.GetAll() on a.IdKhachHang equals c.Id
                        select new HoaDonView()
                        {
                            Id = a.Id,
                            IdKhachHang = a.IdKhachHang,
                            IdNhanVien = a.IdNhanVien,
                            Ma = a.Ma,
                            NgayTao = a.NgayTao,
                            NgayThanhToan = a.NgayThanhToan,
                            NgayGiaoHang = a.NgayGiaoHang,
                            NgayNhan = a.NgayNhan,
                            TienCoc = a.TienCoc,
                            TienShip = a.TienShip,
                            TenNguoiNhan = a.TenNguoiNhan,
                            TinhTrang = a.TinhTrang,
                            DiaChi = a.DiaChi,
                            Sdt = a.Sdt,
                            PhanTramGiamGia = a.PhanTramGiamGia,
                            TenNv = b.Ho + " " + b.TenDem + " " + b.Ten
                        }).ToList();
            return list;
        }

        public bool Update(HoaDonView obj)
        {
            if (obj == null) return false;
            var x = _iHoaDonRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            x.Id = obj.Id;
            x.IdKhachHang = obj.IdKhachHang;
            x.IdNhanVien = obj.IdNhanVien;
            x.Ma = obj.Ma;
            x.NgayTao = obj.NgayTao;
            x.NgayThanhToan = obj.NgayThanhToan;
            x.NgayGiaoHang = obj.NgayGiaoHang;
            x.NgayNhan = obj.NgayNhan;
            x.TienCoc = obj.TienCoc;
            x.TienShip = obj.TienShip;
            x.TenNguoiNhan = obj.TenNguoiNhan;
            x.TinhTrang = obj.TinhTrang;
            x.DiaChi = obj.DiaChi;
            x.Sdt = obj.Sdt;
            x.PhanTramGiamGia = obj.PhanTramGiamGia;
            _iHoaDonRepository.Update(x);
            return true;
        }
    }
}
