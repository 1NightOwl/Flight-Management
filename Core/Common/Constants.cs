using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Common
{
    public class Constants
    {
        public const string RoleAdmin = "Admin";
        public const string RoleUser = "User";

        public const string StatusActive = "Aktiv";
        public const string StatusMaintenance = "Jashtë Shërbimi";

        public const int MinSeatCount = 20;
        public const int MaxSeatCount = 400;

        public const int MinRange = 1000;
        public const int MaxRange = 15000;
    }
}
