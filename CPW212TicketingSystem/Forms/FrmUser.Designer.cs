namespace CPW212TicketingSystem
{
    partial class FrmUser
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
            this.TxtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnRegisterOrUpdate = new System.Windows.Forms.Button();
            this.LstUser = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CboRole = new System.Windows.Forms.ComboBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(530, 131);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(196, 31);
            this.TxtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(530, 192);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(196, 31);
            this.TxtLastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(530, 254);
            this.TxtUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(196, 31);
            this.TxtUsername.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(530, 315);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(196, 31);
            this.TxtPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // BtnRegisterOrUpdate
            // 
            this.BtnRegisterOrUpdate.Location = new System.Drawing.Point(396, 373);
            this.BtnRegisterOrUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnRegisterOrUpdate.Name = "BtnRegisterOrUpdate";
            this.BtnRegisterOrUpdate.Size = new System.Drawing.Size(150, 44);
            this.BtnRegisterOrUpdate.TabIndex = 4;
            this.BtnRegisterOrUpdate.Text = "Register";
            this.BtnRegisterOrUpdate.UseVisualStyleBackColor = true;
            this.BtnRegisterOrUpdate.Click += new System.EventHandler(this.BtnRegisterOrUpdate_Click);
            // 
            // LstUser
            // 
            this.LstUser.FormattingEnabled = true;
            this.LstUser.ItemHeight = 25;
            this.LstUser.Location = new System.Drawing.Point(54, 65);
            this.LstUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LstUser.Name = "LstUser";
            this.LstUser.Size = new System.Drawing.Size(300, 354);
            this.LstUser.TabIndex = 6;
            this.LstUser.SelectedIndexChanged += new System.EventHandler(this.LstUsers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Role:";
            // 
            // CboRole
            // 
            this.CboRole.FormattingEnabled = true;
            this.CboRole.Location = new System.Drawing.Point(530, 65);
            this.CboRole.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CboRole.Name = "CboRole";
            this.CboRole.Size = new System.Drawing.Size(196, 33);
            this.CboRole.TabIndex = 6;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(574, 373);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(150, 44);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(630, 69);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Delete";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.CboRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.LstUser);
            this.Controls.Add(this.BtnRegisterOrUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.TxtLastName);
            this.Controls.Add(this.TxtFirstName);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmUser";
            this.Load += new System.EventHandler(this.FrmRegistration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnRegisterOrUpdate;
        private System.Windows.Forms.ListBox LstUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CboRole;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label7;
    }
}