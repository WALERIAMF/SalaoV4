using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoV4.Data.Map.ChaveComposta
{
    public class ServicesEmployeeMap : IEntityTypeConfiguration<ServicesEmployee>
    {
        public void Configure(EntityTypeBuilder<ServicesEmployee> builder)
        {
            builder.ToTable("ServicesEmployee");

            builder.HasKey(x => new { x.IdServices, x.IdEmployee });

            builder.HasOne(x => x.Services)
                .WithMany(x => x.ServicesEmployee)
                .HasForeignKey(x => x.IdServices);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.ServicesEmployee)
                .HasForeignKey(i => i.IdEmployee);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
