using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace differentArrayNumbers
{
    class Program
    {
        static void Main(string[] args) // O(n) - линейная сложность 
        {
            while (true)
            {
            int[] array; int size;
            Console.WriteLine("Введите размер массива: ");
            size = int.Parse(Console.ReadLine());
            array = new int[size]; // Размерность
            Console.WriteLine($"Массив содержит {size} элемента(ов). Теперь заполните массив.");
            for (int numbers = 0; numbers < size; numbers++) // Заполнение
            {
                Console.WriteLine($"Введите {numbers+1}-й элемент:");
                array[numbers] = int.Parse(Console.ReadLine());
            }
            for (int numbers = 0; numbers < size; numbers++) // Вывод
            {
                Console.Write(array[numbers]);
            }
            int result = array.Distinct().Count(); // Подсчет
            Console.WriteLine($"\nКоличество различных чисел: {result}");
            }

        }
    }
}