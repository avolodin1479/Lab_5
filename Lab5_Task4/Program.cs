using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[20];
            Random random = new Random();
            for (int i = 0; i < 20; i++)
            {
                a[i] = random.Next(-50, 50);
                Console.Write("{0}  ", a[i]);
            }
            int K = 0;
            for (int i = 1; i < 20; i+=2)
            {

                if (a[i]>0 && a[i]%2 ==1)
                {
                    K = K + 1;
                  }
                
            }
            Console.WriteLine();
            Console.WriteLine("Количество нечетных положительных элементов на четных местах {0}",K);
            Console.ReadKey();
        }
    }
}
