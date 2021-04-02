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
            do
            {
                Console.WriteLine("Введите время работы почтового отделения (в минутах): ");
                int minutes = int.Parse(Console.ReadLine());
                if (minutes < 0)
                {
                    Console.WriteLine("Введено отрицательное время работы! Нажмите любую кнопку, чтобы закрыть программу.. ");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Введите общее количество посетителей в очереди ");
                int queueSize = int.Parse(Console.ReadLine());
                Queue<int> visitors = new Queue<int>();
                for (int i = 0; i < queueSize; i++)
                {
                    Console.WriteLine($"Сколько нужно минут обслуживания посетителю №{i + 1}? ");
                    int queue_minutes = int.Parse(Console.ReadLine());
                    visitors.Enqueue(queue_minutes);
                }
                do
                {
                    minutes = minutes - visitors.Dequeue();
                    if (visitors.Count == 0)
                    {
                        break;
                    }
                }
                while (minutes > 0);

                switch (visitors.Count)
                {
                    case 0:
                        Console.WriteLine("Все посетители ушли с посылками.");
                        break;
                    default:
                        Console.WriteLine($"{visitors.Count} - столько посетителей осталось без посылок.");
                        break;
                }
            } while (true);
        }


    }
}