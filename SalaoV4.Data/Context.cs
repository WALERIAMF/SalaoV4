

using Microsoft.EntityFrameworkCore;
using SalaoV4.Data.Map;
using SalaoV4.Data.Map.ChaveComposta;
using SalaoV4.Domain.Model;


namespace SalaoV4.Data
{
    public class Context : DbContext
    {
        public DbSet<Address> Address { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<RequestedService> RequestedService { get; set; }
        public DbSet<Scheduling> Scheduling { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<ClientEmployee> ClientEmployee { get; set; }
        public DbSet<ClientScheduling> ClientScheduling { get; set; }
        public DbSet<RequestServicesClient> RequestServicesClient { get; set; }
        public DbSet<RequestServicesEmployee> RequestServicesEmployee { get; set; }
        public DbSet<SchedulingEmployee> SchedulingEmployee { get; set; }
        public DbSet<ServicesEmployee> ServicesEmployee { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0E2MGV9\\SQLEXPRESS; Database=Salao; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AddressMap());
            modelBuilder.ApplyConfiguration(new ClientMap());
            modelBuilder.ApplyConfiguration(new EmployeeMap());
            modelBuilder.ApplyConfiguration(new RequestedServiceMap());
            modelBuilder.ApplyConfiguration(new SchedulingMap());
            modelBuilder.ApplyConfiguration(new ServicesMap());
            modelBuilder.ApplyConfiguration(new ClientEmployeeMap());
            modelBuilder.ApplyConfiguration(new ClientSchedulingMap());
            modelBuilder.ApplyConfiguration(new RequestServicesClientMap());
            modelBuilder.ApplyConfiguration(new RequestServicesEmployeeMap());
            modelBuilder.ApplyConfiguration(new SchedulingEmployeeMap());
            modelBuilder.ApplyConfiguration(new ServicesEmployeeMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
