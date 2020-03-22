using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstArgument, secondArgument;
                //user input first argument untill its valid
                Console.WriteLine("Input first argument: ");
                while (!double.TryParse(Console.ReadLine(), out firstArgument))
                {
                    Console.WriteLine("Invalid input, try again");
                }

                //user input second argument untill its valid
                Console.WriteLine("Input second argument: ");
                while (!double.TryParse(Console.ReadLine(), out secondArgument))
                {
                    Console.WriteLine("Invalid input, try again");
                }

                //user choose math operation
                Console.WriteLine("Choose math operation('+', '-', '*','/'): ");
                double result = 0; bool validOperation = false;
                while (!validOperation)
                {
                string mathOperation = Console.ReadLine();
                    switch (mathOperation)
                    {
                        case "+":
                            result = firstArgument + secondArgument;
                            validOperation = true;
                            break;
                        case "-":
                            result = firstArgument - secondArgument;
                            validOperation = true;
                            break;
                        case "*":
                            result = firstArgument * secondArgument;
                            validOperation = true;
                            break;
                        case "/":
                            if (secondArgument == 0)
                            {
                                // division by 0 exeption
                                Console.WriteLine("Division by 0 is not available, choose other operation: ");
                                break;
                            }
                            result = firstArgument / secondArgument;
                            validOperation = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input, try again");
                            break;
                    }
                }
                Console.WriteLine("Result is: " + result);
                // try again or quit
                Console.WriteLine("Input 'q' for exit, any other input will start app again");
                if (Console.ReadLine().Equals("q"))
                {
                    return;
                }
                Console.Clear();
            }
        }

    }
}
