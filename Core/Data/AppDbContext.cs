using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Data
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Data.Entities.Planes> Plane { get; set; }
        public DbSet<Data.Entities.Route> Routes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-H71D5BQ\\SQLEXPRESS;Initial Catalog=FlightManagement;Integrated Security=True;Trust Server Certificate=True");

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DQASLH0\\SQLEXPRESS;Initial Catalog=FlightManagement;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Data.Entities.Planes.ConfigureForDb(modelBuilder.Entity<Data.Entities.Planes>());
            Data.Entities.Route.ConfigureForDb(modelBuilder.Entity<Data.Entities.Route>());
        }
    }
}
