namespace CPW212TicketingSystem
{
    partial class FrmAddComment
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
            this.txtBxNewComent = new System.Windows.Forms.RichTextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxNewComent
            // 
            this.txtBxNewComent.Location = new System.Drawing.Point(12, 12);
            this.txtBxNewComent.Name = "txtBxNewComent";
            this.txtBxNewComent.Size = new System.Drawing.Size(557, 317);
            this.txtBxNewComent.TabIndex = 0;
            this.txtBxNewComent.Text = "";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(175, 353);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(214, 75);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FrmAddComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 452);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBxNewComent);
            this.Name = "FrmAddComment";
            this.Text = "FrmAddComment";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtBxNewComent;
        private System.Windows.Forms.Button btnSubmit;
    }
}