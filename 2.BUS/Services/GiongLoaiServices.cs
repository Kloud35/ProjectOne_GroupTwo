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
    public class GiongLoaiServices : IGiongLoaiServices
    {
        IGiongLoaiRepository _iGiongLoaiRepository;
        public GiongLoaiServices()
        {
            _iGiongLoaiRepository = new GiongLoaiRepository();
        }

        public bool Add(GiongLoaiView obj)
        {
            if (obj == null)
            {
                return false;
            }
            var x = new GiongLoai()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                XuatXu = obj.XuatXu
            };
            _iGiongLoaiRepository.Add(x);
            return true;
        }

        public bool Delete(GiongLoaiView obj)
        {
            if (obj == null)
            {
                return false;
            }
            var GL = new GiongLoai()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                XuatXu = obj.XuatXu
            };
            _iGiongLoaiRepository.Delete(GL); return true;

        }

        public List<GiongLoaiView> GetAll()
        {
            List<GiongLoaiView> lstGL = new List<GiongLoaiView>();
            lstGL = (from a in _iGiongLoaiRepository.GetAll()
                     select new GiongLoaiView
                     {
                         Id = a.Id,
                         Ma = a.Ma,
                         Ten = a.Ten,
                         XuatXu = a.XuatXu
                     }).ToList();
            return lstGL;
        }

        public bool Update(GiongLoaiView obj)
        {
            if (obj == null)
            {
                return false;
            }
            var GL = new GiongLoai()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                Ten = obj.Ten,
                XuatXu = obj.XuatXu
            };
            _iGiongLoaiRepository.Update(GL); return true;
        }
    }
}
