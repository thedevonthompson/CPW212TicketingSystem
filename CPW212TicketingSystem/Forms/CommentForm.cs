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
    public partial class CommentForm : Form
    {
        public Ticket CurrTicket { get; set; }
        
        public CommentForm(Ticket passedTicket) //
        {
            InitializeComponent();
            CurrTicket = passedTicket;
        }
        // temporary made tickets just for testing purposes

        private static Comment currComment;
        private void CommentForm_Load(object sender, EventArgs e)
        {
            PopulateComments();
        }

        private void lstBxComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            currComment = (Comment) lstBxComments.SelectedItem;
            txtBxComment.Text = currComment.Text;
        }

        private void btnEditComment_Click(object sender, EventArgs e)
        {
            Comment commentToEdit = (Comment)lstBxComments.SelectedItem;
            commentToEdit.Text = txtBxComment.Text;
            CommentDB.UpdateComment(commentToEdit);
            MessageBox.Show("Success!");
        }

        public void PopulateComments()
        {
            lstBxComments.DataSource = CommentDB.GetCommentsByTickID(CurrTicket);
        }

        private void btnNewComment_Click(object sender, EventArgs e)
        {

            FrmAddComment addComment = new FrmAddComment(CurrTicket);
            addComment.ShowDialog();
            PopulateComments();
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            CommentDB.DeleteComment(currComment);
        }
        //remember to change application run and the event handler that is not needed.
        //throwing an exception when trying to create a ticket
        //seed database
    }
}
