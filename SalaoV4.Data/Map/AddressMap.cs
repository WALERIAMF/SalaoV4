using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;


namespace SalaoV4.Data.Map
{
    public class AddressMap : IEntityTypeConfiguration<Address>
    {

        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");

            builder.HasKey(i => i.Id);

            builder.Property(c => c.Cidade)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(u => u.UF)
                 .HasColumnType("varchar(100)")
                   .IsRequired();

            builder.Property(l => l.Logradouro)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder.Property(c => c.CEP)
                .HasColumnType("varchar(8)")
                .IsRequired();

            builder.Property(c => c.Complemento)
                .HasColumnType("varchar(50)");


        }
    }

}
