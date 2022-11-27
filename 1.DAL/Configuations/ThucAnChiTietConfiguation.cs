using _1.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configuations
{
    public class ThucAnChiTietConfiguation : IEntityTypeConfiguration<ThucAnChiTiet>
    {

        public void Configure(EntityTypeBuilder<ThucAnChiTiet> builder)
        {
            builder.HasKey(x => x.Id);// khoá chính
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Loai).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.GiaBan).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.GiaNhap).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Nsx).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.SoLuongTon).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Image).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.Barcode).HasColumnType("nvarchar(max)").IsRequired();
            builder.HasOne(x => x.ThucAn).WithMany().HasForeignKey(x => x.IdThucAn);

        }
    }
}

