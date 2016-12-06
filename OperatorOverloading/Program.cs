using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Fraction frac1 = new Fraction(-10 , 2);
            Fraction frac2 = new Fraction(1 , 7);
            frac1.PrintFraction();
            frac2.PrintFraction();
            Console.WriteLine((string)frac1 + " + " + (string)frac2 +" = "+ (string)(frac1+=frac2));
            Console.WriteLine((string)frac1 + " - " + (string)frac2 + " = " + (string)(frac1 -= frac2));
            Console.WriteLine((string)frac1 + " * " + (string)frac2 + " = " + (string)(frac1 *= frac2));
            Console.WriteLine((string)frac1 + " / " + (string)frac2 + " = " + (string)(frac1 /= frac2));
            if (frac1 > frac2) Console.WriteLine((string)frac1 + " > " + (string)frac2);
            else Console.WriteLine((string)frac1 + " < " + (string)frac2);
            if (frac2 >= frac1) Console.WriteLine((string)frac2 + " >= " + (string)frac1);
            else Console.WriteLine((string)frac2 + " <= " + (string)frac1);
            if (frac1 == frac2) Console.WriteLine((string)frac1 + " == " + (string)frac2);
            else Console.WriteLine((string)frac1 + " != " + (string)frac2);
            if (frac2) Console.WriteLine((string)frac2 + " додатній");
            else Console.WriteLine((string)frac2 + " від'ємний");
        }
    }
}
