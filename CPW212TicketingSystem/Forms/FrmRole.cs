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
    public partial class FrmRole : Form
    {
        public FrmRole()
        {
            InitializeComponent();
        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void RefreshForm()
        {
            PopulateRoleComboBox();
            ClearAllFields();
        }

        private void PopulateRoleComboBox()
        {
            CboRoles.DataSource = RoleDB.GetAllRoles();
            CboRoles.DisplayMember = nameof(Role.Name);
        }

        private void ClearAllFields()
        {
            CboRoles.SelectedIndex = -1;
            TxtName.Text = string.Empty;
            TxtLevel.Text = string.Empty;
            CbxTechnician.Checked = false;
            CbxDeleteTickets.Checked = false;
            CbxAssignTickets.Checked = false;
            CbxChangePriority.Checked = false;
            CbxEditRoles.Checked = false;
            CbxEditUsers.Checked = false;
        }

        private void CboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CboRoles.SelectedIndex < 0)
            {
                BtnAddOrUpdate.Text = "Add";
                BtnDelete.Enabled = false;
                ClearAllFields();
            }
            else
            {
                BtnAddOrUpdate.Text = "Update";
                BtnDelete.Enabled = true;

                Role selRole = (Role)CboRoles.SelectedItem;

                TxtName.Text = selRole.Name;
                TxtLevel.Text = Convert.ToString(selRole.Level);
                CbxTechnician.Checked = selRole.IsTechnician;
                CbxDeleteTickets.Checked = selRole.CanDeleteTickets;
                CbxAssignTickets.Checked = selRole.CanAssignTickets;
                CbxChangePriority.Checked = selRole.CanChangePriority;
                CbxEditRoles.Checked = selRole.CanEditRoles;
                CbxEditUsers.Checked = selRole.CanEditUsers;
            }
        }

        private void BtnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!FieldsAreValid())
            {
                return;
            }

            if (CboRoles.SelectedIndex < 0)
            {
                Role newRole = new Role()
                {
                    Level = Convert.ToByte(TxtLevel.Text),
                    Name = TxtName.Text,
                    IsTechnician = CbxTechnician.Checked,
                    CanDeleteTickets = CbxDeleteTickets.Checked,
                    CanChangePriority = CbxChangePriority.Checked,
                    CanAssignTickets = CbxAssignTickets.Checked,
                    CanEditRoles = CbxEditRoles.Checked,
                    CanEditUsers = CbxEditUsers.Checked
                };
                try
                {
                    RoleDB.Add(newRole);
                    MessageBox.Show("Role saved succesfuly");
                    RefreshForm();
                }
                catch
                {
                    MessageBox.Show("Error: Role could not be saved");
                }
            }
            else
            {
                Role selRole = (Role)CboRoles.SelectedItem;
                selRole.Level = Convert.ToByte(TxtLevel.Text);
                selRole.Name = TxtName.Text;
                selRole.IsTechnician = CbxTechnician.Checked;
                selRole.CanDeleteTickets = CbxDeleteTickets.Checked;
                selRole.CanChangePriority = CbxChangePriority.Checked;
                selRole.CanAssignTickets = CbxAssignTickets.Checked;
                selRole.CanEditRoles = CbxEditRoles.Checked;
                selRole.CanEditUsers = CbxEditUsers.Checked;

                try
                {
                    RoleDB.Update(selRole);
                    MessageBox.Show("Role successfuly updated");
                    RefreshForm();
                }
                catch
                {
                    MessageBox.Show("Error: Role not updated succesfuly");
                }
            }
        }

        private bool FieldsAreValid()
        {
            if (string.IsNullOrWhiteSpace(TxtName.Text))
            {
                MessageBox.Show("Name is required");
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtLevel.Text))
            {
                MessageBox.Show("Level is required");
                return false;
            }
            if (!byte.TryParse(TxtLevel.Text, out byte result))
            {
                MessageBox.Show("Level must be a whole number");
                return false;
            }
            return true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Role selRole = (Role)CboRoles.SelectedItem;
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {selRole.Name}?", "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    RoleDB.Delete(selRole);
                    MessageBox.Show($"{selRole} deleted successfuly");
                    RefreshForm();
                }
                catch
                {
                    MessageBox.Show($"Error: {selRole} was not deleted successfuly");
                }
            }
        }
    }
}
