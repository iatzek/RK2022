using System;

namespace RK2022
{
    class Program
    {
        static void Main(string[] args)
        {
            // ax2 + bx + c = 0
            double a, b, c;

            Console.WriteLine("ax^2+bx+c=0");
            Console.WriteLine("Podaj a");
            a = Double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b");
            b = Double.Parse(Console.ReadLine()); 
            Console.WriteLine("Podaj c");
            c = Double.Parse(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("x1={0} x2={1}", x1, x2);
            } 
            else if (delta == 0) 
            {
                Console.WriteLine("x1=x2={0}", (-b) / (2 * a));
            } 
            else
            {
                Console.WriteLine("brak rozwiązań");
            }            

        }
    }
}
