using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postOfficeQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите время работы почтового отделения (в минутах): ");
            int minutes = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите общее количество клиентов в очереди ");
            int queueSize = int.Parse(Console.ReadLine());
            Queue<int> time = new Queue<int>();
            for (int i = 0; i < queueSize; i++)
            {
                Console.WriteLine($"Сколько нужно минут обслуживания клиенту №{i + 1}? ");
                int queue_minutes = int.Parse(Console.ReadLine());
                if (minutes > 0)
                {
                    minutes -= queue_minutes;
                    time.Enqueue(queue_minutes);
                }
            }
            Console.WriteLine($"Возможно обслужить клиентов: {time.Count}");
            Console.Write($"Почта не успела обслужить {queueSize - time.Count} посетителей ");

            Console.ReadKey();
        }

    }
}