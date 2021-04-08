using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctCountNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество элементов? ");
            int amount = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Введите {i + 1}-й элемент:");
                num.Add(int.Parse(Console.ReadLine()));
            }
            var distinct = num.Distinct();
            int result = distinct.Count();
            Console.WriteLine($"Количество разных чисел - {result}");
            Console.ReadKey();
        }
    }
}
