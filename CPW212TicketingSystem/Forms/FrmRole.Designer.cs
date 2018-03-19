﻿namespace CPW212TicketingSystem
{
    partial class FrmRole
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
            this.label1 = new System.Windows.Forms.Label();
            this.CboRoles = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxEditUsers = new System.Windows.Forms.CheckBox();
            this.CbxAssignTickets = new System.Windows.Forms.CheckBox();
            this.CbxEditRoles = new System.Windows.Forms.CheckBox();
            this.CbxDeleteTickets = new System.Windows.Forms.CheckBox();
            this.CbxChangePriority = new System.Windows.Forms.CheckBox();
            this.CbxTechnician = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnAddOrUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.TxtLevel = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Roles:";
            // 
            // CboRoles
            // 
            this.CboRoles.FormattingEnabled = true;
            this.CboRoles.Location = new System.Drawing.Point(165, 32);
            this.CboRoles.Name = "CboRoles";
            this.CboRoles.Size = new System.Drawing.Size(224, 33);
            this.CboRoles.TabIndex = 1;
            this.CboRoles.SelectedIndexChanged += new System.EventHandler(this.CboRoles_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbxEditUsers);
            this.groupBox1.Controls.Add(this.CbxAssignTickets);
            this.groupBox1.Controls.Add(this.CbxEditRoles);
            this.groupBox1.Controls.Add(this.CbxDeleteTickets);
            this.groupBox1.Controls.Add(this.CbxChangePriority);
            this.groupBox1.Controls.Add(this.CbxTechnician);
            this.groupBox1.Location = new System.Drawing.Point(25, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissions";
            // 
            // CbxEditUsers
            // 
            this.CbxEditUsers.AutoSize = true;
            this.CbxEditUsers.Location = new System.Drawing.Point(221, 141);
            this.CbxEditUsers.Name = "CbxEditUsers";
            this.CbxEditUsers.Size = new System.Drawing.Size(143, 29);
            this.CbxEditUsers.TabIndex = 1;
            this.CbxEditUsers.Text = "Edit Users";
            this.CbxEditUsers.UseVisualStyleBackColor = true;
            // 
            // CbxAssignTickets
            // 
            this.CbxAssignTickets.AutoSize = true;
            this.CbxAssignTickets.Location = new System.Drawing.Point(26, 141);
            this.CbxAssignTickets.Name = "CbxAssignTickets";
            this.CbxAssignTickets.Size = new System.Drawing.Size(184, 29);
            this.CbxAssignTickets.TabIndex = 1;
            this.CbxAssignTickets.Text = "Assign Tickets";
            this.CbxAssignTickets.UseVisualStyleBackColor = true;
            // 
            // CbxEditRoles
            // 
            this.CbxEditRoles.AutoSize = true;
            this.CbxEditRoles.Location = new System.Drawing.Point(223, 94);
            this.CbxEditRoles.Name = "CbxEditRoles";
            this.CbxEditRoles.Size = new System.Drawing.Size(142, 29);
            this.CbxEditRoles.TabIndex = 1;
            this.CbxEditRoles.Text = "Edit Roles";
            this.CbxEditRoles.UseVisualStyleBackColor = true;
            // 
            // CbxDeleteTickets
            // 
            this.CbxDeleteTickets.AutoSize = true;
            this.CbxDeleteTickets.Location = new System.Drawing.Point(27, 94);
            this.CbxDeleteTickets.Name = "CbxDeleteTickets";
            this.CbxDeleteTickets.Size = new System.Drawing.Size(181, 29);
            this.CbxDeleteTickets.TabIndex = 1;
            this.CbxDeleteTickets.Text = "Delete Tickets";
            this.CbxDeleteTickets.UseVisualStyleBackColor = true;
            // 
            // CbxChangePriority
            // 
            this.CbxChangePriority.AutoSize = true;
            this.CbxChangePriority.Location = new System.Drawing.Point(223, 46);
            this.CbxChangePriority.Name = "CbxChangePriority";
            this.CbxChangePriority.Size = new System.Drawing.Size(192, 29);
            this.CbxChangePriority.TabIndex = 0;
            this.CbxChangePriority.Text = "Change Priority";
            this.CbxChangePriority.UseVisualStyleBackColor = true;
            // 
            // CbxTechnician
            // 
            this.CbxTechnician.AutoSize = true;
            this.CbxTechnician.Location = new System.Drawing.Point(27, 46);
            this.CbxTechnician.Name = "CbxTechnician";
            this.CbxTechnician.Size = new System.Drawing.Size(149, 29);
            this.CbxTechnician.TabIndex = 0;
            this.CbxTechnician.Text = "Technician";
            this.CbxTechnician.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(165, 80);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(224, 31);
            this.TxtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Level:";
            // 
            // BtnAddOrUpdate
            // 
            this.BtnAddOrUpdate.Location = new System.Drawing.Point(75, 404);
            this.BtnAddOrUpdate.Name = "BtnAddOrUpdate";
            this.BtnAddOrUpdate.Size = new System.Drawing.Size(154, 55);
            this.BtnAddOrUpdate.TabIndex = 6;
            this.BtnAddOrUpdate.Text = "Add";
            this.BtnAddOrUpdate.UseVisualStyleBackColor = true;
            this.BtnAddOrUpdate.Click += new System.EventHandler(this.BtnAddOrUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(260, 404);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(154, 55);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtLevel
            // 
            this.TxtLevel.Location = new System.Drawing.Point(165, 132);
            this.TxtLevel.Name = "TxtLevel";
            this.TxtLevel.Size = new System.Drawing.Size(109, 31);
            this.TxtLevel.TabIndex = 7;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.Controls.Add(this.TxtLevel);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAddOrUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CboRoles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "FrmRole";
            this.Text = "Role";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboRoles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CbxTechnician;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CbxEditUsers;
        private System.Windows.Forms.CheckBox CbxAssignTickets;
        private System.Windows.Forms.CheckBox CbxEditRoles;
        private System.Windows.Forms.CheckBox CbxDeleteTickets;
        private System.Windows.Forms.CheckBox CbxChangePriority;
        private System.Windows.Forms.Button BtnAddOrUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox TxtLevel;
    }
}