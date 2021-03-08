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
    public class SchedulingEmployeeMap : IEntityTypeConfiguration<SchedulingEmployee>
    {
        public void Configure(EntityTypeBuilder<SchedulingEmployee> builder)
        {
            builder.ToTable("SchedulingEmployee");

            builder.HasKey(x => new { x.IdScheduling, x.IdEmployee });

            builder.HasOne(x => x.Scheduling)
                .WithMany(x => x.SchedulingEmployee)
                .HasForeignKey(x => x.IdScheduling);

            builder.HasOne(x => x.Employee)
                        .WithMany(x => x.SchedulingEmployee)
                        .HasForeignKey(i => i.IdEmployee);

            builder.Property(x => x.Id)
                        .UseIdentityColumn();
        }
    }
}
