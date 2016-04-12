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
        private Socket connection;
        private NetworkStream netwStream;
        private BinaryReader reader;
        private string response;
        private BinaryWriter writer;

        public User(Socket socket, ThreadChatServerForm1 form)
        {
            this.connection = socket;
            this.form = form;
        }

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
                    form.DisplayMessage(str);
                }
            }
            catch (Exception e)
            {

            }
        }

        public void SendMessage(string message)
        {
            
        }

    }
}
