using Microsoft.EntityFrameworkCore;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Common;

namespace FlightManagement.Core.Data.Repositories
{
    public static class RoutesRepository
    {
        private static AppDbContext _db;
        public static void Init(AppDbContext dbContext) => _db = dbContext;

        public static void Add(Route route)
        {
            _db.Routes.Add(route);
            _db.SaveChanges();
        }

        public static Route? GetById(int id) =>
            _db.Routes.Find(id);

        public static List<Route> GetAll() =>
            _db.Routes
               .Include(r => r.Plane)
               .ToList();

        public static void Update(Route route)
        {
            _db.Routes.Update(route);
            _db.SaveChanges();
        }

        public static void Remove(int id)
        {
            var route = GetById(id)
                ?? throw new FlightManagementException("Rruga nuk u gjet!");
            _db.Routes.Remove(route);
            _db.SaveChanges();
        }
    }
}
