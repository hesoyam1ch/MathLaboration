using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLaborationFirst
{
    public  abstract class ThirdLabortion //За формулою методу Ейлера
    {
        public static void Result()
        {
            double x0 = 0.5;
            double y0 = 0.6;
            double xEnd = 1.5;
            double h = 0.1;

            double x = x0;
            double y = y0;

            while (x <= xEnd)
            {
                Console.WriteLine($"x = {x}, y = {y}");

                double dy = h * (x + Math.Cos(y) / Math.Sqrt(7)); // Обчислюємо зміну y

                y += dy; // Оновлюємо значення y

                x += h; // Переходимо до наступної точки

            }
        }
   
    }
}
