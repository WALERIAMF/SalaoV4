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
    public class RequestServicesClientMap : IEntityTypeConfiguration<RequestServicesClient>
    {
        public void Configure(EntityTypeBuilder<RequestServicesClient> builder)
        {
            builder.ToTable("RequestServicesClientMap");

            builder.HasKey(x => new { x.IdRequestServices, x.IdClient});

            builder.HasOne(x => x.RequestedService)
                .WithMany(x => x.RequestServicesClient)
                .HasForeignKey(x => x.IdRequestServices);

            builder.HasOne(x => x.Client)
                .WithMany(x => x.RequestServicesClient)
                .HasForeignKey(x => x.Client);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }


    }
}
