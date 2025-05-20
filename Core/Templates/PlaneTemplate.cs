using FlightManagement.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.PlaneModels
{
    public class PlaneTemplate
    {
        private int _seatCount;
        private int _rangeKm;
        
        public bool HasClasses { get; set; }
        public double BuisnessFactor { get; set; } = 1.5;
        public double FirstClassFactor { get; set; } = 2.0;
        public string Model { get; set; }
        public string Id { get; set; }
        public string Registration { get; set; }
        public string Status { get; set; } = Constants.StatusActive;

        public int SeatCount
        {
            get { return _seatCount; }
            set
            {
                if (value < Constants.MinSeatCount || value > Constants.MaxSeatCount)
                {
                    throw new ArgumentException("Seat count cannot be negative.");
                }
                _seatCount = value;
            }
        }
        public int RangeKm
        {
            get { return _rangeKm; }
            set
            {
                if (value < Constants.MinRange || value > Constants.MaxRange)
                {
                    throw new ArgumentException("Range cannot be negative.");    
                }
                _rangeKm = value;
            }
        }
    }
}
