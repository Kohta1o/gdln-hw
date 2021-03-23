using System;

namespace symmetricTwoDimensionalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] array; int size; int index = 0;
            Console.WriteLine("Введите размер массива: ");
            size = int.Parse(Console.ReadLine());
            array = new int[size, size]; // Размерность
            int numbers = (int)size * size;
            Console.Write($"Введите {numbers} элементов (через пробел): ");
            int[] temp = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse); // Ввод 
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++, index++)
                {
                    array[row, column] = temp[index];
                }
            }
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    if (array[row, column] == array[column, row]) continue;
                    Console.WriteLine("Матрица не симметрична");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Матрица симметрична");
            Console.ReadKey();
        }
    }
}
