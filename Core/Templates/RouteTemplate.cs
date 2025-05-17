using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Templates
{
    public class RouteTemplate
    {
        private int _price;
        public string Departure { get; set; }
        public string Arrival { get; set; }
        public string PlaneType { get; set; }
        public string PlaneId { get; set; }
        public int StartTime { get; set; }
        public int EndTime { get; set; }
        public string DepartureDay { get; set; }

        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                _price = value;
            }
        }
    }
}
