using System;

namespace lab_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //3.4. Средний уровень
                for (double x = -1; x <= 3; x += 0.2)
                {
                    double y = 0;
                    if (x < 0) y = Math.Exp(-Math.Cos(3 * x));
                    else if (x > 1.5) y = x;
                    else y = 2 * Math.Pow(x, 2) * Math.Sqrt(Math.Abs(Math.Cos(2 * x)));
                    Console.WriteLine("|{0,13:F1}|{1,14:F2}|", x, y);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Введите корректно переменную");
            }
        }
    }
}