using System;

namespace MyProject8
{
    class Program
    {
        static void Main()
        {
            Fraction f = new Fraction(3, 4);
            int a = 10;
            Fraction f1 = f * a;
            Fraction f2 = a * f;
            double d = 1.5;
            Fraction f3 = f + d;
        }
    }
}
