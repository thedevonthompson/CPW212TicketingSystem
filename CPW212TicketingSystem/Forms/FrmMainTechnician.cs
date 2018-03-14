using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPW212TicketingSystem.Forms
{
    public partial class FrmMainTechnician : Form
    {
        public FrmMainTechnician()
        {
            InitializeComponent();
        }

        private void FrmMainTechnician_Load(object sender, EventArgs e)
        {
            LoadPriorities();
            LoadTickets();
        }

        protected virtual void LoadTickets()
        {
            LstTickets.DataSource = null;
            LstTickets.DataSource = TicketDB.GetAllTickets();
        }

        private void LoadPriorities()
        {
            CboPriorities.DataSource = null;
            CboPriorities.DataSource = PriorityDB.GetAllPriorities();
        }

        private void BtnCreateTicket_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                string title = TxtTitle.Text;
                DateTime? due = (DtpDueDate.Checked) ? (DateTime?)DtpDueDate.Value : null;
                Priority priority = (Priority)CboPriorities.SelectedItem;

                Ticket newTicket = new Ticket(title, due, priority);

                TicketDB.Create(newTicket);
            }

            LoadTickets();
        }

        private bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                MessageBox.Show("Ticket must have a title!");
                return false;
            }

            if (CboPriorities.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a priority from the drop down!");
                return false;
            }

            return true;
        }

        private void LstTickets_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (LstTickets.SelectedIndex >= 0)
            {
                Ticket t = (Ticket)LstTickets.SelectedItem;
                FrmTicket ticketDetails = new FrmTicket(t);
                ticketDetails.ShowDialog();
            }

            //refreshes the form when the ticketDetails form is closed
            //displaying any changes made to the tickets inside that form
            //such as the updated ticket or deletion
            LoadTickets();
        }

        private void BtnEditUsers_Click(object sender, EventArgs e)
        {
            // Open up the User Crud Form.
        }

        private void BtnEditRoles_Click(object sender, EventArgs e)
        {
            // Open up the Role Crud Form.
        }

        private void BtnEditPriorities_Click(object sender, EventArgs e)
        {
            ///
        }

        private void LstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
