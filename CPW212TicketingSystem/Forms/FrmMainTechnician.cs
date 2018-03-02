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
    public partial class FrmMainTechnician : FrmMain
    {
        public FrmMainTechnician()
        {
            InitializeComponent();
        }

        protected override void LoadTickets()
        {
            LstTickets.DataSource = null;
            LstTickets.DataSource = TicketDB.GetAllTickets();
        }
    }
}
