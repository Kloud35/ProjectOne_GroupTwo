using _1.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configuations
{
    public class GiongLoaiConfiguation : IEntityTypeConfiguration<GiongLoai>
    {
        public void Configure(EntityTypeBuilder<GiongLoai> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ma).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)").IsRequired();
            builder.Property(x => x.XuatXu).HasColumnType("nvarchar(100)").IsRequired();
        }
    }
}
