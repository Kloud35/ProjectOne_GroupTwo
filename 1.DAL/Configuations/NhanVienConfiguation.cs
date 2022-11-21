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
    public class NhanVienConfiguation : IEntityTypeConfiguration<NhanVien>
    {
        public void Configure(EntityTypeBuilder<NhanVien> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ma).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Ho).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.TenDem).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.NgaySinh).HasColumnType("DateTime").IsRequired();
            builder.Property(x => x.GioiTinh).HasColumnType("nvarchar(10)").IsRequired();
            builder.Property(x => x.Sdt).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(x => x.Email).HasColumnType("nvarchar(255)").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.ThanhPho).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.QuocGia).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.MatKhau).HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(x => x.TrangThai).HasColumnType("int").IsRequired();

            builder.HasOne(x => x.CuaHang)
                .WithMany()
                .HasForeignKey(p => p.IdCuaHang);
            builder.HasOne(x => x.ChucVu)
                .WithMany()
                .HasForeignKey(p => p.IdChucVu);

        }
    }
}