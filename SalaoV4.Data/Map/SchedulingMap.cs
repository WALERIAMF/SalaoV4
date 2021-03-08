using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;
using System;

namespace SalaoV4.Data.Map
{
    public class SchedulingMap : IEntityTypeConfiguration<Scheduling>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {

            builder.ToTable("Scheduling");

            builder.HasKey(i => new { i.Id });

            builder.Property(c => c.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(n => n.Name)
                .HasColumnType("var(200")
                .IsRequired();

            builder.Property(p => p.Phone)
                .HasColumnType("varchar(13)")
                .IsRequired();

            builder.Property(a => a.Active)
                .IsRequired();

        }

        public void Configure(EntityTypeBuilder<Scheduling> builder)
        {
            throw new NotImplementedException();
        }
    }
}
