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
    public class HoaDonThucAnChiTietConfiguation : IEntityTypeConfiguration<HoaDonThucAnChiTiet>
    {
        public void Configure(EntityTypeBuilder<HoaDonThucAnChiTiet> builder)
        {
            builder.HasKey(x => x.Id);//khóa chính
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IdHoaDon).IsRequired();
            builder.Property(x => x.IdThucAnChiTiet).IsRequired();
            builder.Property(x => x.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(x => x.DonGia).HasColumnName("DonGia").HasColumnType("Decimal").IsRequired();
            builder.HasOne(x => x.HoaDon).WithMany().HasForeignKey(p => p.IdHoaDon);
            builder.HasOne(x => x.ThucAnChiTiet).WithMany().HasForeignKey(p => p.IdThucAnChiTiet);
        }
    }
}
