using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLogin
{
    public class User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Address { get; set; }
        public String ContactNumber { get; set; }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.DateOfBirth.Year;
            }
        }
    }
}
