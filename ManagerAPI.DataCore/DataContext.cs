using ManagerAPI.DataCore.DomainModel;
using Microsoft.EntityFrameworkCore;

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

            modelBuilder.Entity<DbObjectProperty>()
                .HasOne(x => x.Status)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<DbObject>()
                .HasMany(x => x.ObjectProperties)
                .WithOne(x => x.ObjectOwner)
                .OnDelete(DeleteBehavior.Restrict);
            
        }
    }
}
