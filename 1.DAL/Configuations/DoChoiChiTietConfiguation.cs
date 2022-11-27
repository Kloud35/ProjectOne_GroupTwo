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
    public class DoChoiChiTietConfiguation : IEntityTypeConfiguration<DoChoiChiTiet>
    {
        public void Configure(EntityTypeBuilder<DoChoiChiTiet> builder)
        {
            builder.ToTable("DoChoiChiTiet");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Loai).HasColumnName("Loai").
                HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.GiaNhap).HasColumnName("GiaNhap").
                HasColumnType("int").IsRequired();
            builder.Property(x => x.GiaBan).HasColumnName("GiaBan").
                HasColumnType("int").IsRequired();
            builder.Property(x => x.SoLuongTon).HasColumnName("SoLuongTon").
                HasColumnType("int").IsRequired();
            builder.Property(x => x.Nsx).HasColumnName("Nsx").
                HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Image).HasColumnType("nvarchar(max)").IsRequired();
            builder.Property(x => x.Barcode).HasColumnType("nvarchar(max)").IsRequired();
            builder.HasOne(x => x.DoChoi).WithMany().HasForeignKey(x => x.IdDoChoi);
        }
    }
}