using ManagerAPI.DataCore.Configuration;
using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ManagerAPI.DataCore
{
    public class DataContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<DbContract> Contracts { get; set; }
        public DbSet<DbGenericType> GenericTypes { get; set; }
        public DbSet<DbObject> Objects { get; set; }
        public DbSet<DbObjectProperty> ObjectProperties { get; set; }

        public DataContext(string connectionString) 
        {
            _connectionString = connectionString;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
