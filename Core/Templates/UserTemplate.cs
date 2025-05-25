using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightManagement.Core.Templates
{
    public class UserTemplate
    {
        private string _email;
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email
        {
            get { return _email.ToString(); }
            set
            {
                if (string.IsNullOrEmpty(value) || !value.Contains("@"))
                {
                    throw new ArgumentException("Email must be a valid email address.");
                }
                _email = value;
            }
        }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
