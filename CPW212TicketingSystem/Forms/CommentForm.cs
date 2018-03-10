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


        private void CommentForm_Load(object sender, EventArgs e)
        {
            PopulateComments();
        }

        private void lstBxComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBxComment.Text = CurrComment().Text;
        }


        // Allows users to update their ticket comments, but denies users who try to edit technician comments. NOTE: technicians may edit users tickets
        private void btnEditComment_Click(object sender, EventArgs e)
        {
            Comment commentToEdit = CurrComment();
//            if (State.CurrUser.Username != CurrComment().User.Username && !State.CurrUser.Role.IsTechnician)
//            {
//                MessageBox.Show("You may only edit your own comments");
//            }
//            else
//            {
//               
//                if (commentToEdit != null && !(string.IsNullOrWhiteSpace(lstBxComments.Text)))
//                {
//                    commentToEdit.Text = txtBxComment.Text;
//                    CommentDB.UpdateComment(commentToEdit);
//                    MessageBox.Show("Success!");
//                    PopulateComments();
//                }
//                else
//                {
//                    MessageBox.Show(
//                        "Please select an comment to edit, if there are no comments to select from then use the new button to create one.");
//                }
//            }

            if (CurrComment() != null && !(string.IsNullOrWhiteSpace(txtBxComment.Text)))
            {
                
                if (State.CurrUser.Username != CurrComment().User.Username && !State.CurrUser.Role.IsTechnician)
                {
                    MessageBox.Show("You may only edit your own comments");
                }
                else
                {
                    commentToEdit.Text = txtBxComment.Text;
                    CommentDB.UpdateComment(commentToEdit);
                    MessageBox.Show("Success!");
                    PopulateComments();
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select an comment to edit, if there are no comments to select from then use the new button to create one.");
                PopulateComments();
            }


        }


        public void PopulateComments()
        {
            if (State.CurrUser.Role.IsTechnician)
                lstBxComments.DataSource = CommentDB.GetAllCommentsByTickID(CurrTicket);
            else
                lstBxComments.DataSource = CommentDB.GetAllPublicCommentsByTickID(CurrTicket);

        }


        private void btnNewComment_Click(object sender, EventArgs e)
        {

            FrmAddComment addComment = new FrmAddComment(CurrTicket);
            addComment.ShowDialog();
            PopulateComments();
        }

        private void btnDeleteComment_Click(object sender, EventArgs e)
        {
            if (CurrComment() != null )
            {
                // This will disallow deleting of comments only if they belong to the user or if the current logged in user is a tech
                if (State.CurrUser.Username != CurrComment().User.Username && !State.CurrUser.Role.IsTechnician)
                    MessageBox.Show("Access Denied");

                else
                {
                    CommentDB.DeleteComment(CurrComment());
                    PopulateComments();
                }

            }
            else
            {
                MessageBox.Show(
                    "No Comment selected");
                PopulateComments();
            }

        }

        // method for grabbing the comment selected on the list box
        private  Comment CurrComment()
        { 
            return (Comment)lstBxComments.SelectedItem;
        }

    }
}
