using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject8
{
    class Fraction
    {
        private int chyselnyk;
        private int znamennyk;

        public Fraction(int chyselnyk, int znamennyk)
        {
            this.chyselnyk = chyselnyk;
            this.znamennyk = znamennyk;
        }

        public Fraction()
        {
            this.chyselnyk = 0;
            this.znamennyk = 0;
        }


        public static Fraction operator +(Fraction f1, Fraction f2) 
        {
            return new Fraction(f1.chyselnyk + f2.chyselnyk, f1.znamennyk + f2.znamennyk);
        }

        public static Fraction operator +(Fraction f1, double f2)
        {
            return new Fraction(f1.chyselnyk + (int)f2, f1.znamennyk + (int)f2);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.chyselnyk - f2.chyselnyk, f1.znamennyk - f2.znamennyk);
        }

        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.chyselnyk * f2.chyselnyk, f1.znamennyk * f2.znamennyk);
        }

        public static Fraction operator *(Fraction f1, int num)
        {
            return new Fraction(f1.chyselnyk * num, f1.znamennyk * num);
        }

        public static Fraction operator *(int num, Fraction f1)
        {
            return new Fraction(f1.chyselnyk * num, f1.znamennyk * num);
        }

        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.chyselnyk / f2.chyselnyk, f1.znamennyk / f2.znamennyk);
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return (f1.chyselnyk / f1.znamennyk) == (f2.chyselnyk / f2.znamennyk);
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }

        public static bool operator <(Fraction f1, Fraction f2)
        {
            return (f1.chyselnyk / f1.znamennyk) < (f2.chyselnyk / f2.znamennyk);
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return !(f1 < f2);
        }

        public static bool operator true(Fraction f)
        {
            if (f.chyselnyk < f.znamennyk) return true;
            return false;
        }

        public static bool operator false(Fraction f)
        {
            if (f) return false;
            return true;
        }
    }
}
