using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLaborationFirst
{
    public abstract class FirstLaboration
    {
        static double Function(double x)
        {
            // Визначення функції
            return x * x * x - 0.1 * x * x + 0.4 * x - 1.5;
        }

        static double Derivative(double x)
        {
            // Визначення похідної функції
            return 3 * x * x - 0.2 * x + 0.4;
        }

        static double NextApproximation(double x)
        {
            // Розрахунок наступного наближення з використанням формули методу дотичних
            return x - Function(x) / Derivative(x);
        }

        public  static void Result()
        {
            double x0 = 1.0;  // Початкове наближення

            double x = x0;
            double nextX = NextApproximation(x0);

            // Виконуємо ітерації методу дотичних до отримання задовільно точного кореня
            while (Math.Abs(nextX - x) >= 0.0001)
            {
                x = nextX;
                nextX = NextApproximation(x);
            }

            Console.WriteLine("Result: x = " + nextX);
        }
    }
}
