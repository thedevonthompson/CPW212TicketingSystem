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
    public partial class FrmTicket : Form
    {
        public Ticket Ticket { get; set; }

        public FrmTicket(Ticket t)
        {
            InitializeComponent();
            Ticket = t;
        }

        private void FrmTicket_Load(object sender, EventArgs e)
        {
            CboPriority.DataSource = PriorityDB.GetAllPriorities();

            if (Ticket == null)
            {
                BtnAddOrUpdate.Text = "Add";
                DtpCreated.Value = DateTime.Now;
                TxtTicketCreator.Text = State.CurrUser.ToString();
                BtnDelete.Enabled = false;
                BtnViewComments.Enabled = false;
                CbxCompleted.Enabled = false;
            }
            else
            {
                BtnAddOrUpdate.Text = "Update";
                PopulateFields();
            }
        }

        private void PopulateFields()
        {
            TxtTicketID.Text = Ticket.TicketID.ToString();
            TxtTicketCreator.Text = Ticket.User.ToString();
            TxtTitle.Text = Ticket.Title;
            DtpCreated.Value = Ticket.Created;
            CboPriority.SelectedItem = Ticket.Priority.Level;
            CbxCompleted.Checked = Ticket.IsCompleted;
            DtpLastUpdated.Value = Ticket.LastUpdated;

            if (Ticket.DueDate == null)
                DtpDueDate.Checked = false;
            else
                DtpDueDate.Value = (DateTime)Ticket.DueDate;
        }

        private void BtnViewComments_Click(object sender, EventArgs e)
        {
            CommentForm comments = new CommentForm(Ticket);
            comments.ShowDialog();
        }

        private void BtnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (FieldsAreValid())
            {
                PopulateTicket();
                TicketDB.AddOrUpdate(Ticket);
                this.Close();
            }
        }

        private void PopulateTicket()
        {
            DateTime? due = (DtpDueDate.Checked) ? (DateTime?)DtpDueDate.Value : null;

            if (Ticket == null)
            {
                Ticket = new Ticket(TxtTitle.Text, due, (Priority)CboPriority.SelectedItem);
            }
            else
            {
                Ticket.Title = TxtTitle.Text;
                Ticket.Priority = (Priority)CboPriority.SelectedItem;
                Ticket.IsCompleted = CbxCompleted.Checked;
                Ticket.LastUpdated = DateTime.Now;
                Ticket.DueDate = due;
            }

        }

        private bool FieldsAreValid()
        {
            if (String.IsNullOrWhiteSpace(TxtTitle.Text))
            {
                MessageBox.Show("The ticket must have a title!");
                return false;
            }

            // If the due date check box is checked, the date should be greater than or equal to today.
            if (DtpDueDate.Checked == true && DtpDueDate.Value < DateTime.Today)
            {
                MessageBox.Show("The due date must be in the future!");
                return false;
            }

            return true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you would like to delete this ticket?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                CommentDB.DeleteAllComments(Ticket);
                TicketDB.Delete(Ticket);
                this.Close();
            }
        }

    }
}
