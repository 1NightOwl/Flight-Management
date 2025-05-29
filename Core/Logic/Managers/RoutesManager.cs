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
    public class RoutesManager
    {
        public void AddRoute(Route route)
        {
            Program.DbContext.Routes.Add(new Route
            {
                PlaneId = route.PlaneId,
                Departure = route.Departure,
                Arrival = route.Arrival,
                DepartureDay = route.DepartureDay,
                StartTime = route.StartTime,
                EndTime = route.EndTime,
                Status = "Aktiv",
                Price = route.Price,
                CreatedDate = DateTime.Now
            });

            Program.DbContext.SaveChanges();
        }

        public void UpdateRoute(int id, Route updated)
        {
            var dbRoute = Program.DbContext.Routes.Find(id)
                         ?? throw new FlightManagementException("Rruga nuk u gjet.");

            dbRoute.Departure = updated.Departure;
            dbRoute.Arrival = updated.Arrival;
            dbRoute.StartTime = updated.StartTime;
            dbRoute.EndTime = updated.EndTime;
            dbRoute.DepartureDay = updated.DepartureDay;
            dbRoute.PlaneId = updated.PlaneId;
            dbRoute.Status = updated.Status ?? dbRoute.Status;
            dbRoute.Price = updated.Price;
            dbRoute.UpdatedDate = DateTime.Now;

            Program.DbContext.SaveChanges();
        }

        public IEnumerable<Route> FindDirect(
        string from, string to, string departureDay)
        {
            return Program.DbContext.Routes
                .Include(r => r.Plane)
                .Where(r => r.Departure == from &&
                            r.Arrival == to &&
                            r.DepartureDay == departureDay &&
                            r.Status == "Aktiv")
                .ToList();
        }

        public IEnumerable<(Route FirstLeg, Route SecondLeg)> FindConnections(
            string from, string to, string departureDay,
             TimeSpan minLayover, TimeSpan maxLayover)
        {
            var all = Program.DbContext
            .Routes
            .Include(r => r.Plane)
            .Where(r => r.DepartureDay == departureDay && r.Status == "Aktiv")
            .ToList();

            var firstLegs = all.Where(r => r.Departure == from);

            var secondLegs = all.Where(r => r.Arrival == to);

            var connections = from leg1 in firstLegs
                              from leg2 in secondLegs
                              where leg1.Arrival == leg2.Departure 
                                 && leg2.StartTime > leg1.EndTime   
                                 && (leg2.StartTime - leg1.EndTime) >= minLayover
                                 && (leg2.StartTime - leg1.EndTime) <= maxLayover
                              select (FirstLeg: leg1, SecondLeg: leg2);

            return connections.ToList();
        }

        public List<Route> GetAllRoutes()
        {
            return Program.DbContext
               .Routes
               .Include(r => r.Plane)
               .ToList();
        }

        public Route? GetById(int id) =>
            Program.DbContext.Routes.Find(id);

        public void DeleteRoute(int id)
        {
            var route = Program.DbContext.Routes.Find(id) ?? throw new FlightManagementException("Rruga nuk u gjet!");
            Program.DbContext.Routes.Remove(route);
            Program.DbContext.SaveChanges();
        }
    }
}
