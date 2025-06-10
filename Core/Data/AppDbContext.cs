using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Data.Entities.Planes> Plane { get; set; }
        public DbSet<Data.Entities.Route> Routes { get; set; }
        public DbSet<Data.Entities.Bileta> Biletat { get; set; }
        public DbSet<Data.Entities.User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //string Ergi
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H71D5BQ\\SQLEXPRESS;Initial Catalog=FlightManagement;Integrated Security=True;Trust Server Certificate=True");

            //String Eris
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-DQASLH0\\SQLEXPRESS;Initial Catalog=FlightManagement;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Data.Entities.Planes.ConfigureForDb(modelBuilder.Entity<Data.Entities.Planes>());
            Data.Entities.Route.ConfigureForDb(modelBuilder.Entity<Data.Entities.Route>());
            Data.Entities.Bileta.ConfigureForDb(modelBuilder.Entity<Data.Entities.Bileta>());
            Data.Entities.User.ConfigureForDb(modelBuilder.Entity<Data.Entities.User>());
        }
    }
}
