using System;
using System.Collections.Generic;
namespace Quera
{
    public class Program
    {
        static void Main(string[] args)
        {
            var inputNumber = Convert.ToInt64(Console.ReadLine());
            var myList = splitDigits(inputNumber);

            long sum = 0;
            do
            {
                sum = 0;
                for (int i = 0; i < myList.Count; i++)
                {
                    sum += myList[i];
                }
                myList.Clear();
                myList = splitDigits(sum);
            } while (sum >= 10);

            Console.WriteLine(sum);
        }
        static List<long> splitDigits(long n)
        {
            var myList = new List<long>();
            while (n > 0)
            {
                myList.Add(n % 10);

                n /= 10;
            }
            myList.Reverse();
            return myList;
        }
    }
}