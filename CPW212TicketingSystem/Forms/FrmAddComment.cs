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
    public partial class FrmAddComment : Form
    {
        public Ticket CurrTicket { get; set; }
        public FrmAddComment(Ticket passedTicket)
        {
            InitializeComponent();
            this.CurrTicket = passedTicket;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            CommentDB.addComment(CurrTicket.TicketID ,State.CurrUser.UserID, txtBxNewComent.Text);
            MessageBox.Show("success");
            this.Close();
        }
    }
}
