using System;
using BankLib;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myClient = new Client("Tom", 300);
            // использование анонимного метода
            myClient.Notify += delegate (string message)
            {
                Console.WriteLine(message);
            };

            // Вызов меню банкомата
            Bank.Menu(myClient);
        }
    }
}
