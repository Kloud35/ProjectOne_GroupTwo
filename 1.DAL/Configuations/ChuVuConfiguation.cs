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
    public class ChuVuConfiguation : IEntityTypeConfiguration<ChucVu>
    {
        public void Configure(EntityTypeBuilder<ChucVu> builder)
        {
            builder.HasKey(x => x.Id);//khóa chính
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ma).HasColumnType("varchar(50)").IsRequired();//kiểu dữ liệu & not null
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
