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
    public class HoaDonConfiguation : IEntityTypeConfiguration<HoaDon>
    {
        public void Configure(EntityTypeBuilder<HoaDon> builder)
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
            builder.Property(x => x.NgayGiaoHang).HasColumnName("NgayGiaoHang").
                HasColumnType("Datetime").IsRequired(); 
            builder.Property(x => x.NgayNhan).HasColumnName("NgayNhan").
                HasColumnType("Datetime").IsRequired();
            builder.Property(x => x.TienCoc).HasColumnType("decimal");
            builder.Property(x => x.TienShip).HasColumnType("decimal");
            builder.Property(x => x.PhanTramGiamGia).HasColumnType("decimal");
            builder.Property(x => x.TenNguoiNhan).HasColumnName("TenNguoiNhan").HasColumnType("nvarchar(30)").IsRequired();
            builder.Property(x => x.TinhTrang).HasColumnName("TinhTrang").HasColumnType("int").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnName("DiaChi").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Sdt).HasColumnName("Sdt").HasColumnType("varchar(11)").IsRequired();
            builder.HasOne(x => x.KhachHang).WithMany().HasForeignKey(x => x.IdKhachHang);
            builder.HasOne(x => x.NhanVien).WithMany().HasForeignKey(x => x.IdNhanVien);
        }
    }
}