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
    public class RequestServicesEmployeeMap : IEntityTypeConfiguration<RequestServicesEmployee>
    {
        public void Configure(EntityTypeBuilder<RequestServicesEmployee> builder)
        {
             builder.ToTable("RequestServicesEmployee>");

            builder.HasKey(x => new { x.IdEmployee, x.IdRequestServices });

            builder.HasOne(t => t.Employee)
                .WithMany(tp => tp.RequestServicesEmployee)
                .HasForeignKey(i => i.IdEmployee);

            builder.HasOne(p => p.RequestedService)
                .WithMany(tp => tp.RequestServicesEmployee)
                .HasForeignKey(i => i.IdRequestServices);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
