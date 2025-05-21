using FlightManagement.Core.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Logic.Managers
{
    public class RoutesManager
    {
        public void AddRoute(Route route)
        {
            Program.DbContext.Routes.Add(route);
            Program.DbContext.SaveChanges();
        }

        public void UpdateRoute(int id, Route updated)
        {
            var dbRoute = Program.DbContext.Routes.Find(id)
                         ?? throw new Exception("Rruga nuk u gjet.");

            dbRoute.Departure = updated.Departure;
            dbRoute.Arrival = updated.Arrival;
            dbRoute.StartTime = updated.StartTime;
            dbRoute.EndTime = updated.EndTime;
            dbRoute.DepartureDay = updated.DepartureDay;
            dbRoute.PlaneId = updated.PlaneId;
            dbRoute.Price = updated.Price;
            dbRoute.UpdatedDate = DateTime.Now;

            Program.DbContext.SaveChanges();
        }

        public List<Route> GetAllRoutes() =>
            Program.DbContext.Routes
                   .Include(r => r.Plane)
                   .ToList();

        public Route? GetById(int id) =>
            Program.DbContext.Routes.Find(id);

        public void DeleteRoute(int id)
        {
            var route = Program.DbContext.Routes.Find(id)
                         ?? throw new Exception("Rruga nuk ekziston.");
            Program.DbContext.Routes.Remove(route);
            Program.DbContext.SaveChanges();
        }
    }
}
