using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                a[i] = random.Next(0, 50);
                Console.Write("{0}  ", a[i]);
            }
            int max = a[0];
            foreach (int b in a)
            {
                if (b > max)
                    max = b;
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное значение {0}", max);

            int min = a[0];
            foreach (int c in a)
            {
                if (c < min)
                    min = c;
            }
            Console.WriteLine();
            Console.WriteLine("Минимальное значение {0}", min);

            int d = min + max;
            Console.WriteLine("Сумма максимального и минимального значения = {0}", d);
            Console.ReadKey();

        }
    }
}
