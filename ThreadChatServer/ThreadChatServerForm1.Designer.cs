namespace ThreadChatServer
{
    partial class ThreadChatServerForm1
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
            this.sendAllButton1 = new System.Windows.Forms.Button();
            this.sendTextBox1 = new System.Windows.Forms.TextBox();
            this.chatRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.userListBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sendAllButton1
            // 
            this.sendAllButton1.Location = new System.Drawing.Point(555, 13);
            this.sendAllButton1.Name = "sendAllButton1";
            this.sendAllButton1.Size = new System.Drawing.Size(104, 23);
            this.sendAllButton1.TabIndex = 0;
            this.sendAllButton1.Text = "Send To All";
            this.sendAllButton1.UseVisualStyleBackColor = true;
            this.sendAllButton1.Click += new System.EventHandler(this.sendAllButton1_Click);
            // 
            // sendTextBox1
            // 
            this.sendTextBox1.Location = new System.Drawing.Point(13, 13);
            this.sendTextBox1.Name = "sendTextBox1";
            this.sendTextBox1.Size = new System.Drawing.Size(535, 20);
            this.sendTextBox1.TabIndex = 1;
            // 
            // chatRichTextBox1
            // 
            this.chatRichTextBox1.Location = new System.Drawing.Point(13, 40);
            this.chatRichTextBox1.Name = "chatRichTextBox1";
            this.chatRichTextBox1.Size = new System.Drawing.Size(535, 385);
            this.chatRichTextBox1.TabIndex = 2;
            this.chatRichTextBox1.Text = "";
            // 
            // userListBox1
            // 
            this.userListBox1.FormattingEnabled = true;
            this.userListBox1.Location = new System.Drawing.Point(555, 40);
            this.userListBox1.Name = "userListBox1";
            this.userListBox1.Size = new System.Drawing.Size(104, 381);
            this.userListBox1.TabIndex = 3;
            // 
            // ThreadChatServerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 437);
            this.Controls.Add(this.userListBox1);
            this.Controls.Add(this.chatRichTextBox1);
            this.Controls.Add(this.sendTextBox1);
            this.Controls.Add(this.sendAllButton1);
            this.Name = "ThreadChatServerForm1";
            this.Text = "ThreadChat Server";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ThreadChatServerForm1_Closing);
            this.Load += new System.EventHandler(this.ThreadChatServerForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendAllButton1;
        private System.Windows.Forms.TextBox sendTextBox1;
        private System.Windows.Forms.RichTextBox chatRichTextBox1;
        private System.Windows.Forms.ListBox userListBox1;
    }
}

