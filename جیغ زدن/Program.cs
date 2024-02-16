using System;
namespace Quera
{
    public class Program
    {
        static void Main(string[] args)
        {
            int d, s = 1;
            var result = 2;

            var n = Convert.ToInt32(Console.ReadLine());
            if (n != 1) result++;

            Console.WriteLine(result);
        }
    }
}