using FlightManagement.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Templates
{
    public sealed class TicketInfo : EventArgs
    {
        public IReadOnlyList<Route> Legs { get; init; } = Array.Empty<Route>();
        public DateTime FlightDate { get; init; }
        public string SeatClass { get; init; } = "Economy";
        public int Quantity { get; init; } = 1;
        public double Price { get; init; }
    }
}
