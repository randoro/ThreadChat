using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ThreadChatServer
{
    class User
    {
        private ThreadChatServerForm1 form;
        public Socket connection { get; private set; }
        private NetworkStream netwStream;
        private BinaryReader reader;
        private BinaryWriter writer;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="socket"></param>
        /// <param name="form"></param>
        public User(Socket socket, ThreadChatServerForm1 form)
        {
            this.connection = socket;
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
                netwStream = new NetworkStream(connection);
                reader = new BinaryReader(netwStream);
                writer = new BinaryWriter(netwStream);
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
        /// Sends a message to a specific clients networkstream.
        /// </summary>
        /// <param name="message"></param>
        public void SendMessage(string message)
        {
            writer.Write(message);
        }

    }
}
