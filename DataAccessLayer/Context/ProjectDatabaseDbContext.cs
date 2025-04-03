using DataAccessLayer.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Models.Entities;

namespace DataAccessLayer.Context
{
    public class ProjectDatabaseContext : DbContext
    {
        // Constructor for normal usage (dependency injection, etc.)
        public ProjectDatabaseContext(DbContextOptions<ProjectDatabaseContext> options) : base(options)
        {
        }

        // Constructor for when setting up connection string manually (e.g., design-time or migrations)
        public ProjectDatabaseContext() { }

        // DbSets for the models
        public DbSet<Room>Rooms { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        // OnConfiguring method for setting up the connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Set the connection string manually
                string connectionString = "Server=DESKTOP-BC8DJ2E\\SQLEXPRESS;Database=BilgeHotelDbNtier;Trusted_Connection=True;TrustServerCertificate=true;";
                optionsBuilder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        // OnModelCreating method for additional configuration (e.g., relationships, constraints, etc.)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
            modelBuilder.ApplyConfiguration(new ShiftConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
           modelBuilder.ApplyConfiguration(new ReservationConfiguration());

            //here you can apply any specific configurations if needed, such as relationships or indexes
            base.OnModelCreating(modelBuilder);
        }
    }
}
