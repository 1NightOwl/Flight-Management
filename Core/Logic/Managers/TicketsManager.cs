using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagement.Core.Logic.Managers
{
    public class TicketsManager
    {
        public void Add(Bileta bilet)
        {
            if (bilet.UserId == 0)
                bilet.UserId = Session.CurrentUser.Id;

            bilet.DataRezervimit = DateTime.Now;
            if (string.IsNullOrEmpty(bilet.Statusi))
                bilet.Statusi = "Ne Pritje";

            TicketsRepository.Add(bilet);
        }

        public IEnumerable<Bileta> GetAll()
        {
            return TicketsRepository.GetAll();
        }

        public void UpdateStatus(int id, string newStatus)
        {
            var bilet = TicketsRepository.GetById(id)
                        ?? throw new FlightManagementException("Bileta nuk u gjet.");
            bilet.Statusi = newStatus;
            TicketsRepository.Update(bilet);
        }

        public List<Bileta> GetByUserId(int userId)
        {
            return TicketsRepository
                   .GetAll()
                   .Where(b => b.UserId == userId)
                   .OrderByDescending(b => b.DataRezervimit)
                   .ToList();
        }

        public void Delete(int id)
        {
            TicketsRepository.Remove(id);
        }
    }
}