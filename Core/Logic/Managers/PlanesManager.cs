using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using FlightManagement.Core.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlightManagement.Core.Logic.Managers
{
    public class PlanesManager
    {
        public void AddPlane(Planes p)
        {
            if (string.IsNullOrWhiteSpace(p.Model))
                throw new FlightManagementException("Duhet të zgjedhësh tipin e avionit.");
            if (p.PlaneId <= 0)
                throw new FlightManagementException("ID e Avionit duhet të jetë numër pozitiv.");
            if (string.IsNullOrWhiteSpace(p.Registration))
                throw new FlightManagementException("Regjistrimi i avionit nuk mund të jetë bosh.");
            if (p.SeatCount <= 0)
                throw new FlightManagementException("Numri i vendeve duhet të jetë më i madh se zero.");
            if (p.RangeKm <= 0)
                throw new FlightManagementException("Rrezja duhet të jetë më e madhe se zero.");
            if (string.IsNullOrWhiteSpace(p.Status))
                throw new FlightManagementException("Duhet të vendosni një status për avionin.");

            var exists = PlanesRepository.GetAll()
                           .Any(x => x.PlaneId == p.PlaneId || x.Registration == p.Registration);
            if (exists)
                throw new FlightManagementException("Ky avion ekziston tashmë (ID ose Regjistrim i përdorur).");

            p.CreatedDate = DateTime.Now;
            PlanesRepository.Add(p);
        }

        public void Update(int id, Planes p)
        {
            var dbPlane = PlanesRepository.GetById(id)
                          ?? throw new FlightManagementException("Avioni nuk u gjet!");

            dbPlane.PlaneId = p.PlaneId;
            dbPlane.Model = p.Model;
            dbPlane.Registration = p.Registration;
            dbPlane.SeatCount = p.SeatCount;
            dbPlane.RangeKm = p.RangeKm;
            dbPlane.Status = p.Status;
            dbPlane.HasClasses = p.HasClasses;
            dbPlane.BuisnessFactor = p.BuisnessFactor;
            dbPlane.FirstClassFactor = p.FirstClassFactor;
            dbPlane.UpdatedDate = DateTime.Now;

            PlanesRepository.Update(dbPlane);
        }

        public List<Planes> GetAll() =>
            PlanesRepository.GetAll();

        public Planes? GetById(int id) =>
            PlanesRepository.GetById(id);

        public void Delete(int id) =>
            PlanesRepository.Remove(id);
    }
}