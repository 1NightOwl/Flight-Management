using Microsoft.EntityFrameworkCore;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Common;

namespace FlightManagement.Core.Data.Repositories
{
    public static class UsersRepository
    {
        private static AppDbContext _db;
        public static void Init(AppDbContext dbContext)
        {
            _db = dbContext;
        }

        public static void Add(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public static User? GetById(int id) =>
            _db.Users.Find(id);

        public static List<User> GetAll() =>
            _db.Users.ToList();

        public static void Update(User user)
        {
            _db.Users.Update(user);
            _db.SaveChanges();
        }

        public static void Remove(int id)
        {
            var user = GetById(id)
                ?? throw new FlightManagementException("Përdoruesi nuk u gjet!");
            _db.Users.Remove(user);
            _db.SaveChanges();
        }
    }
}
