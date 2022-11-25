using _2.BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.IServices
{
    public interface IKhachHangServices
    {
        bool Add(KhachHangView  obj);
        bool Delete(Guid id);
        bool Update(KhachHangView obj);
        List<KhachHangView> GetAll();
    }
}
