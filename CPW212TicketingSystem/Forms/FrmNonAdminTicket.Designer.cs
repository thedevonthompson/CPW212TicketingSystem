namespace CPW212TicketingSystem.Forms
{
    partial class FrmNonAdminTicket
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
            this.CboPriority = new System.Windows.Forms.ComboBox();
            this.BtnAddOrUpdate = new System.Windows.Forms.Button();
            this.DtpCreated = new System.Windows.Forms.DateTimePicker();
            this.LblCreated = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.CbxCompleted = new System.Windows.Forms.CheckBox();
            this.TxtTicketCreator = new System.Windows.Forms.TextBox();
            this.DtpLastUpdated = new System.Windows.Forms.DateTimePicker();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.TxtTicketID = new System.Windows.Forms.TextBox();
            this.BtnViewComments = new System.Windows.Forms.Button();
            this.LblPriority1 = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblLastUpdated = new System.Windows.Forms.Label();
            this.LblCompleted = new System.Windows.Forms.Label();
            this.LblTitle1 = new System.Windows.Forms.Label();
            this.LblTicketID1 = new System.Windows.Forms.Label();
            this.DtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.LblDueDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CboPriority
            // 
            this.CboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPriority.FormattingEnabled = true;
            this.CboPriority.Location = new System.Drawing.Point(158, 194);
            this.CboPriority.Margin = new System.Windows.Forms.Padding(6);
            this.CboPriority.Name = "CboPriority";
            this.CboPriority.Size = new System.Drawing.Size(238, 33);
            this.CboPriority.TabIndex = 41;
            // 
            // BtnAddOrUpdate
            // 
            this.BtnAddOrUpdate.Location = new System.Drawing.Point(668, 298);
            this.BtnAddOrUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAddOrUpdate.Name = "BtnAddOrUpdate";
            this.BtnAddOrUpdate.Size = new System.Drawing.Size(180, 58);
            this.BtnAddOrUpdate.TabIndex = 40;
            this.BtnAddOrUpdate.Text = "Add Or Update";
            this.BtnAddOrUpdate.UseVisualStyleBackColor = true;
            this.BtnAddOrUpdate.Click += new System.EventHandler(this.BtnAddOrUpdate_Click);
            // 
            // DtpCreated
            // 
            this.DtpCreated.Enabled = false;
            this.DtpCreated.Location = new System.Drawing.Point(648, 142);
            this.DtpCreated.Margin = new System.Windows.Forms.Padding(6);
            this.DtpCreated.Name = "DtpCreated";
            this.DtpCreated.Size = new System.Drawing.Size(396, 31);
            this.DtpCreated.TabIndex = 39;
            // 
            // LblCreated
            // 
            this.LblCreated.AutoSize = true;
            this.LblCreated.Location = new System.Drawing.Point(542, 150);
            this.LblCreated.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCreated.Name = "LblCreated";
            this.LblCreated.Size = new System.Drawing.Size(94, 25);
            this.LblCreated.TabIndex = 38;
            this.LblCreated.Text = "Created:";
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(418, 31);
            this.LblHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(222, 37);
            this.LblHeader.TabIndex = 36;
            this.LblHeader.Text = "Ticket Details";
            // 
            // CbxCompleted
            // 
            this.CbxCompleted.AutoSize = true;
            this.CbxCompleted.Location = new System.Drawing.Point(158, 244);
            this.CbxCompleted.Margin = new System.Windows.Forms.Padding(6);
            this.CbxCompleted.Name = "CbxCompleted";
            this.CbxCompleted.Size = new System.Drawing.Size(28, 27);
            this.CbxCompleted.TabIndex = 35;
            this.CbxCompleted.UseVisualStyleBackColor = true;
            // 
            // TxtTicketCreator
            // 
            this.TxtTicketCreator.Enabled = false;
            this.TxtTicketCreator.Location = new System.Drawing.Point(648, 92);
            this.TxtTicketCreator.Margin = new System.Windows.Forms.Padding(6);
            this.TxtTicketCreator.Name = "TxtTicketCreator";
            this.TxtTicketCreator.Size = new System.Drawing.Size(262, 31);
            this.TxtTicketCreator.TabIndex = 34;
            // 
            // DtpLastUpdated
            // 
            this.DtpLastUpdated.Enabled = false;
            this.DtpLastUpdated.Location = new System.Drawing.Point(648, 192);
            this.DtpLastUpdated.Margin = new System.Windows.Forms.Padding(6);
            this.DtpLastUpdated.Name = "DtpLastUpdated";
            this.DtpLastUpdated.Size = new System.Drawing.Size(396, 31);
            this.DtpLastUpdated.TabIndex = 32;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(158, 144);
            this.TxtTitle.Margin = new System.Windows.Forms.Padding(6);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(312, 31);
            this.TxtTitle.TabIndex = 31;
            // 
            // TxtTicketID
            // 
            this.TxtTicketID.Enabled = false;
            this.TxtTicketID.Location = new System.Drawing.Point(158, 94);
            this.TxtTicketID.Margin = new System.Windows.Forms.Padding(6);
            this.TxtTicketID.Name = "TxtTicketID";
            this.TxtTicketID.Size = new System.Drawing.Size(196, 31);
            this.TxtTicketID.TabIndex = 30;
            // 
            // BtnViewComments
            // 
            this.BtnViewComments.Location = new System.Drawing.Point(468, 298);
            this.BtnViewComments.Margin = new System.Windows.Forms.Padding(6);
            this.BtnViewComments.Name = "BtnViewComments";
            this.BtnViewComments.Size = new System.Drawing.Size(180, 58);
            this.BtnViewComments.TabIndex = 29;
            this.BtnViewComments.Text = "View Comments";
            this.BtnViewComments.UseVisualStyleBackColor = true;
            this.BtnViewComments.Click += new System.EventHandler(this.BtnViewComments_Click);
            // 
            // LblPriority1
            // 
            this.LblPriority1.AutoSize = true;
            this.LblPriority1.Location = new System.Drawing.Point(64, 200);
            this.LblPriority1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblPriority1.Name = "LblPriority1";
            this.LblPriority1.Size = new System.Drawing.Size(85, 25);
            this.LblPriority1.TabIndex = 28;
            this.LblPriority1.Text = "Priority:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(482, 98);
            this.LblUserName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(153, 25);
            this.LblUserName.TabIndex = 27;
            this.LblUserName.Text = "Ticket Creator:";
            // 
            // LblLastUpdated
            // 
            this.LblLastUpdated.AutoSize = true;
            this.LblLastUpdated.Location = new System.Drawing.Point(488, 200);
            this.LblLastUpdated.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblLastUpdated.Name = "LblLastUpdated";
            this.LblLastUpdated.Size = new System.Drawing.Size(146, 25);
            this.LblLastUpdated.TabIndex = 25;
            this.LblLastUpdated.Text = "Last Updated:";
            // 
            // LblCompleted
            // 
            this.LblCompleted.AutoSize = true;
            this.LblCompleted.Location = new System.Drawing.Point(26, 244);
            this.LblCompleted.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblCompleted.Name = "LblCompleted";
            this.LblCompleted.Size = new System.Drawing.Size(121, 25);
            this.LblCompleted.TabIndex = 24;
            this.LblCompleted.Text = "Completed:";
            // 
            // LblTitle1
            // 
            this.LblTitle1.AutoSize = true;
            this.LblTitle1.Location = new System.Drawing.Point(86, 150);
            this.LblTitle1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblTitle1.Name = "LblTitle1";
            this.LblTitle1.Size = new System.Drawing.Size(59, 25);
            this.LblTitle1.TabIndex = 23;
            this.LblTitle1.Text = "Title:";
            // 
            // LblTicketID1
            // 
            this.LblTicketID1.AutoSize = true;
            this.LblTicketID1.Location = new System.Drawing.Point(38, 98);
            this.LblTicketID1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblTicketID1.Name = "LblTicketID1";
            this.LblTicketID1.Size = new System.Drawing.Size(102, 25);
            this.LblTicketID1.TabIndex = 22;
            this.LblTicketID1.Text = "Ticket ID:";
            // 
            // DtpDueDate
            // 
            this.DtpDueDate.CustomFormat = "";
            this.DtpDueDate.Location = new System.Drawing.Point(648, 239);
            this.DtpDueDate.Margin = new System.Windows.Forms.Padding(6);
            this.DtpDueDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.DtpDueDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DtpDueDate.Name = "DtpDueDate";
            this.DtpDueDate.Size = new System.Drawing.Size(396, 31);
            this.DtpDueDate.TabIndex = 43;
            this.DtpDueDate.ValueChanged += new System.EventHandler(this.DtpDueDate_ValueChanged);
            // 
            // LblDueDate
            // 
            this.LblDueDate.AutoSize = true;
            this.LblDueDate.Location = new System.Drawing.Point(526, 244);
            this.LblDueDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LblDueDate.Name = "LblDueDate";
            this.LblDueDate.Size = new System.Drawing.Size(108, 25);
            this.LblDueDate.TabIndex = 42;
            this.LblDueDate.Text = "Due Date:";
            // 
            // FrmNonAdminTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 376);
            this.Controls.Add(this.DtpDueDate);
            this.Controls.Add(this.LblDueDate);
            this.Controls.Add(this.CboPriority);
            this.Controls.Add(this.BtnAddOrUpdate);
            this.Controls.Add(this.DtpCreated);
            this.Controls.Add(this.LblCreated);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.CbxCompleted);
            this.Controls.Add(this.TxtTicketCreator);
            this.Controls.Add(this.DtpLastUpdated);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TxtTicketID);
            this.Controls.Add(this.BtnViewComments);
            this.Controls.Add(this.LblPriority1);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblLastUpdated);
            this.Controls.Add(this.LblCompleted);
            this.Controls.Add(this.LblTitle1);
            this.Controls.Add(this.LblTicketID1);
            this.Name = "FrmNonAdminTicket";
            this.Load += new System.EventHandler(this.FrmNonAdminTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboPriority;
        private System.Windows.Forms.Button BtnAddOrUpdate;
        private System.Windows.Forms.DateTimePicker DtpCreated;
        private System.Windows.Forms.Label LblCreated;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.CheckBox CbxCompleted;
        private System.Windows.Forms.TextBox TxtTicketCreator;
        private System.Windows.Forms.DateTimePicker DtpLastUpdated;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.TextBox TxtTicketID;
        private System.Windows.Forms.Button BtnViewComments;
        private System.Windows.Forms.Label LblPriority1;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblLastUpdated;
        private System.Windows.Forms.Label LblCompleted;
        private System.Windows.Forms.Label LblTitle1;
        private System.Windows.Forms.Label LblTicketID1;
        private System.Windows.Forms.DateTimePicker DtpDueDate;
        private System.Windows.Forms.Label LblDueDate;
    }
}