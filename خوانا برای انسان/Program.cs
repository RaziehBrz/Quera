using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string result;
        var list = new List<int>();
        var t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }
        foreach (var m in list)
        {
            if (m < 1024) result = $"{m}B";
            else if (m >= 1024 && m < (1024 * 1024)) result = $"{(m / 1024)}KiB";
            else result = $"{m / (1024 * 1024)}MiB";
            Console.WriteLine(result);
        }
    }
}