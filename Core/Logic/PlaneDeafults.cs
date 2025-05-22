using FlightManagement.Core.PlaneModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Logic
{
    public class PlaneDeafults
    {
        public static Dictionary<string, PlaneTemplate> planeTemplates = new ()
        {
            { "Boeing 737-800", 
                new PlaneTemplate{ 
                    Model = "Boeing 737-800", 
                    SeatCount = 189,  
                    RangeKm = 5764, 
                    Status = "Aktiv",
                    HasClasses = true,
                    BuisnessFactor = 1.3,
                    FirstClassFactor = 2.7
                } },

            { "Airbus A320", 
                new PlaneTemplate{ 
                    Model = "Airbus A320", 
                    SeatCount = 180, 
                    RangeKm = 6150, 
                    Status = "Aktiv",
                    HasClasses = false,
                    BuisnessFactor = 0.0,
                    FirstClassFactor = 0.0
                } },

            { "Embraer E190", 
                new PlaneTemplate{ 
                    Model = "Embraer E190", 
                    SeatCount = 100, 
                    RangeKm = 4500, 
                    Status = "Aktiv",
                    HasClasses = true,
                    BuisnessFactor = 1.7,
                    FirstClassFactor = 0.0
                } },
        };

    }
}
