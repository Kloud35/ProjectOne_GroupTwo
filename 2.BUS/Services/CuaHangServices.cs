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
    public class CuaHangServices : ICuaHangServices
    {
        ICuaHangRepository _iCuaHangRepository;
        public CuaHangServices()
        {
            _iCuaHangRepository = new CuaHangRepository();
        }

        public bool Add(CuaHangView obj)
        {
            if (obj == null) return false;
            var x = new CuaHang()
            {
                DiaChi = obj.DiaChi,
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                Sdt = obj.Sdt
            };
            _iCuaHangRepository.Add(x);
            return true;
        }

        public bool Delete(CuaHangView obj)
        {
            throw new NotImplementedException();
        }

        public List<CuaHangView> GetAll()
        {
            var list = (from a in _iCuaHangRepository.GetAll()
                        select new CuaHangView
                        {
                            Id = a.Id,
                            Ma = a.Ma,
                            DiaChi = a.DiaChi,
                            Ten = a.Ten,
                            Sdt = a.Sdt
                        }).ToList();
            return list;
        }

        public bool Update(CuaHangView obj)
        {
            throw new NotImplementedException();
        }
    }
}
