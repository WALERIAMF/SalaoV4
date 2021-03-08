using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SalaoV4.Domain.Model;

namespace SalaoV4.Data
{
    public class ClientMap : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.ToTable("Client");

            builder.HasKey(i => i.Id);
            
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
    }
}
