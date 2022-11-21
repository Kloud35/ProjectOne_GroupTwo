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
    public class GioHangConfiguation : IEntityTypeConfiguration<GioHang>
    {
        public void Configure(EntityTypeBuilder<GioHang> builder)
        {
            builder.HasKey(x => x.Id);//khóa chính
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IdKhachHang).HasColumnName("IdKhachHang").IsRequired();
            builder.Property(x => x.IdNhanVien).HasColumnName("IdNhanVien").IsRequired();
            builder.Property(x => x.Ma).HasColumnName("Ma").HasColumnType("varchar(30)").IsRequired();
            builder.Property(x => x.NgayTao).HasColumnName("NgayTao").
                HasColumnType("Datetime").IsRequired();
            builder.Property(x => x.NgayThanhToan).HasColumnName("NgayThanhToan").
                HasColumnType("Datetime").IsRequired();
            builder.Property(x => x.TenNguoiNhan).HasColumnName("TenNguoiNhan").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(x => x.TinhTrang).HasColumnName("TinhTrang").HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnName("DiaChi").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Sdt).HasColumnName("Sdt").HasColumnType("varchar(11)").IsRequired();
            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(x => x.IdKhachHang);
            builder.HasOne(x => x.NhanVien).WithMany().HasForeignKey(x => x.IdNhanVien);
        }
    }
}
