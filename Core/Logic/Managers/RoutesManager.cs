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

        public List<Route> GetAllRoutes()
        {
            return Program.DbContext
                          .Routes
                          .Select(r => new Route
                          {
                              Id = r.Id,
                              PlaneId = r.PlaneId,
                              Departure = r.Departure,
                              Arrival = r.Arrival,
                              DepartureDay = r.DepartureDay,
                              StartTime = r.StartTime,
                              EndTime = r.EndTime,
                              Status = r.Status,
                              Price = r.Price,
                              CreatedDate = r.CreatedDate,
                              UpdatedDate = r.UpdatedDate
                          }).ToList();
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
