namespace CPW212TicketingSystem.Forms
{
    partial class FrmMainTechnician
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCreateTicket = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboPriorities = new System.Windows.Forms.ComboBox();
            this.DtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LstTickets = new System.Windows.Forms.ListBox();
            this.BtnEditUsers = new System.Windows.Forms.Button();
            this.BtnEditRoles = new System.Windows.Forms.Button();
            this.BtnEditPriorities = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateTicket
            // 
            this.BtnCreateTicket.Location = new System.Drawing.Point(304, 574);
            this.BtnCreateTicket.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnCreateTicket.Name = "BtnCreateTicket";
            this.BtnCreateTicket.Size = new System.Drawing.Size(193, 55);
            this.BtnCreateTicket.TabIndex = 15;
            this.BtnCreateTicket.Text = "Create New Ticket";
            this.BtnCreateTicket.UseVisualStyleBackColor = true;
            this.BtnCreateTicket.Click += new System.EventHandler(this.BtnCreateTicket_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 530);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 486);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Due Date:";
            // 
            // CboPriorities
            // 
            this.CboPriorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPriorities.FormattingEnabled = true;
            this.CboPriorities.Location = new System.Drawing.Point(130, 524);
            this.CboPriorities.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CboPriorities.Name = "CboPriorities";
            this.CboPriorities.Size = new System.Drawing.Size(363, 32);
            this.CboPriorities.TabIndex = 12;
            // 
            // DtpDueDate
            // 
            this.DtpDueDate.Checked = false;
            this.DtpDueDate.Location = new System.Drawing.Point(130, 474);
            this.DtpDueDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DtpDueDate.Name = "DtpDueDate";
            this.DtpDueDate.ShowCheckBox = true;
            this.DtpDueDate.Size = new System.Drawing.Size(363, 29);
            this.DtpDueDate.TabIndex = 11;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(130, 428);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(363, 29);
            this.TxtTitle.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 434);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            // 
            // LstTickets
            // 
            this.LstTickets.FormattingEnabled = true;
            this.LstTickets.ItemHeight = 24;
            this.LstTickets.Location = new System.Drawing.Point(22, 22);
            this.LstTickets.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LstTickets.Name = "LstTickets";
            this.LstTickets.Size = new System.Drawing.Size(1097, 364);
            this.LstTickets.TabIndex = 8;
            this.LstTickets.SelectedIndexChanged += new System.EventHandler(this.LstTickets_SelectedIndexChanged);
            this.LstTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstTickets_MouseDoubleClick);
            // 
            // BtnEditUsers
            // 
            this.BtnEditUsers.Location = new System.Drawing.Point(873, 428);
            this.BtnEditUsers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnEditUsers.Name = "BtnEditUsers";
            this.BtnEditUsers.Size = new System.Drawing.Size(183, 92);
            this.BtnEditUsers.TabIndex = 16;
            this.BtnEditUsers.Text = "Edit Users";
            this.BtnEditUsers.UseVisualStyleBackColor = true;
            this.BtnEditUsers.Click += new System.EventHandler(this.BtnEditUsers_Click);
            // 
            // BtnEditRoles
            // 
            this.BtnEditRoles.Location = new System.Drawing.Point(873, 532);
            this.BtnEditRoles.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnEditRoles.Name = "BtnEditRoles";
            this.BtnEditRoles.Size = new System.Drawing.Size(183, 92);
            this.BtnEditRoles.TabIndex = 17;
            this.BtnEditRoles.Text = "Edit Roles";
            this.BtnEditRoles.UseVisualStyleBackColor = true;
            this.BtnEditRoles.Click += new System.EventHandler(this.BtnEditRoles_Click);
            // 
            // BtnEditPriorities
            // 
            this.BtnEditPriorities.Location = new System.Drawing.Point(873, 635);
            this.BtnEditPriorities.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnEditPriorities.Name = "BtnEditPriorities";
            this.BtnEditPriorities.Size = new System.Drawing.Size(183, 92);
            this.BtnEditPriorities.TabIndex = 18;
            this.BtnEditPriorities.Text = "Edit Priorities";
            this.BtnEditPriorities.UseVisualStyleBackColor = true;
            this.BtnEditPriorities.Click += new System.EventHandler(this.BtnEditPriorities_Click);
            // 
            // FrmMainTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 814);
            this.Controls.Add(this.BtnEditPriorities);
            this.Controls.Add(this.BtnEditRoles);
            this.Controls.Add(this.BtnEditUsers);
            this.Controls.Add(this.BtnCreateTicket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CboPriorities);
            this.Controls.Add(this.DtpDueDate);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstTickets);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmMainTechnician";
            this.Text = "FrmMainTechnician";
            this.Load += new System.EventHandler(this.FrmMainTechnician_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCreateTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CboPriorities;
        private System.Windows.Forms.DateTimePicker DtpDueDate;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ListBox LstTickets;
        private System.Windows.Forms.Button BtnEditUsers;
        private System.Windows.Forms.Button BtnEditRoles;
        private System.Windows.Forms.Button BtnEditPriorities;
    }
}