using System;

namespace QuadraticEquationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Обчислення коренів квадратного рівняння");
            Console.Write("Введіть значення a: ");
            if (double.TryParse(Console.ReadLine(), out double a))
            {
                Console.Write("Введіть значення b: ");
                if (double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.Write("Введіть значення c: ");
                    if (double.TryParse(Console.ReadLine(), out double c))
                    {
                        double d = b * b - 4 * a * c;

                        if (d > 0)
                        {
                            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                            Console.WriteLine($"Дискримінант: {d}, розв'язки: x1 = {x1}, x2 = {x2}");
                        }
                        else if (d == 0)
                        {
                            double x = -b / (2 * a);
                            Console.WriteLine($"Дискримінант: {d}, розв'язок: x = {x}");
                        }
                        else
                        {
                            Console.WriteLine($"Дискримінант: {d}, розв'язків немає.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Помилка введення c.");
                    }
                }
                else
                {
                    Console.WriteLine("Помилка введення b.");
                }
            }
            else
            {
                Console.WriteLine("Помилка введення a.");
            }
        }
    }
}

