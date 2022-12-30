using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace sums
{
    public class Kernel : Sys.Kernel
    {
        Double d = 0.0;

        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("sum calculator...");
            
        }

        protected override void Run()
        {
            Console.Write("to Sum: ");
            var input = Console.ReadLine();
            try
            {
                d = d + Double.Parse(input.ToString());
                Console.WriteLine(d);
            }
            catch (Exception e)
            {
                d = 0.00;
                Console.WriteLine(d);
            }
            
        }
    }
}
