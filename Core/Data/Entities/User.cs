using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Role { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public ICollection<Bileta> Biletat { get; set; } = new List<Bileta>();
        public static void ConfigureForDb(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Username)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasIndex(x => x.Username)
                .IsUnique();

            builder.Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(256);

            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Role)
                .HasMaxLength(20)
                .HasDefaultValue("User");

            builder.Property(x => x.CreatedDate)
                .HasColumnType("date")
                .HasDefaultValueSql("GETDATE()");

            builder.Property(x => x.UpdatedDate)
                .HasColumnType("date");
        }
    }
}
