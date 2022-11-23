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
    public class ChucVuServices : IChucVuServices
    {
        IChucVuRepository _iChucVuRepository;
        public ChucVuServices()
        {
            _iChucVuRepository = new ChucVuRepository();
        }

        public bool Add(ChucVuView obj)
        {
            if (obj == null) return false;
            var x = new ChucVu()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            _iChucVuRepository.Add(x);
            return true;
        }

        public bool Delete(ChucVuView obj)
        {
            if(obj == null) return false;
            var x = _iChucVuRepository.GetAll().FirstOrDefault(x=>x.Id == obj.Id);
            _iChucVuRepository.Delete(x);
            return true;
        }

        public List<ChucVuView> GetAll()
        {
            var list = (from a in _iChucVuRepository.GetAll()
                        select new ChucVuView
                        {
                            Id = a.Id,
                            Ma = a.Ma,
                            Ten = a.Ten
                        }).ToList();
            return list;
        }

        public bool Update(ChucVuView obj)
        {
            if (obj == null) return false;
            var x = _iChucVuRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            x.Ten = obj.Ten;
            x.Ma = obj.Ma;
            _iChucVuRepository.Update(x);
            return true;
        }
    }
}
