using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IMauSacService
    {
        bool Add(MauSacView obj);
        bool Delete(Guid id);
        bool Update(MauSacView obj);
        List<MauSacView> GetAll();
    }
}
