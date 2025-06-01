using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Logic.Managers
{
    public class TicketsManager
    {
        public void Add(Bileta bilet)
        {
            if (bilet.UserId == 0)
                bilet.UserId = Session.CurrentUser.Id;

            bilet.DataRezervimit = DateTime.Now;
            if (string.IsNullOrEmpty(bilet.Statusi))
                bilet.Statusi = "Ne Pritje";

            Program.DbContext.Biletat.Add(bilet);
            Program.DbContext.SaveChanges();
        }

        public IEnumerable<Bileta> GetAll()
        {
            return Program.DbContext.Biletat
                .Include(b => b.Route)
                .Include(b => b.User)
                .ToList();
        }
        public void UpdateStatus(int id, string newStatus)
        {
            var bilet = Program.DbContext.Biletat.Find(id)
                        ?? throw new FlightManagementException("Bileta nuk u gjet.");
            bilet.Statusi = newStatus;
            Program.DbContext.SaveChanges();
        }

        public List<Bileta> GetByUserId(int userId)
        {
            return Program.DbContext.Set<Bileta>()
                .Include(b => b.Route)
                    .ThenInclude(r => r.Plane)
                .Where(b => b.UserId == userId)
                .OrderByDescending(b => b.DataRezervimit)
                .ToList();
        }

        public void Delete(int id)
        {
            var bilet = Program.DbContext.Biletat.Find(id)
                        ?? throw new FlightManagementException("Bileta nuk u gjet.");
            Program.DbContext.Biletat.Remove(bilet);
            Program.DbContext.SaveChanges();
        }
    }
}
