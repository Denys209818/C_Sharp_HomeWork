using System;

namespace MyProgram6
{
    class Program
    {
        static void Main()
        {
//            . Разработать собственный структурный тип данных
//для хранения целочисленных коэффициентов A и B
//линейного уравнения A×X + B×Y = 0.в классе реализовать статический метод Parse(), которые принимает
//строку со значениями коэффициентов, разделенных
//запятой или пробелом.
            Koefitient k = new Koefitient();
            k.Parse("12 132");
            k.ShowResult();

            //            2.Разработать метод для решения системы 2 линейных
            //уравнений:
            //A1×X + B1×Y = 0
            //A2×X + B2×Y = 0
            //Метод с помощью выходных параметров должен
            //возвращать найденное решение или ошибку, если
            //решения не существует.
            //Y = 0
            k.GetResultSystem(12, 12, 32, 1);
            //X = 0
            k.GetResultSystem(14, 122, 32, 32);


        }
    }

    struct Koefitient 
    {
        int A;
        int B;

        public void Parse(string str)
        {
            string[] strings = str.Split(" ");
            try
            {
                A = int.Parse(strings[0]);
                B = int.Parse(strings[1]);
            } 
            catch (Exception ex) 
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        public void ShowResult() 
        {
            Console.WriteLine($"A: {this.A}");
            Console.WriteLine($"B: {this.B}");
        }

        public int GetResultSystem(int a1, int a2, int b1, int b2) 
        {
            if (a1 != a2 && b2 != b1) 
            {
                throw new Exception("Error!");
            }


            if (a1 == a2)
            {
                int res = b1 - b2;
                Console.WriteLine("B: " + res + " Y: 0");
                return res;
            }
            else 
            {
                int res = a1 - a2;
                Console.WriteLine("A: " + res + " X: 0");
                return res;
            }
            
        }
    }
}
