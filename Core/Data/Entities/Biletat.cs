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
        public string EmriPasagjerit { get; set; }
        public string Fluturimi { get; set; }
        public DateTime DataRezervimit { get; set; }
        public string Statusi { get; set; } // "Ne Pritje", "Pranuar", "Anuluar"
        public string Klasa { get; set; }


        internal static void ConfigureForDb(EntityTypeBuilder<Bileta> entity)
        {
            entity.ToTable("Biletat");
            entity.HasKey(b => b.Id);
            entity.Property(b => b.EmriPasagjerit).HasMaxLength(100);
            entity.Property(b => b.Fluturimi).HasMaxLength(100);
            entity.Property(b => b.Statusi).IsRequired().HasMaxLength(20);
            entity.Property(b => b.DataRezervimit).IsRequired();
            entity.Property(b => b.Klasa).IsRequired().HasMaxLength(50);
        }

    }
}
