using System;
namespace Quera
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var m = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            if (n != m)
            {
                switch (n)
                {
                    case 1:
                        if (m == 2 || m == 3) result = 1;
                        else if (m == 4) result = 2;
                        break;
                    case 2:
                        if (m == 4 || m == 1) result = 1;
                        else if (m == 3) result = 2;
                        break;
                    case 3:
                        if (m == 1 || m == 4) result = 1;
                        else if (m == 2) result = 2;
                        break;
                    case 4:
                        if (m == 2 || m == 3) result = 1;
                        else if (m == 1) result = 2;
                        break;
                }
            }
            Console.WriteLine(result);
        }
    }
}