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
    public class Route
    {
        public int Id { get; set; }
        public int PlaneId { get; set; }
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string DepartureDay { get; set; }
        public string Status { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public int Price { get; set; }
        public Planes Plane { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public static void ConfigureForDb(EntityTypeBuilder<Route> builder)
        {
            builder.ToTable("Routes");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Departure).HasMaxLength(50);
            builder.Property(x => x.Arrival).HasMaxLength(50);
            builder.Property(x => x.DepartureDay).HasMaxLength(20);

            builder.Property(x => x.StartTime).IsRequired();
            builder.Property(x => x.EndTime).IsRequired();
            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.Status).HasMaxLength(30);
            builder.Property(x => x.Status)
                                   .HasMaxLength(30)
                                   .HasDefaultValue("Aktiv")
                                   .IsRequired();

            builder.HasOne(x => x.Plane)
                   .WithMany()
                   .HasForeignKey(x => x.PlaneId)
                   .OnDelete(DeleteBehavior.Cascade);

            builder.Property(x => x.CreatedDate)
                                   .HasColumnType("date")
                                   .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedDate)
                                   .HasColumnType("date");
        }
    }
}
