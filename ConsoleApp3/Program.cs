using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Обчислення сум:");
        Console.WriteLine("1) сума 1^n + 2^(n/2) + ... + k^(n/k);");
        Console.WriteLine("2) сума 1^k + 2^k + ... + n^k;");
        Console.WriteLine("3) сума 1/n + 2/(n^2) + 3/(n^3) + ... + k/(n^k);");

        Console.Write("Виберіть, яку суму бажаєте обчислити: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Введіть n: ");
                    if (int.TryParse(Console.ReadLine(), out int n1))
                    {
                        Console.Write("Введіть k: ");
                        if (int.TryParse(Console.ReadLine(), out int k1))
                        {
                            double sum1 = 0;
                            for (int i = 1; i <= k1; i++)
                            {
                                sum1 += Math.Pow(i, 1.0 / n1);
                            }
                            Console.WriteLine($"Результат: {sum1}");
                        }
                        else
                        {
                            Console.WriteLine("Некоректне значення k.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некоректне значення n.");
                    }
                    break;

                case 2:
                    Console.Write("Введіть k: ");
                    if (int.TryParse(Console.ReadLine(), out int k2))
                    {
                        Console.Write("Введіть n: ");
                        if (int.TryParse(Console.ReadLine(), out int n2))
                        {
                            double sum2 = 0;
                            for (int i = 1; i <= n2; i++)
                            {
                                sum2 += Math.Pow(i, k2);
                            }
                            Console.WriteLine($"Результат: {sum2}");
                        }
                        else
                        {
                            Console.WriteLine("Некоректне значення n.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некоректне значення k.");
                    }
                    break;

                case 3:
                    Console.Write("Введіть n: ");
                    if (int.TryParse(Console.ReadLine(), out int n3))
                    {
                        Console.Write("Введіть k: ");
                        if (int.TryParse(Console.ReadLine(), out int k3))
                        {
                            double sum3 = 0;
                            for (int i = 1; i <= k3; i++)
                            {
                                sum3 += i / Math.Pow(n3, i);
                            }
                            Console.WriteLine($"Результат: {sum3}");
                        }
                        else
                        {
                            Console.WriteLine("Некоректне значення k.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некоректне значення n.");
                    }
                    break;

                default:
                    Console.WriteLine("Немає такого варіанту.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Помилка вводу.");
        }
    }
}
