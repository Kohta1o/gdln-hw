using System;
using System.Collections.Generic;

namespace fileFormats
{
    class Program
    {
        static public string[] MenuStrings =
        {
             "1 - Вывод списка формата",
             "2 - Добавить новый формат",
             "3 - Удалить формат из списка",
             "4 - Поиск формата",
             "5 - Выйти",
        };
        static public void PrintMenu()
        {
            Console.Clear();
            foreach (var menuString in MenuStrings)
            {
                Console.WriteLine(menuString);
            }
        }
        static public void PrintList(Dictionary<string, string> format)
        {
            Console.Clear();
            if (format.Count == 0)
            {
                Console.WriteLine("Список пуст.");
            }
            else
            {
                foreach (KeyValuePair<string, string> elem in format)
                {
                    Console.WriteLine("* Короткое описание - {0},\nПолное описание - {1}", elem.Key, elem.Value);
                }
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
        static public void GetElem(Dictionary<string, string> format)
        {
            Console.Clear();
            Console.Write("Введите короткое описание формата: ");
            string shortDescription = Console.ReadLine();
            while (shortDescription.Trim() == "")
            {
                Console.Write("Введите формат заново: ");
                shortDescription = Console.ReadLine();
            }
            Console.Write("Введите полное описание формата: ");
            string fullDescription = Console.ReadLine();
            if (fullDescription.Trim() == "")
            {
                Console.Write("Введите формат заново ");
                fullDescription = Console.ReadLine();
            }
            else
            {
                format.Add(shortDescription, fullDescription);
            }
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
        static public void RemoveElem(Dictionary<string, string> format)
        {
            Console.Clear();
            Console.Write("Введите короткое описание формата который хотите удалить: ");
            string shortDescription = Console.ReadLine();
            if (shortDescription.Trim() != "")
            {
                if (format.Remove(shortDescription))
                {
                    Console.Write("Формат удален!");
                }
                else
                {
                    Console.Write("Формат введен неверно");
                }
            }
            else
            {
                Console.WriteLine("Введите формат заново");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
        static public void SearchElem(Dictionary<string, string> format)
        {
            Console.Clear();
            Console.Write("Введите короткое описание формата: ");
            string shortDescription = Console.ReadLine();
            if (shortDescription.Trim() != "")
            {
                if (format.ContainsKey(shortDescription))
                {
                    Console.Write(format[shortDescription]);
                }
                else
                {
                    Console.Write("Формат введен неверно");
                }
            }
            else
            {
                Console.WriteLine("Введите формат заново");
            }
            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу, чтобы вернуться в главное меню");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> Format = new Dictionary<string, string>();
            Format.Add(".ppt", "PowerPoint Presentation");
            Format.Add(".apk", "Android Package File");
            Format.Add(".fb2", "FictionBook 2.0 File");
            Format.Add(".xsl", "Excel Spreadsheet");
            Format.Add(".doc", "Microsoft Word Document");
            foreach (KeyValuePair<string, string> kvp in Format)
            {
                Console.WriteLine("Короткое описание = {0}, Полное описание = {1}", kvp.Key, kvp.Value);
            }
            ConsoleKey key = ConsoleKey.Enter;
            do
            {
                PrintMenu();
                key = Console.ReadKey().Key;
                switch (key)
                {
                    case ConsoleKey.D1:
                        PrintList(Format);
                        break;
                    case ConsoleKey.D2:
                        GetElem(Format);
                        break;
                    case ConsoleKey.D3:
                        RemoveElem(Format);
                        break;
                    case ConsoleKey.D4:
                        SearchElem(Format);
                        break;
                    default: continue;
                }
            } while (key != ConsoleKey.D5);
        }
    }
}
