using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadChat
{
    public partial class ThreadChatForm1 : Form
    {
        private Client client;

        private delegate void Displayer(string message);


        /// <summary>
        /// Form Constructor
        /// </summary>
        public ThreadChatForm1()
        {
            InitializeComponent();

            client = new Client(this);


        }


        /// <summary>
        /// Called on "Send" buttonClick.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (client.client.Connected)
            {
                client.SendMessage(sendMessageBox1.Text);
            }
            else
            {
                MessageBox.Show("Failed to send message because you are no longer connected to server (Server down?).",
                    "Error",
                    MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Event called on form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreadChatForm1_Closing(object sender, CancelEventArgs e)
        {
            // Display a MsgBox asking the user.
            if (MessageBox.Show("Close chat application?", "ThreadChatClient",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Called when form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreadChatForm1_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(client.Run);
        }


        /// <summary>
        /// Displays a message at the end of clients RichTextBox.
        /// </summary>
        /// <param name="message"></param>
        public void DisplayMessage(string message)
        {
            if (chatRichTextBox1.InvokeRequired)
            {
                Displayer newMarker = new Displayer(DisplayMessage);
                chatRichTextBox1.Invoke(newMarker, new object[] { message });
            }
            else
            {
                chatRichTextBox1.Text += message + "\n";
            }

        }

    }
}
