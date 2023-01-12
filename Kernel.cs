using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace CosmosKernel13
{

public class Kernel : Sys.Kernel
    {
        double dd = 0.00;
        double ddd = 0.00;
        double dddd = 0.00;
    protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("Add calculator.");
            
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            try
            {
                ddd = double.Parse(input);
            }
            catch
            {
                ddd = 0.00;
            }
            dd = MathImpl.ADDS(dd, ddd);
            Console.WriteLine();
        }
    }
}
