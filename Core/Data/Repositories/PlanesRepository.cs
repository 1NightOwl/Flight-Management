using Microsoft.EntityFrameworkCore;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Common;

namespace FlightManagement.Core.Data.Repositories
{
    public static class PlanesRepository
    {
        private static AppDbContext _db;
        public static void Init(AppDbContext dbContext) => _db = dbContext;

        public static void Add(Planes plane)
        {
            _db.Plane.Add(plane);
            _db.SaveChanges();
        }

        public static Planes? GetById(int id) =>
            _db.Plane.Find(id);

        public static List<Planes> GetAll() =>
            _db.Plane.ToList();

        public static void Update(Planes plane)
        {
            _db.Plane.Update(plane);
            _db.SaveChanges();
        }

        public static void Remove(int id)
        {
            var plane = GetById(id)
                ?? throw new FlightManagementException("Avioni nuk u gjet!");
            _db.Plane.Remove(plane);
            _db.SaveChanges();
        }
    }
}
