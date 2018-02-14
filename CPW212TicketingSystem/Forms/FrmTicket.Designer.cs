namespace CPW212TicketingSystem
{
    partial class FrmTicket
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
            this.LblTicketID = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblCompleted = new System.Windows.Forms.Label();
            this.LblLastUpdated = new System.Windows.Forms.Label();
            this.LblDueDate = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblPriority = new System.Windows.Forms.Label();
            this.BtnViewComments = new System.Windows.Forms.Button();
            this.TxtTicketID = new System.Windows.Forms.TextBox();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.DtpLastUpdated = new System.Windows.Forms.DateTimePicker();
            this.DtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.TxtTicketCreator = new System.Windows.Forms.TextBox();
            this.CbxCompleted = new System.Windows.Forms.CheckBox();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.DtpCreated = new System.Windows.Forms.DateTimePicker();
            this.LblCreated = new System.Windows.Forms.Label();
            this.BtnAddOrUpdate = new System.Windows.Forms.Button();
            this.CboPriority = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LblTicketID
            // 
            this.LblTicketID.AutoSize = true;
            this.LblTicketID.Location = new System.Drawing.Point(18, 50);
            this.LblTicketID.Name = "LblTicketID";
            this.LblTicketID.Size = new System.Drawing.Size(54, 13);
            this.LblTicketID.TabIndex = 0;
            this.LblTicketID.Text = "Ticket ID:";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Location = new System.Drawing.Point(42, 77);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(30, 13);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Title:";
            // 
            // LblCompleted
            // 
            this.LblCompleted.AutoSize = true;
            this.LblCompleted.Location = new System.Drawing.Point(12, 126);
            this.LblCompleted.Name = "LblCompleted";
            this.LblCompleted.Size = new System.Drawing.Size(60, 13);
            this.LblCompleted.TabIndex = 2;
            this.LblCompleted.Text = "Completed:";
            // 
            // LblLastUpdated
            // 
            this.LblLastUpdated.AutoSize = true;
            this.LblLastUpdated.Location = new System.Drawing.Point(243, 103);
            this.LblLastUpdated.Name = "LblLastUpdated";
            this.LblLastUpdated.Size = new System.Drawing.Size(74, 13);
            this.LblLastUpdated.TabIndex = 3;
            this.LblLastUpdated.Text = "Last Updated:";
            // 
            // LblDueDate
            // 
            this.LblDueDate.AutoSize = true;
            this.LblDueDate.Location = new System.Drawing.Point(261, 131);
            this.LblDueDate.Name = "LblDueDate";
            this.LblDueDate.Size = new System.Drawing.Size(56, 13);
            this.LblDueDate.TabIndex = 4;
            this.LblDueDate.Text = "Due Date:";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Location = new System.Drawing.Point(240, 50);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(77, 13);
            this.LblUserName.TabIndex = 5;
            this.LblUserName.Text = "Ticket Creator:";
            // 
            // LblPriority
            // 
            this.LblPriority.AutoSize = true;
            this.LblPriority.Location = new System.Drawing.Point(31, 103);
            this.LblPriority.Name = "LblPriority";
            this.LblPriority.Size = new System.Drawing.Size(41, 13);
            this.LblPriority.TabIndex = 6;
            this.LblPriority.Text = "Priority:";
            // 
            // BtnViewComments
            // 
            this.BtnViewComments.Location = new System.Drawing.Point(233, 154);
            this.BtnViewComments.Name = "BtnViewComments";
            this.BtnViewComments.Size = new System.Drawing.Size(90, 30);
            this.BtnViewComments.TabIndex = 7;
            this.BtnViewComments.Text = "View Comments";
            this.BtnViewComments.UseVisualStyleBackColor = true;
            this.BtnViewComments.Click += new System.EventHandler(this.BtnViewComments_Click);
            // 
            // TxtTicketID
            // 
            this.TxtTicketID.Enabled = false;
            this.TxtTicketID.Location = new System.Drawing.Point(78, 48);
            this.TxtTicketID.Name = "TxtTicketID";
            this.TxtTicketID.Size = new System.Drawing.Size(100, 20);
            this.TxtTicketID.TabIndex = 8;
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(78, 74);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(158, 20);
            this.TxtTitle.TabIndex = 9;
            // 
            // DtpLastUpdated
            // 
            this.DtpLastUpdated.Enabled = false;
            this.DtpLastUpdated.Location = new System.Drawing.Point(323, 99);
            this.DtpLastUpdated.Name = "DtpLastUpdated";
            this.DtpLastUpdated.Size = new System.Drawing.Size(200, 20);
            this.DtpLastUpdated.TabIndex = 11;
            // 
            // DtpDueDate
            // 
            this.DtpDueDate.Location = new System.Drawing.Point(323, 125);
            this.DtpDueDate.Name = "DtpDueDate";
            this.DtpDueDate.ShowCheckBox = true;
            this.DtpDueDate.Size = new System.Drawing.Size(200, 20);
            this.DtpDueDate.TabIndex = 12;
            // 
            // TxtTicketCreator
            // 
            this.TxtTicketCreator.Enabled = false;
            this.TxtTicketCreator.Location = new System.Drawing.Point(323, 47);
            this.TxtTicketCreator.Name = "TxtTicketCreator";
            this.TxtTicketCreator.Size = new System.Drawing.Size(100, 20);
            this.TxtTicketCreator.TabIndex = 13;
            // 
            // CbxCompleted
            // 
            this.CbxCompleted.AutoSize = true;
            this.CbxCompleted.Location = new System.Drawing.Point(78, 126);
            this.CbxCompleted.Name = "CbxCompleted";
            this.CbxCompleted.Size = new System.Drawing.Size(15, 14);
            this.CbxCompleted.TabIndex = 14;
            this.CbxCompleted.UseVisualStyleBackColor = true;
            // 
            // LblHeader
            // 
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(208, 15);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(118, 20);
            this.LblHeader.TabIndex = 16;
            this.LblHeader.Text = "Ticket Details";
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(433, 154);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(90, 30);
            this.BtnDelete.TabIndex = 17;
            this.BtnDelete.Text = "Delete Ticket";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DtpCreated
            // 
            this.DtpCreated.Enabled = false;
            this.DtpCreated.Location = new System.Drawing.Point(323, 73);
            this.DtpCreated.Name = "DtpCreated";
            this.DtpCreated.Size = new System.Drawing.Size(200, 20);
            this.DtpCreated.TabIndex = 19;
            // 
            // LblCreated
            // 
            this.LblCreated.AutoSize = true;
            this.LblCreated.Location = new System.Drawing.Point(270, 77);
            this.LblCreated.Name = "LblCreated";
            this.LblCreated.Size = new System.Drawing.Size(47, 13);
            this.LblCreated.TabIndex = 18;
            this.LblCreated.Text = "Created:";
            // 
            // BtnAddOrUpdate
            // 
            this.BtnAddOrUpdate.Location = new System.Drawing.Point(333, 154);
            this.BtnAddOrUpdate.Name = "BtnAddOrUpdate";
            this.BtnAddOrUpdate.Size = new System.Drawing.Size(90, 30);
            this.BtnAddOrUpdate.TabIndex = 20;
            this.BtnAddOrUpdate.Text = "Add Or Update";
            this.BtnAddOrUpdate.UseVisualStyleBackColor = true;
            this.BtnAddOrUpdate.Click += new System.EventHandler(this.BtnAddOrUpdate_Click);
            // 
            // CboPriority
            // 
            this.CboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboPriority.FormattingEnabled = true;
            this.CboPriority.Location = new System.Drawing.Point(78, 100);
            this.CboPriority.Name = "CboPriority";
            this.CboPriority.Size = new System.Drawing.Size(121, 21);
            this.CboPriority.TabIndex = 21;
            // 
            // FrmTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 196);
            this.Controls.Add(this.CboPriority);
            this.Controls.Add(this.BtnAddOrUpdate);
            this.Controls.Add(this.DtpCreated);
            this.Controls.Add(this.LblCreated);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.CbxCompleted);
            this.Controls.Add(this.TxtTicketCreator);
            this.Controls.Add(this.DtpDueDate);
            this.Controls.Add(this.DtpLastUpdated);
            this.Controls.Add(this.TxtTitle);
            this.Controls.Add(this.TxtTicketID);
            this.Controls.Add(this.BtnViewComments);
            this.Controls.Add(this.LblPriority);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblDueDate);
            this.Controls.Add(this.LblLastUpdated);
            this.Controls.Add(this.LblCompleted);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblTicketID);
            this.Name = "FrmTicket";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTicketID;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblCompleted;
        private System.Windows.Forms.Label LblLastUpdated;
        private System.Windows.Forms.Label LblDueDate;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblPriority;
        private System.Windows.Forms.Button BtnViewComments;
        private System.Windows.Forms.TextBox TxtTicketID;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.DateTimePicker DtpLastUpdated;
        private System.Windows.Forms.DateTimePicker DtpDueDate;
        private System.Windows.Forms.TextBox TxtTicketCreator;
        private System.Windows.Forms.CheckBox CbxCompleted;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DateTimePicker DtpCreated;
        private System.Windows.Forms.Label LblCreated;
        private System.Windows.Forms.Button BtnAddOrUpdate;
        private System.Windows.Forms.ComboBox CboPriority;
    }
}