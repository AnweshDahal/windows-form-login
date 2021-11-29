using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WindowsFormLogin
{
    public class Controller
    {
        XmlSerializer xmlSerializer;
        List<User> UserList;

        public Controller()
        {
            UserList = new List<User>();
            xmlSerializer = new XmlSerializer(typeof(List<User>));
        }

        public void RegisterUser (User userVal)
        {
            User user = new User();
            user.Username = userVal.Username;
            user.Password = userVal.Password;
            user.DateOfBirth = userVal.DateOfBirth;
            user.Address = userVal.Address;
            user.ContactNumber = userVal.ContactNumber;

            // Saving the user to a XML file
            System.IO.FileStream fileStream = new FileStream(Environment.CurrentDirectory + "/customers.xml", System.IO.FileMode.Create, System.IO.FileAccess.Write);
            UserList.Add(user);

            xmlSerializer.Serialize(fileStream, UserList);
            fileStream.Close();
        }

        public bool LoginUser (String username, String password)
        {

            FileStream fileStream = new FileStream(Environment.CurrentDirectory + "/customers.xml", FileMode.Open, FileAccess.Read);

            UserList = (List<User>)xmlSerializer.Deserialize(fileStream);


            foreach (var user in UserList)
            {
                if (user.Username == username && user.Password == password)
                {
                    fileStream.Close();
                    return true;
                }
            }

            fileStream.Close();

            return false;
        }

        public String DisplayUserPrintable()
        {
           /**
            String printable = String.Format("Username: {0}\n" +
                                            "Password: {1}\n" + 
                                            "Date of Birth: {2}\n" +
                                            "Address: {3}\n" + 
                                            "Contact Number: {4}\n", 
                                            this.user.Username, this.user.Password, this.user.DateOfBirth, this.user.ContactNumber, this.user.Address);
            **/
            return "";
        }

    }
}
