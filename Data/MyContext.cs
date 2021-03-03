using System;
using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options){ }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            // Seed data
            modelBuilder.Entity<Person>().HasData(new Person() {Id = new Guid("c1fb12f4-a475-4557-98c9-6ed0a52539a4"), Name = "Dayanaris", Family = "Targarien"});
        }
    }
}