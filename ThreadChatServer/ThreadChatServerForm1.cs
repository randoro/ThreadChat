using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadChatServer
{
    public partial class ThreadChatServerForm1 : Form
    {
        private TcpListener listener;
        private Socket socket;
        private List<User> users;

        private delegate void Displayer(string message);


        /// <summary>
        /// Form Constructor
        /// </summary>
        public ThreadChatServerForm1()
        {
            InitializeComponent();
            users = new List<User>();

            
        }

        /// <summary>
        /// Called when form is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreadChatServerForm1_Load(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(Setup);
        }

        /// <summary>
        /// Listener setup, called by the first threadpool thread.
        /// </summary>
        /// <param name="obj"></param>
        public void Setup(object obj)
        {
            string ip = "127.0.0.1";
            int port = 50000;
            listener = new TcpListener(IPAddress.Parse(ip), port);
            listener.Start();
            DisplayMessage("Server listening on " + ip + ":" + port);
            
            while (true)
            {
                Socket tempSock = listener.AcceptSocket();
                DisplayMessage("New User connected.");
                User newUser = new User(tempSock, this);
                users.Add(newUser);
                ThreadPool.QueueUserWorkItem(newUser.Run);
                DisplayMessage("User assigned thread from threadpool. Keeps listening..");
            }
        }


        /// <summary>
        /// Displays a message at the end of servers RichTextBox.
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


        /// <summary>
        /// Event called on form closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThreadChatServerForm1_Closing(object sender, CancelEventArgs e)
        {
            // Display a MsgBox asking the user.
            if (MessageBox.Show("Close server application?", "ThreadChatServer",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Cancel the Closing event from closing the form.
                e.Cancel = true;
            }
        }


        /// <summary>
        /// Called on "Send To All" buttonClick. Sends message to all connected clients.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendAllButton1_Click(object sender, EventArgs e)
        {
            string message = sendTextBox1.Text;

            for (int i = users.Count; i-- > 0; )
            {

                if (!(users[i].connection.Connected))
                {
                    users.RemoveAt(i);
                }
                else
                {
                    users[i].SendMessage(message);
                }
            }

            if (message.Length > 10)
            {
                string shortString = sendTextBox1.Text.Substring(0, 10);
                DisplayMessage("Sending responseMessage '" + shortString + "..' to all (" + users.Count +
                               ") connected clients.");
            }
            else
            {
                DisplayMessage("Sending responseMessage '" + message + "' to all (" + users.Count +
                               ") connected clients.");
            }

            
        }

    }
}
