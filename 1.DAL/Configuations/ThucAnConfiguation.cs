using _1.DAL.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DAL.Configuations
{
    public class ThucAnConfiguation : IEntityTypeConfiguration<ThucAn>
    {
        public void Configure(EntityTypeBuilder<ThucAn> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Ma).HasColumnType("varchar(10)").IsRequired();
            builder.Property(x => x.Ten).HasColumnType("nvarchar(50)").IsRequired();
        }
    }
}

