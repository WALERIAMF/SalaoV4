using Microsoft.EntityFrameworkCore;
using SalaoV4.Domain.Model;

namespace SalaoV4.Data.Map
{
    public class ClientSchedulingMap : IEntityTypeConfiguration<ClientScheduling>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ClientScheduling> builder)
        {
            builder.ToTable("ClientScheduling");

            builder.HasKey(x => new { x.IdClient, x.IdScheduling });

            builder.HasOne(x => x.Client)
                .WithMany(x => x.ClientScheduling)
                .HasForeignKey(x => x.IdClient);

            builder.HasOne(x => x.Scheduling)
                .WithMany(x => x.ClientScheduling)
                .HasForeignKey(i => i.IdScheduling);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
