using System;

namespace BankLib
{
    public class Bank
    {
        /// <summary>
        /// Меню банкомата.
        /// </summary>
        /// <param name="client">Клиент.</param>
        public static void Menu(Client client)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Menu: ");
                Console.WriteLine("[1] Put money.\n[2] Take money.\n[3] Check balance.\n[4] Quit app.");
                Console.ResetColor();
                Console.WriteLine("Choose option by writing its number.");

                string menuOption = Console.ReadLine();

                switch (menuOption)
                {
                    case "1":
                        Console.WriteLine("Enter amout:");
                        decimal.TryParse(Console.ReadLine(), out decimal putMoney);
                        client.Put(putMoney);
                        break;
                    case "2":
                        Console.WriteLine("Enter amount");
                        decimal.TryParse(Console.ReadLine(), out decimal takeMoney);
                        client.Put(takeMoney);
                        break;
                    case "3":
                        client.Balance();
                        break;
                    case "4":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, try again.");
                        break;
                }
            }
        }
    }
}
