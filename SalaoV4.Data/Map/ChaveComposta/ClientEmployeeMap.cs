using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaoV4.Data.Map
{
    class ClientEmployeeMap : IEntityTypeConfiguration<ClientEmployee>
    {
        public void Configure(EntityTypeBuilder<ClientEmployee> builder)
        {
            builder.ToTable("ClientEmployee");

            builder.HasKey(x => new { x.IdClient, x.IdEmployee });

            builder.HasOne(x => x.Client)
                .WithMany(x => x.ClientEmployee)
                .HasForeignKey(x => x.IdClient);

            builder.HasOne(x => x.Employee)
                .WithMany(x => x.ClientEmployees)
                .HasForeignKey(i => i.IdEmployee);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
