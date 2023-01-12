using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[Plug(Target = typeof(global::MathImpl))]
public class MathImpl
{
    public static double ADDS(double value,double value2)
    {
        double valuet = value + value2;
        Console.Write(valuet.ToString());
            return valuet;
        
    }
}