﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadChat
{
    public partial class ThreadChatForm1 : Form
    {
        private Client client;

        public ThreadChatForm1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }


        private void ThreadChatForm1_Closing(object sender, CancelEventArgs e)
        {
            // Determine if text has changed in the textbox by comparing to original text.
            //if (textBox1.Text != strMyOriginalText)
            //{
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
            }

        private void ThreadChatForm1_Load(object sender, EventArgs e)
        {

        }

    }
}