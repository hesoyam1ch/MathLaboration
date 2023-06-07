using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLaborationFirst
{
    public abstract class SecondLaboration
    {
        static double Function(double x)
        {
            // Визначення функції
            return Math.Cos(Math.Pow(x, 3) + 2 * Math.Pow(x, 2));
        }

        static double RectangleMethod(double a, double b, int n)
        {
            double h = (b - a) / n;  // Ширина підінтервалу
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double x = a + (i + 0.5) * h;  // Точка всередині підінтервалу
                sum += Function(x);
            }

            return sum * h;
        }

        public static void Result()
        {
            double a = 0.0;  // Початок інтервалу
            double b = 1.0;  // Кінець інтервалу
            int n1 = 10;     // Кількість підінтервалів для n = 10
            int n2 = 20;     // Кількість підінтервалів для n = 20

            double result1 = RectangleMethod(a, b, n1);
            double result2 = RectangleMethod(a, b, n2);

            Console.WriteLine("Результат для n = 10: " + result1);
            Console.WriteLine("Результат для n = 20: " + result2);
        }

    }
}
