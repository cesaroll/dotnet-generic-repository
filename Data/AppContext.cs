using System.Reflection;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options) : base(options){ }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Seed data
            modelBuilder.Entity<Person>().HasData(new Person() { Name = "Dayanaris", Family = "Targarien"});
        }
    }
}