using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxNum
{
    class Program
    {
        static int Min(List<int> numList)
        {
            var sortList = numList.OrderBy(num => num);
            return sortList.First();
        }
        static int Max(List<int> numList)
        {
            var sortList = numList.OrderByDescending(num => num);
            return sortList.First();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество:");
            int amount = int.Parse(Console.ReadLine());
            List<int> num = new List<int>();
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine($"Введите {i + 1} элемент:");
                num.Add(int.Parse(Console.ReadLine()));
            }
            int minNum = Min(num);
            int maxNum = Max(num);
            Console.WriteLine($"Минимальный элемент: {minNum}\nМаксимальный элемент: {maxNum}");
            Console.ReadKey();
        }
    }
}
