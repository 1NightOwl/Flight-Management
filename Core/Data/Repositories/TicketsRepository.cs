using Microsoft.EntityFrameworkCore;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Common;

namespace FlightManagement.Core.Data.Repositories
{
    public static class TicketsRepository
    {
        private static AppDbContext _db;
        public static void Init(AppDbContext dbContext) => _db = dbContext;

        public static void Add(Bileta ticket)
        {
            _db.Biletat.Add(ticket);
            _db.SaveChanges();
        }

        public static Bileta? GetById(int id) =>
            _db.Biletat.Find(id);

        public static List<Bileta> GetAll() =>
            _db.Biletat
               .Include(b => b.Route)
               .Include(b => b.User)
               .ToList();

        public static void Update(Bileta ticket)
        {
            _db.Biletat.Update(ticket);
            _db.SaveChanges();
        }

        public static void Remove(int id)
        {
            var ticket = GetById(id)
                ?? throw new FlightManagementException("Bileta nuk u gjet.");
            _db.Biletat.Remove(ticket);
            _db.SaveChanges();
        }
    }
}
