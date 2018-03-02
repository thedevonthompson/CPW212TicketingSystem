using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW212TicketingSystem
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // TODO: Get a list of roles and assign one to the new user.
            User user = new User(txtUsername.Text, txtPassword.Text, txtFirstName.Text, txtLastName.Text, null);

            if (UserDB.Add(user))
            {
                MessageBox.Show("Registration succesful");
            }
            else
            {
                MessageBox.Show("Error: Registration not succesful");
            }
        }
    }
}
