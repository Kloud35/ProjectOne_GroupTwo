using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Models
{
    public class PetShopDbContext : DbContext
    {
        string connectionString = "Data Source=DESKTOP-ABEN704\\SQLEXPRESS;Initial Catalog=PetShop;Persist Security Info=True;User ID=kloud35;Password=123123;";
        public PetShopDbContext()
        {
        }
        
        public PetShopDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ChucVu> ChucVu { get; set; }
        public DbSet<CuaHang> CuaHang { get; set; }
        public DbSet<DoChoiChiTiet> DoChoiChiTiet { get; set; }
        public DbSet<DoChoi> DoChoi { get; set; }
        public DbSet<GiongLoai> GiongLoai { get; set; }
        public DbSet<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public DbSet<HoaDon> HoaDon { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<MauSac> MauSac { get; set; }
        public DbSet<NhanVien> NhanVien { get; set; }
        public DbSet<ThucAnChiTiet> ThucAnChiTiet { get; set; }
        public DbSet<ThucAn> ThucAn { get; set; }
        public DbSet<ThuCungChiTiet> ThuCungChiTiet { get; set; }
        public DbSet<ThuCung> ThuCung { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //buid database
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // set all config
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
