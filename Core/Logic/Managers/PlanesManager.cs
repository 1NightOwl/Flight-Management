﻿using FlightManagement.Core.Common;
using FlightManagement.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Logic.Managers
{
    public class PlanesManager
    {
        public void AddPlane(Planes p)
        {
            Program.DbContext.Plane.Add(new Planes
            {
                PlaneId = p.PlaneId,
                Model = p.Model,
                Registration = p.Registration,
                SeatCount = p.SeatCount,
                RangeKm = p.RangeKm,
                Status = p.Status,
                HasClasses = p.HasClasses,
                BuisnessFactor = p.BuisnessFactor,
                FirstClassFactor = p.FirstClassFactor,
                CreatedDate = DateTime.Now
            });

            Program.DbContext.SaveChanges();
        }

        public void Update(int id, Planes p)
        {
            var dbPlane = Program.DbContext.Plane.Find(id) ?? throw new FlightManagementException("Avioni nuk u gjet!");

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

            Program.DbContext.SaveChanges();
        }

        public List<Planes> GetAll()
        {
            return Program.DbContext
                          .Plane
                          .Select(p => new Planes
                          {
                              Id = p.Id,
                              PlaneId = p.PlaneId,
                              Model = p.Model,
                              Registration = p.Registration,
                              SeatCount = p.SeatCount,
                              RangeKm = p.RangeKm,
                              Status = p.Status,
                              HasClasses = p.HasClasses,
                              BuisnessFactor = p.BuisnessFactor,
                              FirstClassFactor = p.FirstClassFactor,
                              CreatedDate = p.CreatedDate,
                              UpdatedDate = p.UpdatedDate
                          }).ToList();
        }

        public Planes? GetById(int id)
        {
            var plane = Program.DbContext.Plane.Find(id);
            if (plane == null) return null;
            return plane;
        }

        public void Delete(int id)
        {
            var dbPlane = Program.DbContext.Plane.Find(id) ?? throw new FlightManagementException("Avioni nuk u gjet!");
            Program.DbContext.Plane.Remove(dbPlane);
            Program.DbContext.SaveChanges();
        }

    }
}
