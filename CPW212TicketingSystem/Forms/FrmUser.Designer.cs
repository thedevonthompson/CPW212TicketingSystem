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
            this.TxtFirstName.Location = new System.Drawing.Point(265, 68);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(100, 20);
            this.TxtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(265, 100);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(100, 20);
            this.TxtLastName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(265, 132);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(100, 20);
            this.TxtUsername.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(265, 164);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(201, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password:";
            // 
            // BtnRegisterOrUpdate
            // 
            this.BtnRegisterOrUpdate.Location = new System.Drawing.Point(198, 194);
            this.BtnRegisterOrUpdate.Name = "BtnRegisterOrUpdate";
            this.BtnRegisterOrUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnRegisterOrUpdate.TabIndex = 2;
            this.BtnRegisterOrUpdate.Text = "Register";
            this.BtnRegisterOrUpdate.UseVisualStyleBackColor = true;
            this.BtnRegisterOrUpdate.Click += new System.EventHandler(this.BtnRegisterOrUpdate_Click);
            // 
            // LstUser
            // 
            this.LstUser.FormattingEnabled = true;
            this.LstUser.Location = new System.Drawing.Point(27, 34);
            this.LstUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LstUser.Name = "LstUser";
            this.LstUser.Size = new System.Drawing.Size(152, 186);
            this.LstUser.TabIndex = 3;
            this.LstUser.SelectedIndexChanged += new System.EventHandler(this.LstUsers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(231, 36);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Role:";
            // 
            // CboRole
            // 
            this.CboRole.FormattingEnabled = true;
            this.CboRole.Location = new System.Drawing.Point(265, 34);
            this.CboRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CboRole.Name = "CboRole";
            this.CboRole.Size = new System.Drawing.Size(100, 21);
            this.CboRole.TabIndex = 6;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(287, 194);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Delete";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 245);
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
            this.Name = "FrmUser";
            this.Text = "User";
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