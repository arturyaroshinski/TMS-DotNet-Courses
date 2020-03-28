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
                Console.WriteLine("Menu:");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[1] Add event.\n[2] View events.\n[3] Delete event.\n[4] Quit app.");
                Console.ResetColor();
                Console.WriteLine("Select option by writing its number.");
                string menuOption = Console.ReadLine();
                switch (menuOption)
                {
                    case "1":
                        AddEvent(SelectDay());
                        break;
                    case "2":
                        ViewEvents();
                        break;
                    case "3":
                        DeleteEvent();
                        break;
                    case "4":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid input, try again.");
                        Console.ResetColor();
                        break;
                }
            }
        }
        static Week SelectDay()
        {
            
            Console.WriteLine("You can select the day by entering its name or number.");
            Console.WriteLine("Example: 'Monday', 'mon', '1' (Remember that monday - 1, tuesday - 2, etc.).");
            string userInput = Console.ReadLine();
            switch (userInput.ToLower())
            {
                case "mon":
                case "monday":
                case "1":
                    return Week.Monday;
                case "tue":
                case "tuesday":
                case "2":
                    return Week.Tuesday;
                case "wed":
                case "wednesday":
                case "3":
                    return Week.Wednesday;
                case "thu":
                case "thurday":
                case "4":
                    return Week.Thursday;
                case "fri":
                case "friday":
                case "5":
                    return Week.Friday;
                case "sat":
                case "saturday":
                case "6":
                    return Week.Saturday;
                case "sun":
                case "sunday":
                case "7":
                    return Week.Sunday;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input, try again.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            return Week.Friday;
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
            Console.WriteLine();
        }
        static void ViewEvents()
        {
            // TODO: Add implementation.
        }
        static void DeleteEvent()
        {
            // TODO: add implementation
        }
    }
}

