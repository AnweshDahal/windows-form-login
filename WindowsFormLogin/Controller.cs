using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormLogin
{
    public class Controller
    {
        public User user = new User();

        public void RegisterUser (User user)
        {
            this.user.Username = user.Username;
            this.user.Password = user.Password;
            this.user.DateOfBirth = user.DateOfBirth;
            this.user.Address = user.Address;
            this.user.ContactNumber = user.ContactNumber;
        }

        public String LoginUser (String username, String password)
        {
            if (username != this.user.Username || password != this.user.Password)
            {
                return "This user does not exist";
            } 
            return DisplayUserPrintable();
        }

        public String DisplayUserPrintable()
        {
            String printable = String.Format("Username: {0}\n" +
                                            "Password: {1}\n" + 
                                            "Date of Birth: {2}\n" +
                                            "Address: {3}\n" + 
                                            "Contact Number: {4}\n", 
                                            this.user.Username, this.user.Password, this.user.DateOfBirth, this.user.ContactNumber, this.user.Address);
            return printable;
        }

    }
}
