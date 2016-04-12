using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace ThreadChat
{
    class Client
    {
        private ThreadChatForm1 form;
        private TcpClient client;
        private NetworkStream cIntStream;
        private BinaryReader reader;
        private BinaryWriter writer;


        public Client(ThreadChatForm1 form)
        {
            this.form = form;
        }


        public void Run(object obj)
        {
            try
            {
                client = new TcpClient("127.0.0.1", 50000);
                cIntStream = client.GetStream();
                reader = new BinaryReader(cIntStream);
                writer = new BinaryWriter(cIntStream);
                while (true)
                {
                    
                }
            }
            catch (Exception e)
            {

            }

        }

        public void SendMessage(string message)
        {
            //var chars = message.ToCharArray();
            //writer.Write(chars.Length);
            writer.Write(message);
        }



    }
}
