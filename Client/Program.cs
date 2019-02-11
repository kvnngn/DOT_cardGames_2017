using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetworkCommsDotNet;

namespace ClientApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Tape your message :");
                string msg = Console.ReadLine();
                Console.WriteLine("Sending message to server saying '" + msg + "'");
                NetworkComms.SendObject("Message", "127.0.0.1", 4242, msg);
                if (Console.ReadKey(true).Key == ConsoleKey.Q) break;
            }
            NetworkComms.Shutdown();
        }
    }
}