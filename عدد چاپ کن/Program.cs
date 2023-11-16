using System;
namespace Quera
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            foreach (var item in n)
            {
                Console.Write(item + ": ");
                var y = (int)item - 48;
                for (int i = 0; i < y; i++)
                {
                    Console.Write(y);
                }
                Console.WriteLine("\n");
            }
        }
    }
}