using System;

namespace roseOfWind
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0, rg = 1;
            char choice;
            while (rg <= 10)
            {
                Console.WriteLine("Введите направление (С,Ю,З,В): ");
                choice = char.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 'С':
                    case 'с':
                        y++;
                        Console.WriteLine($"Сделано {rg} шага (Север)");
                        rg += 1;
                        break;
                    case 'Ю':
                    case 'ю':
                        y--;
                        Console.WriteLine($"Сделано {rg} шага (Юг)");
                        rg += 1;
                        break;
                    case 'З':
                    case 'з':
                        x--;
                        Console.WriteLine($"Сделано {rg} шага (Запад)");
                        rg += 1;
                        break;
                    case 'В':
                    case 'в':
                        x++;
                        Console.WriteLine($"Сделано {rg} шага (Восток)");
                        rg += 1;
                        break;
                    default:
                        Console.WriteLine("Что это?");
                        break;
                }
            }
            double result = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            Console.WriteLine($"Пройдено {result} м");
            Console.ReadKey();
        }
    }
}
