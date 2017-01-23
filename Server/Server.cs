using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using System.Net;

namespace Server
{
    class Server
    {
        BinaryFormatter formater = new BinaryFormatter();
        Socket soket;
        NetworkStream tok;

        public void pokreniserver()
        {
            soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket.Bind(new IPEndPoint(IPAddress.Any, 11000));
            Console.WriteLine("Server je uspesno startovan!");
            obradiKlijenta();
        }

        private void obradiKlijenta()
        {
            soket.Listen(5);
            while (true)
            {
                Socket klijent = soket.Accept();
                tok = new NetworkStream(klijent);
                NitKlijenta nit = new NitKlijenta(tok);
            }
        }
        static void Main(string[] args)
        {
            Server server = new Server();
            server.pokreniserver();
            Console.ReadLine();
        }
    }
}
