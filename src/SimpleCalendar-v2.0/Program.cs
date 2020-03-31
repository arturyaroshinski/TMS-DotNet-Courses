using System;
using System.Collections.Generic;

namespace SimpleCalendar_v2._0
{
    class Program
    {
        static List<UserEvent> eventsList = new List<UserEvent>();
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            while (true)
            {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[1] Add event.\n[2] View all events.\n[3] Clear console.\n[4] Quit app.");
            Console.ResetColor();
            Console.WriteLine("Choose option by writing its number.");
            string menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "1":
                        AddEvent();
                        break;
                    case "2":
                        ViewEvents();
                        break;
                    case "3":
                        Console.Clear();
                        break;
                    case "4":
                        Console.WriteLine("See u next time.");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, try again.");
                        Menu();
                        break;
                }
            }
        }
        static DateTime GetDate()
        {
            Console.WriteLine("Input date.");
            while (true)
            {
                Console.WriteLine("Use format: 'yyyy.mm.dd'.");
                try
                {
                    DateTime userInput = DateTime.Parse(Console.ReadLine());
                    return userInput;
                }
                catch (FormatException) { Console.WriteLine("Invalid format, try again"); }
                catch (Exception)
                {
                    throw new Exception("Some exception");
                }
            }
        }
        static void AddEvent()
        {
            UserEvent userEvent = new UserEvent();
            userEvent.DateOfEvent = GetDate();
            Console.Write("Enter ur event at this day: ");
            userEvent.Name = Console.ReadLine();
            eventsList.Add(userEvent);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Event successfully added\n");
        }
        static void ViewEvents()
        {   
            if (eventsList.Count >= 1)
            {
                Console.WriteLine("Ur events: ");
                foreach (var item in eventsList)
                { 
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("{0:D}: {1}.", item.DateOfEvent, item.Name);
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You dont have events yet.");
            }
        }
    }
}
