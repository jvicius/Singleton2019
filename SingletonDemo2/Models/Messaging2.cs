using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDemo2.Models
{
    public class Messaging2 : IMessaging
    {
        private static Messaging2 _instance = null;
        private Messaging2()
        {
            Console.WriteLine("New Instance");
        }

        public static Messaging2 Instance
        {
            get
            {
                if (_instance==null)
                    _instance = new Messaging2();
                return _instance;
            }
        }
        public void ShowMessage(string message)
        {
            //Console.WriteLine(message);
            var fileName = "c:/temp/testfile.txt";
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true))
            {
                writer.Write(message);
                writer.Flush();
            }
        }
    }
}
