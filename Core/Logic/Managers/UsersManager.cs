using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Logic.Managers
{
    public class UsersManager
    {
        public void RegisterUser(string username, string email, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new FlightManagementException("Ju lutem shkruani një emër përdoruesi.");

            if (string.IsNullOrWhiteSpace(email))
                throw new FlightManagementException("Ju lutem shkruani një email.");

            if (string.IsNullOrWhiteSpace(password))
                throw new FlightManagementException("Ju lutem shkruani një fjalëkalim.");

            if(!email.Contains("@") || !email.Contains("."))
                throw new FlightManagementException("Ju lutem shkruani një email të vlefshëm.");

            if(Program.DbContext.Users.Any(x => x.Username == username || x.Email == email))
                throw new FlightManagementException("Ky emër përdoruesi ose email është tashmë i regjistruar.");

            Program.DbContext
                   .Users
                   .Add(new Data.Entities.User
                   {
                       Username = username,
                       Email = email,
                       Password = password,
                       CreatedDate = DateTime.Now
                   });
            Program.DbContext.SaveChanges();
        }

        public void UpdatePassword(int id, User u)
        {
            var dbUser = Program.DbContext.Users.Find(id) ?? throw new FlightManagementException("Nuk u identifikua personi!");
                
            dbUser.Password = u.Password;
            dbUser.UpdatedDate = DateTime.Now;

            Program.DbContext.SaveChanges();
        }

        public List<User> GetAll()
        {
            return Program.DbContext
                          .Users
                          .Select(dbUser => new User
                          {
                                Id = dbUser.Id,
                                Username = dbUser.Username,
                                Email = dbUser.Email,
                                Role = dbUser.Role ?? "User",
                                CreatedDate = dbUser.CreatedDate,
                                UpdatedDate = dbUser.UpdatedDate
                          })
                          .ToList();
        }
        public User? GetById(int id)
        {
            var user = Program.DbContext.Users.Find(id);
            if (user == null)
                return null;
            return new User
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                Role = user.Role,
                CreatedDate = user.CreatedDate,
                UpdatedDate = user.UpdatedDate
            };
        }
        public void ChangeUserRole(int userId, string newRole)
        {
            var u = Program.DbContext.Users.Find(userId);
            if (u == null) throw new FlightManagementException("Përdoruesi nuk u gjet.");
            if (u.Role == newRole) return;

            if (u.Role == "Admin" && newRole != "Admin")
            {
                int admins = Program.DbContext.Users.Count(x => x.Role == "Admin");
                if (admins <= 1)
                    throw new FlightManagementException("Duhet të ketë të paktën një admin.");
            }

            u.Role = newRole;
            u.UpdatedDate = DateTime.Now;
            Program.DbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var dbUser = Program.DbContext.Users.Find(id) ?? throw new FlightManagementException("Nuk u identifikuan te dhenat e perdoruesit!");

            if (dbUser.Role == "Admin" && Program.DbContext.Users.Count(x => x.Role == "Admin") <= 1)
                throw new FlightManagementException("Duhet të ketë të paktën një admin.");

            Program.DbContext.Users.Remove(dbUser);
            Program.DbContext.SaveChanges();
        }

        public User? Login(string usernameOrEmail, string password)
        {
            if(string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
                throw new FlightManagementException("Ju lutem shkruani emrin e përdoruesit ose emailin dhe fjalëkalimin.");

            var dbUser = Program.DbContext
                                .Users
                                .FirstOrDefault(x => (x.Username == usernameOrEmail || x.Email == usernameOrEmail) && x.Password == password);
            
            if(usernameOrEmail != dbUser?.Username && usernameOrEmail != dbUser?.Email)
                throw new FlightManagementException("Emri i përdoruesit ose emaili dhe fjalëkalimi nuk përputhen.");

            return new User
            {
                Id = dbUser.Id,
                Username = dbUser.Username,
                Email = dbUser.Email,
                Role = dbUser.Role,
                CreatedDate = dbUser.CreatedDate,
                UpdatedDate = dbUser.UpdatedDate
            };
        }

    }
}
