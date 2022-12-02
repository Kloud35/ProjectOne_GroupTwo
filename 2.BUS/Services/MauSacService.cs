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
    public class MauSacService : IMauSacService
    {
        IMauSacRepository _imauSacRepository;
        public MauSacService()
        {
            _imauSacRepository = new MauSacRepository();
        }

        public bool Add(MauSacView obj)
        {
            if (obj == null) return false;
            var x = new MauSac()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten
            };
            _imauSacRepository.Add(x);
            return true;
        }

        public bool Delete(MauSacView obj)
        {
            if (obj == null) return false;
            var x = _imauSacRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            _imauSacRepository.Delete(x);
            return true;
        }

        public List<MauSacView> GetAll()
        {
            var list = (from a in _imauSacRepository.GetAll()
                        select new MauSacView
                        {
                            Id = a.Id,
                            Ma = a.Ma,
                            Ten = a.Ten
                        }).ToList();
            return list;
        }

        public bool Update(MauSacView obj)
        {
            if (obj == null) return false;
            var x = _imauSacRepository.GetAll().FirstOrDefault(x => x.Id == obj.Id);
            x.Ten = obj.Ten;
            x.Ma = obj.Ma;
            _imauSacRepository.Update(x);
            return true;
        }
    }
}

