using System;

namespace AppleCounterNetCore
{
    class Program
    {
        class Apple
        {
            public double Calc(double apples, double price)
            {
                return apples * price;
            }
        }
    static void Main(string[] args)
    {
        // Command line dotnet application
        Apple cost = new Apple();
        
       try
            {
                double total = cost.Calc(Convert.ToInt32(args[0]), .25);

                if (args.Length > 0 && args.Length < 2)
                {
                    Console.WriteLine($"Cost of {args[0]} apple(s): ${total}");
                    Console.WriteLine("Press Enter to exit");
                    Console.ReadLine();
                }
                else if (args.Length > 1)
                {
                    Console.WriteLine("Please use one argument only. \nUsage: dotnet run 5");
                }
            }
            catch (IndexOutOfRangeException stopHere)
            {
                Console.WriteLine(stopHere.Message);
                throw new System.ArgumentOutOfRangeException("\n\nYou must use one argument.\nUsage: dotnet run 5\n\n", stopHere);
            }
        }            
    }
}
