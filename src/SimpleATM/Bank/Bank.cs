using System;

namespace BankLib
{
    public static class Bank
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
                        client.Put(EnterAmout());
                        break;
                    case "2":
                        client.Take(EnterAmout());
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
        /// <summary>
        /// Ввод суммы.
        /// </summary>
        /// <returns>Сумма.</returns>
        static private decimal EnterAmout()
        {
            Console.WriteLine("Enter amout:");
            if (decimal.TryParse(Console.ReadLine(), out decimal money))
                return money;
            else
            {
                return 0;
            }
        }
    }
}
