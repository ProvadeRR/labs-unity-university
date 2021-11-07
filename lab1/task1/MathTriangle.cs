using System;

namespace lab1.task1
{
    class MathTriangle
    {
        public static double getGypotenuse(Triangle triangle)
        {
            double sumCathenus = getSumCathenus(triangle.getCathenusFirst(), triangle.getCathenusSecond());
            return Math.Sqrt(sumCathenus);
        }

        private static double getSumCathenus(double first, double second)
        {
            return Math.Pow(first, 2) + Math.Pow(second, 2);
        }
    }
}
