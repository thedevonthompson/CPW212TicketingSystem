using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPW212TicketingSystem.DatabaseClasses;

namespace CPW212TicketingSystem.Forms
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User userTobeRegistered = new User()
            {
                Username =  txtUserName.Text,
                Password =  txtPassword.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text
                
            };
            UserDB.RegisterUser(userTobeRegistered);
        }
    }
}
