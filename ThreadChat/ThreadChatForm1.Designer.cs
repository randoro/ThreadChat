namespace ThreadChat
{
    partial class ThreadChatForm1
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
            this.btnSend = new System.Windows.Forms.Button();
            this.sendMessageBox1 = new System.Windows.Forms.TextBox();
            this.chatRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(372, 13);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // sendMessageBox1
            // 
            this.sendMessageBox1.Location = new System.Drawing.Point(13, 13);
            this.sendMessageBox1.Name = "sendMessageBox1";
            this.sendMessageBox1.Size = new System.Drawing.Size(353, 20);
            this.sendMessageBox1.TabIndex = 1;
            // 
            // chatRichTextBox1
            // 
            this.chatRichTextBox1.Location = new System.Drawing.Point(13, 47);
            this.chatRichTextBox1.Name = "chatRichTextBox1";
            this.chatRichTextBox1.Size = new System.Drawing.Size(434, 283);
            this.chatRichTextBox1.TabIndex = 2;
            this.chatRichTextBox1.Text = "";
            // 
            // ThreadChatForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 342);
            this.Controls.Add(this.chatRichTextBox1);
            this.Controls.Add(this.sendMessageBox1);
            this.Controls.Add(this.btnSend);
            this.Name = "ThreadChatForm1";
            this.Text = "ThreadChat Client";
            this.Closing += new System.ComponentModel.CancelEventHandler(this.ThreadChatForm1_Closing);
            this.Load += new System.EventHandler(this.ThreadChatForm1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox sendMessageBox1;
        private System.Windows.Forms.RichTextBox chatRichTextBox1;
    }
}

