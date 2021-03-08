using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;


namespace SalaoV4.Data.Map
{
    public class EmployeeMap : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employee");

            builder.HasKey(i => i.Id);

            builder.Property(n => n.Name)
                .HasColumnType("varchar(4)")
                .IsRequired();

            builder.Property(c => c.Cpf)
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(p => p.Phone)
                .HasColumnType("varchar(4)")
                .IsRequired();

            builder.Property(p => p.Position)
                .HasColumnType("varchar(4)");

            builder.Property(de => de.HorarioEntrada)
                .HasColumnType("time(7)");

            builder.Property(ds => ds.HorarioSaida)
                .HasColumnType("time(7)");

            builder.Property(a => a.Active)
                   .IsRequired();

        }
    }

}
