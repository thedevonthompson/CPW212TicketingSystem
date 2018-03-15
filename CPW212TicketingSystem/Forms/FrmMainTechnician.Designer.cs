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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCreateTicket
            // 
            this.BtnCreateTicket.FlatAppearance.BorderSize = 0;
            this.BtnCreateTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateTicket.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateTicket.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnCreateTicket.Location = new System.Drawing.Point(647, 370);
            this.BtnCreateTicket.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnCreateTicket.Name = "BtnCreateTicket";
            this.BtnCreateTicket.Size = new System.Drawing.Size(306, 186);
            this.BtnCreateTicket.TabIndex = 15;
            this.BtnCreateTicket.Text = "Create New Ticket";
            this.BtnCreateTicket.UseVisualStyleBackColor = true;
            this.BtnCreateTicket.Click += new System.EventHandler(this.BtnCreateTicket_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(71, 511);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Priority:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(71, 453);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Due Date:";
            // 
            // CboPriorities
            // 
            this.CboPriorities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPriorities.FormattingEnabled = true;
            this.CboPriorities.Location = new System.Drawing.Point(195, 506);
            this.CboPriorities.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.CboPriorities.Name = "CboPriorities";
            this.CboPriorities.Size = new System.Drawing.Size(396, 33);
            this.CboPriorities.TabIndex = 12;
            // 
            // DtpDueDate
            // 
            this.DtpDueDate.Location = new System.Drawing.Point(195, 450);
            this.DtpDueDate.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.DtpDueDate.Name = "DtpDueDate";
            this.DtpDueDate.Size = new System.Drawing.Size(396, 31);
            this.DtpDueDate.TabIndex = 11;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(195, 394);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(396, 31);
            this.TxtTitle.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(71, 397);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Title:";
            // 
            // LstTickets
            // 
            this.LstTickets.BackColor = System.Drawing.Color.White;
            this.LstTickets.ForeColor = System.Drawing.SystemColors.MenuText;
            this.LstTickets.FormattingEnabled = true;
            this.LstTickets.ItemHeight = 25;
            this.LstTickets.Location = new System.Drawing.Point(24, 92);
            this.LstTickets.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.LstTickets.Name = "LstTickets";
            this.LstTickets.Size = new System.Drawing.Size(912, 254);
            this.LstTickets.TabIndex = 8;
            this.LstTickets.SelectedIndexChanged += new System.EventHandler(this.LstTickets_SelectedIndexChanged);
            this.LstTickets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstTickets_MouseDoubleClick);
            // 
            // BtnEditUsers
            // 
            this.BtnEditUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditUsers.FlatAppearance.BorderSize = 0;
            this.BtnEditUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditUsers.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEditUsers.Location = new System.Drawing.Point(13, 568);
            this.BtnEditUsers.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnEditUsers.Name = "BtnEditUsers";
            this.BtnEditUsers.Size = new System.Drawing.Size(270, 168);
            this.BtnEditUsers.TabIndex = 16;
            this.BtnEditUsers.Text = "Edit Users";
            this.BtnEditUsers.UseVisualStyleBackColor = true;
            this.BtnEditUsers.Click += new System.EventHandler(this.BtnEditUsers_Click);
            // 
            // BtnEditRoles
            // 
            this.BtnEditRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditRoles.FlatAppearance.BorderSize = 0;
            this.BtnEditRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditRoles.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditRoles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEditRoles.Location = new System.Drawing.Point(286, 568);
            this.BtnEditRoles.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnEditRoles.Name = "BtnEditRoles";
            this.BtnEditRoles.Size = new System.Drawing.Size(271, 168);
            this.BtnEditRoles.TabIndex = 17;
            this.BtnEditRoles.Text = "Edit Roles";
            this.BtnEditRoles.UseVisualStyleBackColor = true;
            this.BtnEditRoles.Click += new System.EventHandler(this.BtnEditRoles_Click);
            // 
            // BtnEditPriorities
            // 
            this.BtnEditPriorities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEditPriorities.FlatAppearance.BorderSize = 0;
            this.BtnEditPriorities.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEditPriorities.Font = new System.Drawing.Font("Comic Sans MS", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEditPriorities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEditPriorities.Location = new System.Drawing.Point(560, 568);
            this.BtnEditPriorities.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.BtnEditPriorities.Name = "BtnEditPriorities";
            this.BtnEditPriorities.Size = new System.Drawing.Size(273, 168);
            this.BtnEditPriorities.TabIndex = 18;
            this.BtnEditPriorities.Text = "Edit Priorities";
            this.BtnEditPriorities.UseVisualStyleBackColor = true;
            this.BtnEditPriorities.Click += new System.EventHandler(this.BtnEditPriorities_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 657);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 79);
            this.button1.TabIndex = 19;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMainTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(958, 752);
            this.Controls.Add(this.button1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmMainTechnician";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button button1;
    }
}