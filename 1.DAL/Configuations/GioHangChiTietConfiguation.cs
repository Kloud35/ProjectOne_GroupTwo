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
    public class GioHangChiTietConfiguation:IEntityTypeConfiguration<GioHangChiTiet>
    {
        public void Configure(EntityTypeBuilder<GioHangChiTiet> builder)
        {
            builder.HasKey(x => x.Id);//khóa chính
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.IdGioHang).IsRequired();
            builder.Property(x => x.IdThuCungChiTiet).HasColumnName("IdThuCungCT").IsRequired();
            builder.Property(x => x.IdThucAnChiTiet).HasColumnName("IdThucAnCT").IsRequired();
            builder.Property(x => x.IdDoChoiChiTiet).HasColumnName("IdDoChoiCT").IsRequired();
            builder.Property(x => x.SoLuong).HasColumnName("SoLuong").HasColumnType("int").IsRequired();
            builder.Property(x => x.DonGia).HasColumnName("DonGia").HasColumnType("Decimal").IsRequired();
            builder.Property(x => x.Voucher).HasColumnName("Voucher").HasColumnType("Decimal").IsRequired();
            builder.HasOne(x => x.GioHang).WithMany().HasForeignKey(p => p.IdGioHang);
            builder.HasOne(x => x.ThuCungChiTiet).WithMany().HasForeignKey(p => p.IdThuCungChiTiet);
            builder.HasOne(x => x.ThucAnChiTiet).WithMany().HasForeignKey(p => p.IdThucAnChiTiet);
            builder.HasOne(x => x.DoChoiChiTiet).WithMany().HasForeignKey(p => p.IdDoChoiChiTiet);
        }
    }
}
