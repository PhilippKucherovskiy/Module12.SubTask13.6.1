
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Загрузка текстового файла
        string textFilePath = "Text1.txt";
        List<string> lines = new List<string>();
        using (StreamReader reader = new StreamReader(textFilePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
        }

        // Создание List<T>
        List<string> list = new List<string>();

        Stopwatch stopwatch = Stopwatch.StartNew();

        // Вставка в List<T>
        foreach (string line in lines)
        {
            list.Add(line);
        }

        stopwatch.Stop();

        Console.WriteLine($"List<T> insertion time: {stopwatch.Elapsed}");

        // Создание LinkedList<T>
        LinkedList<string> linkedList = new LinkedList<string>();

        stopwatch = Stopwatch.StartNew();

        // Вставка в LinkedList<T>
        foreach (string line in lines)
        {
            linkedList.AddLast(line);
        }

        stopwatch.Stop();

        Console.WriteLine($"LinkedList<T> insertion time: {stopwatch.Elapsed}");
    }
}

