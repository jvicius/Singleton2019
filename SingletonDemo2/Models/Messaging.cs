using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace SingletonDemo2.Models
{
    public class Messaging : IMessaging
    {
        public Messaging()
        {
            Console.WriteLine("New Instance");
        }
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
