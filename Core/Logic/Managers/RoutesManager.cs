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
        private bool HasConflict(
            int planeId,
            string departureDay,
            TimeSpan startTime,
            TimeSpan endTime,
            int? ignoreRouteId = null)
        {
            var query = Program.DbContext.Routes
                .Where(r =>
                    r.PlaneId == planeId &&
                    r.DepartureDay == departureDay &&
                    r.Status == "Aktiv"
                );
            if (ignoreRouteId.HasValue)
            {
                query = query.Where(r => r.Id != ignoreRouteId.Value);
            }
            bool conflictExists = query.Any(r =>
                r.StartTime < endTime &&
                startTime < r.EndTime
            );

            return conflictExists;
        }
        public void AddRoute(Route route)
        {
            if (route.PlaneId <= 0)
                throw new FlightManagementException("Duhet të zgjidhni një avion valid.");
            if (string.IsNullOrWhiteSpace(route.Departure) || string.IsNullOrWhiteSpace(route.Arrival))
                throw new FlightManagementException("Nisja dhe mbërritja nuk mund të jenë bosh.");
            if (route.Departure == route.Arrival)
                throw new FlightManagementException("Aeroporti i nisjes dhe ai i mbërritjes nuk mund të jenë të njëjtë.");
            if (string.IsNullOrWhiteSpace(route.DepartureDay))
                throw new FlightManagementException("Duhet të zgjidhni një ditë përfluturimi.");
            if (route.EndTime <= route.StartTime)
                throw new FlightManagementException("Ora e mbërritjes duhet të jetë më e madhe se ora e nisjes.");
            if (route.Price <= 0)
                throw new FlightManagementException("Çmimi duhet të jetë numër pozitiv.");
            if (string.IsNullOrWhiteSpace(route.Status))
                throw new FlightManagementException("Duhet të zgjidhni statusin e rrugës.");

            bool conflict = HasConflict(
                planeId: route.PlaneId,
                departureDay: route.DepartureDay,
                startTime: route.StartTime,
                endTime: route.EndTime,
                ignoreRouteId: null
            );

            if (conflict)
                throw new FlightManagementException("Ky avion tashmë ka një fluturim në këtë ditë dhe në këto orë.");

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

            if (updated.PlaneId <= 0)
                throw new FlightManagementException("Duhet të zgjidhni një avion valid.");
            if (string.IsNullOrWhiteSpace(updated.Departure) || string.IsNullOrWhiteSpace(updated.Arrival))
                throw new FlightManagementException("Nisja dhe mbërritja nuk mund të jenë bosh.");
            if (updated.Departure == updated.Arrival)
                throw new FlightManagementException("Aeroporti i nisjes dhe ai i mbërritjes nuk mund të jenë të njëjtë.");
            if (string.IsNullOrWhiteSpace(updated.DepartureDay))
                throw new FlightManagementException("Duhet të zgjidhni një ditë përfluturimi.");
            if (updated.EndTime <= updated.StartTime)
                throw new FlightManagementException("Ora e mbërritjes duhet të jetë më e madhe se ora e nisjes.");
            if (updated.Price <= 0)
                throw new FlightManagementException("Çmimi duhet të jetë numër pozitiv.");
            if (string.IsNullOrWhiteSpace(updated.Status))
                throw new FlightManagementException("Duhet të zgjidhni statusin e rrugës.");

            bool conflict = HasConflict(
                planeId: updated.PlaneId,
                departureDay: updated.DepartureDay,
                startTime: updated.StartTime,
                endTime: updated.EndTime,
                ignoreRouteId: id
            );

            if (conflict)
                throw new FlightManagementException("Ky avion tashmë ka një fluturim tjetër në këtë ditë dhe në këto orë.");

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

        public void DeleteRoute(int id)
        {
            var route = Program.DbContext.Routes.Find(id) ?? throw new FlightManagementException("Rruga nuk u gjet!");
            Program.DbContext.Routes.Remove(route);
            Program.DbContext.SaveChanges();
        }
    }
}
