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
    public class ThuCungChiTietConfiguation : IEntityTypeConfiguration<ThuCungChiTiet>
    {
        public void Configure(EntityTypeBuilder<ThuCungChiTiet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.CanNang).HasColumnType("decimal").IsRequired();
            builder.Property(x => x.ChieuDai).HasColumnType("decimal").IsRequired();
            builder.Property(x => x.GioiTinh).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.Tuoi).HasColumnType("int").IsRequired();
            builder.Property(x => x.SoLuong).HasColumnType("int").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();
            builder.Property(x => x.GiaNhap).HasColumnType("decimal").IsRequired();
            builder.Property(x => x.GiaBan).HasColumnType("decimal").IsRequired();
            builder.Property(x => x.Image).HasColumnType("VARBINARY(MAX)").IsRequired();
            builder.HasOne(x => x.ThuCung).WithMany().HasForeignKey(x => x.IdThuCung);
            builder.HasOne(x => x.GiongLoai).WithMany().HasForeignKey(x => x.IdGiongLoai);
            builder.HasOne(x => x.MauSac).WithMany().HasForeignKey(x => x.IdMauSac);
        }
    }
}
