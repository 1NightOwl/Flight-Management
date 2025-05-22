using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Data.Entities
{
    public class Planes
    {
        public int Id { get; set; }
        public int PlaneId { get; set; }
        public string Model { get; set; }
        public string Registration { get; set; }
        public int SeatCount { get; set; }
        public int RangeKm { get; set; }
        public string Status { get; set; }
        public bool HasClasses { get; set; }
        public double BuisnessFactor { get; set; }
        public double FirstClassFactor { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Planes> builder)
        {
            builder.ToTable("Planes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.PlaneId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Plane Id");

            builder.HasIndex(x => x.PlaneId)
                .IsUnique();

            builder.Property(x => x.Model).HasMaxLength(100);
            builder.Property(x => x.Registration)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.HasIndex(x => x.Registration)
                   .IsUnique();

            builder.Property(x => x.SeatCount).IsRequired();
            builder.Property(x => x.RangeKm).IsRequired();
            builder.Property(x => x.Status).HasMaxLength(30);

            builder.Property(x => x.HasClasses).IsRequired();
            builder.Property(x => x.BuisnessFactor).HasDefaultValue(1.5);
            builder.Property(x => x.FirstClassFactor).HasDefaultValue(2.0);

            builder.Property(x => x.CreatedDate)
                                   .HasColumnType("date")
                                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedDate)
                                   .HasColumnType("date");
        }
    }
}
