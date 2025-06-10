using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

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
            if (!email.Contains("@") || !email.Contains("."))
                throw new FlightManagementException("Ju lutem shkruani një email të vlefshëm.");

            var all = UsersRepository.GetAll();
            if (all.Any(x => x.Username == username || x.Email == email))
                throw new FlightManagementException("Ky emër përdoruesi ose email është tashmë i regjistruar.");

            UsersRepository.Add(new User
            {
                Username = username,
                Email = email,
                Password = password,
                CreatedDate = DateTime.Now
            });
        }

        public void UpdatePassword(int id, User u)
        {
            var dbUser = UsersRepository.GetById(id)
                         ?? throw new FlightManagementException("Nuk u identifikua personi!");

            dbUser.Password = u.Password;
            dbUser.UpdatedDate = DateTime.Now;
            UsersRepository.Update(dbUser);
        }

        public List<User> GetAll()
        {
            return UsersRepository
                   .GetAll()
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
            var user = UsersRepository.GetById(id);
            if (user == null) return null;
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
            var u = UsersRepository.GetById(userId)
                    ?? throw new FlightManagementException("Përdoruesi nuk u gjet.");
            if (u.Role == newRole) return;

            if (u.Role == "Admin" && newRole != "Admin")
            {
                var admins = UsersRepository.GetAll().Count(x => x.Role == "Admin");
                if (admins <= 1)
                    throw new FlightManagementException("Duhet të ketë të paktën një admin.");
            }

            u.Role = newRole;
            u.UpdatedDate = DateTime.Now;
            UsersRepository.Update(u);
        }

        public void Delete(int id)
        {
            var dbUser = UsersRepository.GetById(id)
                         ?? throw new FlightManagementException("Nuk u identifikuan te dhenat e perdoruesit!");
            if (dbUser.Role == "Admin" && UsersRepository.GetAll().Count(x => x.Role == "Admin") <= 1)
                throw new FlightManagementException("Duhet të ketë të paktën një admin.");

            UsersRepository.Remove(id);
        }

        public User? Login(string usernameOrEmail, string password)
        {
            if (string.IsNullOrWhiteSpace(usernameOrEmail) || string.IsNullOrWhiteSpace(password))
                throw new FlightManagementException("Ju lutem shkruani emrin e përdoruesit ose emailin dhe fjalëkalimin.");

            var dbUser = UsersRepository
                         .GetAll()
                         .FirstOrDefault(x =>
                             (x.Username == usernameOrEmail || x.Email == usernameOrEmail)
                              && x.Password == password);

            if (dbUser == null
             || (usernameOrEmail != dbUser.Username && usernameOrEmail != dbUser.Email))
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