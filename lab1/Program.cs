using System;

using lab1.task1;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(2, 3);
            Console.WriteLine(MathTriangle.getGypotenuse(triangle));
            Console.WriteLine(task2());
            Console.WriteLine(task3());
        }


        private static double task2()
        {
            double x = 2, s = 1, a = 1, b = 1, p = 1, c;
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                p = -p;         //(-1)^n
                a *= x * x;     //x^2n
                b *= 2 * i;     //(2n)!
                c = p * a / b;  //значение текущего члена прогрессии.
                s += c;
            }
            return s;
        }


        private static double task3()
        {

            double x = 3;
            int e = 8;
            int i = 2;
            double element = Math.Pow(x, i) * (1 - x);
            double Summa = 0;

            while (element > e)
            {
                Summa += element;
                element = Math.Pow(x, i + 1) * (1 - x);
                i++;
            }
            return Summa;
        }
    }
}
