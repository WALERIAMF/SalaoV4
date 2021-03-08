using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;
using SalaoV4.Domain.Model.GestaoAgendamento;

namespace SalaoV4.Data.Map
{
    public class ServicesMap : IEntityTypeConfiguration<Services>
    {
        public void Configure(EntityTypeBuilder<Services> builder)
        {
            builder.ToTable("Services");

            builder.HasKey(i => i.Id);

            builder.Property(n => n.Name)
                 .HasColumnType("varchar(200)")
                   .IsRequired();

            builder.Property(n => n.MinutesForExecution)
                .HasColumnType("varchar(3)")
                .IsRequired();

            builder.Property(p => p.Price)
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder.Property(a => a.Active)
                 .IsRequired();
        }
    }
}
