﻿using System;
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

        public ThreadChatServerForm1()
        {
            InitializeComponent();
            users = new List<User>();

            ThreadPool.QueueUserWorkItem(Setup);
        }


        public void Setup(object obj)
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 50000);
            listener.Start();
            while (true)
            {
                Socket tempSock = listener.AcceptSocket();
                User newUser = new User(tempSock, this);
                users.Add(newUser);
                ThreadPool.QueueUserWorkItem(newUser.Run);
            }
        }


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
