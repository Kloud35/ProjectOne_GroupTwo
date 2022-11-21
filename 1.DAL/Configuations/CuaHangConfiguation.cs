using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configuation
{
    public class CuaHangConfiguation : IEntityTypeConfiguration<CuaHang>
    {
        public void Configure(EntityTypeBuilder<CuaHang> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ma).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.DiaChi).HasColumnType("nvarchar(100)").IsRequired();
            builder.Property(x => x.Sdt).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
