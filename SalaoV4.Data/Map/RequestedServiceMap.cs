using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;

namespace SalaoV4.Data.Map
{
    public class RequestedServiceMap : IEntityTypeConfiguration<RequestedService>
    {
        public void Configure(EntityTypeBuilder<RequestedService> builder)
        {
            builder.ToTable("RequestedService");

            builder.HasKey(i => i.Id);

            builder.Property(n => n.Active)
                .IsRequired();

        }
    }
}