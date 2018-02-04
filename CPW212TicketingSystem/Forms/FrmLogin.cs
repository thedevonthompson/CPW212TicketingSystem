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
using CPW212TicketingSystem.Forms;

namespace CPW212TicketingSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // this will check user authentication
            User userToLogin = UserDB.FindUser(txtUserName.Text, txtPassWord.Text);

            if (userToLogin != null)
            {
                // this will hide the login form and let us now just browse the main form. 
                // probably not the best way to do this I will look into better ways to handle this.
                // as the login form is pretty much useless after a user is authenticated.


                // after further testing, if we exit out of the main form the program is still running
                // as login is still running in the back ground. 
                // TODO: Either create a method to be called once main form is exited to exit login ( which would be the messier way imo)
                // TODO: Second option would be to research a way to do it more cleanly maybe have Application.Run point somewhere else??
                this.Hide();
                FrmMain mainForm = new FrmMain();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("User Authentication Failed");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // TODO: create a query to input a new user into the database.
            // everyone will have to default at the lowest level. and then at a certain level
            // another user at a higher tier level can then promote that person up the ranks.
            FrmRegistration registerForm = new FrmRegistration();
            registerForm.Show();
        }
    }
}
