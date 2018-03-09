namespace CPW212TicketingSystem
{
    partial class CommentForm
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
            this.lstBxComments = new System.Windows.Forms.ListBox();
            this.txtBxComment = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditComment = new System.Windows.Forms.Button();
            this.btnNewComment = new System.Windows.Forms.Button();
            this.btnDeleteComment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBxComments
            // 
            this.lstBxComments.FormattingEnabled = true;
            this.lstBxComments.ItemHeight = 24;
            this.lstBxComments.Location = new System.Drawing.Point(21, 147);
            this.lstBxComments.Name = "lstBxComments";
            this.lstBxComments.Size = new System.Drawing.Size(1089, 364);
            this.lstBxComments.TabIndex = 0;
            this.lstBxComments.SelectedIndexChanged += new System.EventHandler(this.lstBxComments_SelectedIndexChanged);
            // 
            // txtBxComment
            // 
            this.txtBxComment.Location = new System.Drawing.Point(21, 552);
            this.txtBxComment.Name = "txtBxComment";
            this.txtBxComment.Size = new System.Drawing.Size(1089, 290);
            this.txtBxComment.TabIndex = 1;
            this.txtBxComment.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // btnEditComment
            // 
            this.btnEditComment.Location = new System.Drawing.Point(149, 860);
            this.btnEditComment.Name = "btnEditComment";
            this.btnEditComment.Size = new System.Drawing.Size(109, 57);
            this.btnEditComment.TabIndex = 3;
            this.btnEditComment.Text = "Edit";
            this.btnEditComment.UseVisualStyleBackColor = true;
            this.btnEditComment.Click += new System.EventHandler(this.btnEditComment_Click);
            // 
            // btnNewComment
            // 
            this.btnNewComment.Location = new System.Drawing.Point(12, 860);
            this.btnNewComment.Name = "btnNewComment";
            this.btnNewComment.Size = new System.Drawing.Size(109, 57);
            this.btnNewComment.TabIndex = 3;
            this.btnNewComment.Text = "New";
            this.btnNewComment.UseVisualStyleBackColor = true;
            this.btnNewComment.Click += new System.EventHandler(this.btnNewComment_Click);
            // 
            // btnDeleteComment
            // 
            this.btnDeleteComment.Location = new System.Drawing.Point(278, 860);
            this.btnDeleteComment.Name = "btnDeleteComment";
            this.btnDeleteComment.Size = new System.Drawing.Size(109, 57);
            this.btnDeleteComment.TabIndex = 3;
            this.btnDeleteComment.Text = "Delete";
            this.btnDeleteComment.UseVisualStyleBackColor = true;
            this.btnDeleteComment.Click += new System.EventHandler(this.btnDeleteComment_Click);
            // 
            // CommentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 929);
            this.Controls.Add(this.btnNewComment);
            this.Controls.Add(this.btnDeleteComment);
            this.Controls.Add(this.btnEditComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBxComment);
            this.Controls.Add(this.lstBxComments);
            this.Name = "CommentForm";
            this.Text = "CommentForm";
            this.Load += new System.EventHandler(this.CommentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBxComments;
        private System.Windows.Forms.RichTextBox txtBxComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditComment;
        private System.Windows.Forms.Button btnNewComment;
        private System.Windows.Forms.Button btnDeleteComment;
    }
}