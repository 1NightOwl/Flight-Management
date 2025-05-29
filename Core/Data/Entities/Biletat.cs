using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FlightManagement.Core.Data.Entities
{
    public class Bileta
    {
        public int Id { get; set; }

        public int RouteId { get; set; }
        public Route Route { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public string EmriPasagjerit { get; set; }
        public DateTime DataRezervimit { get; set; }
        public string Statusi { get; set; }
        public string Klasa { get; set; }

        public string Fluturimi { get; set; }

        internal static void ConfigureForDb(EntityTypeBuilder<Bileta> entity)
        {
            entity.ToTable("Biletat");
            entity.HasKey(b => b.Id);

            entity.Property(b => b.EmriPasagjerit)
                  .HasMaxLength(100)
                  .IsRequired();

            entity.Property(b => b.DataRezervimit)
                  .IsRequired();

            entity.Property(b => b.Statusi)
                  .HasMaxLength(20)
                  .IsRequired();

            entity.Property(b => b.Klasa)
                  .HasMaxLength(50)
                  .IsRequired();

            entity.Property(b => b.Fluturimi)
                 .HasMaxLength(200)
                 .IsRequired();

            entity.Property(b => b.RouteId)
                  .IsRequired();
            entity.HasOne(b => b.Route)
                  .WithMany()
                  .HasForeignKey(b => b.RouteId)
                  .OnDelete(DeleteBehavior.Cascade);

            entity.Property(b => b.UserId)
                  .IsRequired();
            entity.HasOne(b => b.User)
                  .WithMany(u => u.Biletat)
                  .HasForeignKey(b => b.UserId)
                  .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
