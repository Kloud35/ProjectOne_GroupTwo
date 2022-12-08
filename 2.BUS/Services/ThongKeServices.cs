using _1.DAL.IRepository;
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
    public class ThongKeServices : IThongKeServices
    {

        IKhachHangRepository _ikhachHangRepository;
        INhanVienRepository _iNhanVienRepository;
        IThuCungRepository _ithuCungRepository;
        IThucAnRepository _ithucAnRepository;
        IDoChoiRepository _idoChoiRepository;
        IHoaDonRepository _ihoaDonRepository;
        IHoaDonThuCungCTepository _iHDTCCTRepository;
        IThucAnChiTietRepository _ithucAnChiTietRepository;
        IThuCungChiTietRepository _ithuCungChiTietRepository;
        IDoChoiChiTietRepository _idoChoiChiTietRepository;
        ICuaHangRepository _icuaHangRepository;
        IHoaDonDoChoiCTRepository _ihoaDonDoChoiCTRepository;
        IHoaDonThucAnCTRepository _ihoaDonThucAnCTRepository;

        public ThongKeServices()
        {
            _ikhachHangRepository = new KhachHangRepository();
            _iNhanVienRepository = new NhanVienRepository();
            _ithuCungRepository = new ThuCungRepository();
            _ithucAnRepository = new ThucAnRepository();
            _idoChoiRepository = new DoChoiRepository();
            _icuaHangRepository = new CuaHangRepository();
            _idoChoiChiTietRepository = new DoChoiChiTietRepository();
            _ithucAnChiTietRepository = new ThucAnChiTietRepository();
            _ithuCungChiTietRepository = new ThuCungChiTietRepository();
            _ihoaDonRepository = new HoaDonRepository();
            _iHDTCCTRepository = new HoaDonThuCungCTRepository();
            _ihoaDonDoChoiCTRepository = new HoaDonDoChoiCTRepository();
            _ihoaDonThucAnCTRepository = new HoaDonThucAnCTRepository();
        }
        public List<ThongKeView> GetAll()
        {
            List<ThongKeView> list = new List<ThongKeView>();
            list = (from a in _iHDTCCTRepository.GetAll()
                    join b in _ihoaDonRepository.GetAll() on a.IdHoaDon equals b.Id
                    join c in _ithuCungChiTietRepository.GetAll() on a.IdThuCungChiTiet equals c.Id
                    join d in _ithuCungRepository.GetAll() on c.IdThuCung equals d.Id
                    join e in _iNhanVienRepository.GetAll() on b.IdNhanVien equals e.Id
                    join f in _icuaHangRepository.GetAll() on e.IdCuaHang equals f.Id
                    join g in _ikhachHangRepository.GetAll() on b.IdKhachHang equals g.Id
                    join h in _ihoaDonThucAnCTRepository.GetAll() on b.Id equals h.IdHoaDon
                    join j in _ithucAnChiTietRepository.GetAll() on h.IdThucAnChiTiet equals j.Id
                    join k in _ithucAnRepository.GetAll() on j.IdThucAn equals k.Id
                    join l in _ihoaDonDoChoiCTRepository.GetAll() on b.Id equals l.IdHoaDon
                    join z in _idoChoiChiTietRepository.GetAll() on l.IdDoChoiChiTiet equals z.Id
                    join x in _idoChoiRepository.GetAll() on z.IdDoChoi equals x.Id
                    select new ThongKeView
                    {
                        MaHD = b.Ma,
                        TenThuCung = d.Ten,
                        TenThucAn = k.Ten,
                        TenDoChoi = x.Ten,
                        SoluongThu = a.SoLuong,
                        GiaThuCung = a.DonGia,
                        SLThucAn = h.SoLuong,
                        GiaThucAn = h.DonGia,
                        SLDoChoi = l.SoLuong,
                        GiaDoChoi = l.DonGia,
                        PhanTramGiamGia = b.PhanTramGiamGia,
                        NgayTaoHD = b.NgayTao,
                        HoNV = e.Ho,
                        TenDemNV = e.TenDem,
                        TenVN = e.Ten,
                        HoKH = g.Ho,
                        TenDemKH = g.TenDem,
                        TenKH = g.Ten,
                        SDTKH = g.Sdt,
                        TenCH = f.Ten
                    }).ToList();
            return list;
        }

        public List<ThongKeView> GetHD()
        {
            var list = (from a in _ihoaDonRepository.GetAll()
                        join b in _iHDTCCTRepository.GetAll() on a.Id equals b.IdHoaDon
                        join c in _ihoaDonThucAnCTRepository.GetAll() on a.Id equals c.IdHoaDon
                        join d in _ihoaDonDoChoiCTRepository.GetAll() on a.Id equals d.IdHoaDon
                        select new ThongKeView()
                        {
                            MaHD = a.Ma,
                            NgayTaoHD = a.NgayTao,
                            PhanTramGiamGia = a.PhanTramGiamGia,
                            TongTienHang = b.DonGia * b.SoLuong + c.DonGia * c.SoLuong + d.SoLuong * d.DonGia
                        }
                        ).ToList();
            return list;
        }
    }
}
