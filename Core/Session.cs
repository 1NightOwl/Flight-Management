using FlightManagement.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core
{
    public static class Session
    {
        public static User CurrentUser { get; private set; }
        public static void StartSession(User user)
        {
            CurrentUser = user;
        }
        public static void StopSession(User user) {
            if (CurrentUser == user)
            {
                CurrentUser = null!;
            }
        }
    }
}
