using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Common
{
    public class FlightManagementException : Exception
    {
        public FlightManagementException(string message) : base(message)
        {

        }
    }
}
