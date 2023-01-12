using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace math
{
    public class Kernel : Sys.Kernel
    {
        Double ddd = 0.00;
        mmath m = new mmath();
        Double dddd = 0.00;
        protected override void BeforeRun()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("add math...");
        }

        protected override void Run()
        {
            Console.Write("Input: ");
            var input = Console.ReadLine();
            Console.Write("Text typed: ");
            dddd = 0.00;
            try
            {

                dddd= Double.Parse(input);

            }
            catch (Exception e)
            {
                dddd = 0.00;
            }
            ddd = m.adds(ddd , dddd);
            Console.WriteLine();
        }
    }
}
