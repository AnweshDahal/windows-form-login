using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormLogin
{
    public partial class Form1 : Form
    {
        // The controller class will handel user registeration and 
        // user login
        Controller controller = new Controller();

        public Form1()
        {
            InitializeComponent();
        }

        private void RegisterBTN_Click(object sender, EventArgs e)
        {
            // Creating a new User Object
            User newUser = new User();

            // Assigning values to the properties
            newUser.Username = UsernameTB.Text;
            newUser.Password = PasswordTB.Text;
            newUser.DateOfBirth = DateOfBirthBTP.Value;
            newUser.Address = AddressTB.Text;
            newUser.ContactNumber = PhoneNumberTB.Text;

            // Registering new user
            controller.RegisterUser(newUser);
        }

        private void LoginBTN_Click(object sender, EventArgs e)
        {

        }
    }
}
