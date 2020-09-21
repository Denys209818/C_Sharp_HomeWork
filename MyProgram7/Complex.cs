using System;
using System.Collections.Generic;
using System.Text;

namespace MyProgram7
{
    class Complex
    {
        private double num;
        public Complex(double num)
        {
            this.num = num;
        }

        public Complex()
        {
            this.num = 0;
        }

        public static Complex operator - (Complex c1, Complex c2) 
        {
            Complex cNew = new Complex(c1.num - c2.num);
            return cNew;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex cNew = new Complex(c1.num * c2.num);
            return cNew;
        }

        public static Complex operator -(Complex c1, int num)
        {
            Complex cNew = new Complex(c1.num - num);
            return cNew;
        }

        public static Complex operator *(int num1, Complex c2)
        {
            Complex cNew = new Complex(num1 * c2.num);
            return cNew;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex cNew = new Complex(c1.num / c2.num);
            return cNew;
        }

        public override string ToString()
        {
            return this.num.ToString();
        }
    }
}
