using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ManagerAPI.DataCore
{
    public class DataContext : DbContext
    {
        public DbSet<DbContract> Contracts { get; set; }
        public DbSet<DbGenericType> GenericTypes { get; set; }
        public DbSet<DbObject> Objects { get; set; }
        public DbSet<DbObjectProperty> ObjectProperties { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
