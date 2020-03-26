﻿using System;

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
            while (true)
            {
                Console.WriteLine("Hello, dear friend.");
                Console.WriteLine("You can select the day by entering its name or number.");
                Console.WriteLine("Example: 'Monday', 'mon', '1' (Remember that monday - 1, tuesday - 2, etc.).");
                Console.WriteLine("Good luck!");
                Console.WriteLine("**************************************************************************");
                SelectDay();
                Console.WriteLine("Input 'q' for exit, any other input will restart app");
                if (Console.ReadLine().Equals("q"))
                {
                    return;
                }
                Console.Clear();
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
            if (string.IsNullOrWhiteSpace(arrayWithEvents[((int)day - 1)]))
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
