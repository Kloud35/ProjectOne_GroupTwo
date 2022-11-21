using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configuations
{
    public class KhachHangConfiguation : IEntityTypeConfiguration<KhachHang>
    {
        public void Configure(EntityTypeBuilder<KhachHang> builder)
        {
            builder.HasKey(x => x.Id);//khóa chính
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ma).HasColumnName("MaKH").HasColumnType("varchar(50)").IsRequired();//kiểu dữ liệu & not null
            builder.Property(x => x.Ho).HasColumnName("HoKH").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.TenDem).HasColumnName("TenDemKH").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Ten).HasColumnName("TenKH").HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.NgaySinh).HasColumnName("NgaySinh").HasColumnType("Datetime").IsRequired();
            builder.Property(x => x.GioiTinh).HasColumnName("GioiTinh").HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.Sdt).HasColumnName("SĐT").HasColumnType("varchar(20)").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnName("DiaChi").HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.ThanhPho).HasColumnName("ThanhPho").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.QuocGia).HasColumnName("QuocGia").HasColumnType("nvarchar(max)").IsRequired();
        }
    }
}
