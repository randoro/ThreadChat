using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;
using System.Reflection;

namespace ThreadChat
{
    class Client
    {
        private ThreadChatForm1 form;
        public TcpClient client { get; private set; }
        private NetworkStream cIntStream;
        private BinaryReader reader;
        private BinaryWriter writer;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="form"></param>
        public Client(ThreadChatForm1 form)
        {
            this.form = form;
        }

        /// <summary>
        /// Loop method for threadpool thread.
        /// </summary>
        /// <param name="obj"></param>
        public void Run(object obj)
        {
            try
            {
                string ip = "127.0.0.1";
                int port = 50000;
                form.DisplayMessage("Connecting to server at  " + ip + ":" + port);
                client = new TcpClient(ip, port);
                cIntStream = client.GetStream();
                reader = new BinaryReader(cIntStream);
                writer = new BinaryWriter(cIntStream);
                while (true)
                {
                    String str = reader.ReadString();
                    form.DisplayMessage("Received: " + str);
                }
            }
            catch (Exception e)
            {
                form.DisplayMessage("Error, Connection lost.");
                //Do nothing
            }

        }


        /// <summary>
        /// Sends a message to the server through the networkstream.
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(string message)
        {
            writer.Write(message);
            form.DisplayMessage("Sent: " + message);

        }



    }
}
