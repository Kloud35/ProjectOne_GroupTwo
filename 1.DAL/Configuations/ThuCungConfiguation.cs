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
    public class ThuCungConfiguation : IEntityTypeConfiguration<ThuCung>
    {
        public void Configure(EntityTypeBuilder<ThuCung> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ma).HasColumnType("varchar(50)").IsRequired();
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}
