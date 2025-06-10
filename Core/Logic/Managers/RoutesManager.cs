using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var allRoutes = RoutesRepository.GetAll()
                .Where(r =>
                    r.PlaneId == planeId &&
                    r.DepartureDay == departureDay &&
                    r.Status == "Aktiv");

            if (ignoreRouteId.HasValue)
                allRoutes = allRoutes.Where(r => r.Id != ignoreRouteId.Value);

            return allRoutes.Any(r =>
                r.StartTime < endTime &&
                startTime < r.EndTime);
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

            if (HasConflict(route.PlaneId, route.DepartureDay, route.StartTime, route.EndTime))
                throw new FlightManagementException("Ky avion tashmë ka një fluturim në këtë ditë dhe në këto orë.");

            route.Status = "Aktiv";
            route.CreatedDate = DateTime.Now;
            RoutesRepository.Add(route);
        }

        public void UpdateRoute(int id, Route updated)
        {
            var dbRoute = RoutesRepository.GetById(id)
                          ?? throw new FlightManagementException("Rruga nuk u gjet.");

            if (HasConflict(updated.PlaneId, updated.DepartureDay, updated.StartTime, updated.EndTime, id))
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

            RoutesRepository.Update(dbRoute);
        }

        public IEnumerable<Route> FindDirect(string from, string to, string departureDay)
        {
            return RoutesRepository
                   .GetAll()
                   .Where(r =>
                       r.Departure == from &&
                       r.Arrival == to &&
                       r.DepartureDay == departureDay &&
                       r.Status == "Aktiv");
        }

        public IEnumerable<(Route FirstLeg, Route SecondLeg)> FindConnections(
            string from, string to, string departureDay,
            TimeSpan minLayover, TimeSpan maxLayover)
        {
            var all = RoutesRepository.GetAll()
                        .Where(r => r.DepartureDay == departureDay && r.Status == "Aktiv")
                        .ToList();

            var firstLegs = all.Where(r => r.Departure == from);
            var secondLegs = all.Where(r => r.Arrival == to);

            return (from leg1 in firstLegs
                    from leg2 in secondLegs
                    where leg1.Arrival == leg2.Departure
                       && leg2.StartTime > leg1.EndTime
                       && (leg2.StartTime - leg1.EndTime) >= minLayover
                       && (leg2.StartTime - leg1.EndTime) <= maxLayover
                    select (leg1, leg2))
                   .ToList();
        }

        public List<Route> GetAllRoutes() =>
            RoutesRepository.GetAll();

        public void DeleteRoute(int id) =>
            RoutesRepository.Remove(id);
    }
}