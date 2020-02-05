using System;
using SingletonDemo2.Models;

namespace SingletonDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance1 = Messaging2.Instance;
            var instance2 = Messaging2.Instance;

            instance1.ShowMessage("message 1");
            instance2.ShowMessage("message 2");
            Console.ReadKey();
        }
    }
}
