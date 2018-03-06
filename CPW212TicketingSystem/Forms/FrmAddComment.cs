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
            Comment newComment = new Comment
            {
                User = State.CurrUser,
                Created = DateTime.Now,
                Ticket = CurrTicket,
                Text = txtBxNewComent.Text
            };
            CommentDB.addComment(newComment);
            MessageBox.Show("success");
        }
    }
}
