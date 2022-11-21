﻿using _1.DAL.IRepository;
using _1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Repository
{
    public class DoChoiRepository : IDoChoiRepository
    {
        PetShopDbContext _dbContext;

        public DoChoiRepository()
        {
            _dbContext = new PetShopDbContext();
        }

        public bool Add(DoChoi obj)
        {
            if (obj == null) return false;
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DoChoi obj)
        {
            if (obj == null) return false;
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
            return true;
        }

        public List<DoChoi> GetAll()
        {
            return _dbContext.DoChoi.ToList();
        }

        public bool Update(DoChoi obj)
        {
            if (obj == null) return false;
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
            return true;
        }
    }
}
