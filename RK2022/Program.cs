using System;

namespace RK2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // ax2 + bx + c = 0
            double a = 1, b = 2, c = -10;

            double delta = b * b - 4 * a * c;

            double x1 = (-b - Math.Sqrt(delta)) / 2 * a;
            double x2 = (-b + Math.Sqrt(delta)) / 2 * a;

            Console.WriteLine("x1={0} x2={1}", x1, x2);


        }
    }
}
