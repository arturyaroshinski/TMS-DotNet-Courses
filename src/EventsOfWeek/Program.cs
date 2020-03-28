using System;

namespace EventsOfWeek
{
    class Program
    {
        enum Week
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7,
        }
        static string[] arrayWithEvents = new string[7];
        static void Main(string[] args)
        {
                Menu();
        }
        static void Menu()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Menu: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[1] Add event.\n[2] View events.\n[3] Delete event.\n[4] Quit app.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Select option by writing its number.");
                string userInput = Console.ReadLine();
                SelectDay();
            }
        }
        static void SelectDay()
        {
            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "mon":
                case "monday":
                case "1":
                    Console.WriteLine("U choose monday.");
                    AddEvent(Week.Monday);
                    break;
                case "tue":
                case "tuesday":
                case "2":
                    Console.WriteLine("U choose tuesday.");
                    AddEvent(Week.Tuesday);
                    break;
                case "wed":
                case "wednesday":
                case "3":
                    Console.WriteLine("U choose wednesday.");
                    AddEvent(Week.Wednesday);
                    break;
                case "thu":
                case "thurday":
                case "4":
                    Console.WriteLine("U choose thursday.");
                    AddEvent(Week.Thursday);
                    break;
                case "fri":
                case "friday":
                case "5":
                    Console.WriteLine("U choose friday.");
                    AddEvent(Week.Friday);
                    break;
                case "sat":
                case "saturday":
                case "6":
                    Console.WriteLine("U choose saturday.");
                    AddEvent(Week.Saturday);
                    break;
                case "sun":
                case "sunday":
                case "7":
                    Console.WriteLine("U choose sunday.");
                    AddEvent(Week.Sunday);
                    break;
                default:
                    Console.WriteLine("Invalid input, try again.");
                    SelectDay();
                    break;
                    
            }
        }
        static void AddEvent(Week day)
        {
            if (string.IsNullOrWhiteSpace(arrayWithEvents[(int)day - 1]))
            {
                Console.Write("Input event:");
                arrayWithEvents[(int)day - 1] = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("U already have event at this day: " + arrayWithEvents[(int)day - 1]);
            }
        }
    }
}

