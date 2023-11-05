using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть значення x, y та z:");

        if (double.TryParse(Console.ReadLine(), out double x) &&
            double.TryParse(Console.ReadLine(), out double y) &&
            double.TryParse(Console.ReadLine(), out double z))
        {
            double r = y + Math.Pow(x - 1, 1.0 / 3.0);
            if (x >= 1 && x + z != 0 && r >= 0)
            {
                double s = Math.Log(x) * Math.Pow(r, 1.0 / 4.0) / (2 * Math.Abs(x + z));
                int rounding_numbers = 4;
                double Result = Math.Round(s, rounding_numbers);
                Console.WriteLine($"Відповідь: {Result}");
            }
            else
            {
                Console.WriteLine("Розв'язку немає.");
            }
        }
        else
        {
            Console.WriteLine("Помилка при вводі, введіть правильні значення.");
        }
    }
}

