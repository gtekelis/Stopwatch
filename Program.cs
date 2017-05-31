using System;

namespace stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stopwatch");
            Console.WriteLine("Type 'str' to start, then type 'stp' to stop");

            var watch = new StopwatchCls();


            while (true)
            {
                var input = Console.ReadLine();
                switch (input)
                {
                    case "str":
                        {
                            watch.StartFun();
                            break;
                        }
                    case "stp":
                        {
                            watch.StopFun();
                            break;
                        }
                    case "exit":
                        {
                            System.Console.WriteLine($"Thank you for using stopwatch");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            System.Console.WriteLine("not valid input");
                            break;
                        }
                }
            }

        }
    }
}