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
    public partial class FrmPriorities : Form
    {
        public FrmPriorities()
        {
            InitializeComponent();
        }

        private void FrmPriorities_Load(object sender, EventArgs e)
        {
            LoadPriorities();
            LoadTickets();
        }

        protected virtual void LoadTickets()
        {
            lstTickets.DataSource = null;
            lstTickets.DataSource = TicketDB.GetAllTickets();
        }

        private void LoadPriorities()
        {
            CboPriorities.DataSource = null;
            CboPriorities.DataSource = PriorityDB.GetAllPriorities();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if(lstTickets.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                Ticket p = null;
                for (int i = 0; i <= lstTickets.CheckedItems.Count - 1; i++)
                {
                    p = (Ticket)lstTickets.CheckedItems[i]; //lstTickets.CheckedItems[i];

                    p.Priority = (Priority)CboPriorities.SelectedItem;
                    TicketDB.AddOrUpdate(p);
                }
                
                MessageBox.Show(p.ToString());
            }
            else
            {
                MessageBox.Show("You must choose at least one ticket to change!");
            }
            LoadTickets();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
