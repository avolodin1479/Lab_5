using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = random.Next(-50, 50);
                Console.Write("{0}  ", a[i]);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i+1; j < 5; j++)
                {
                    if (a[i]>a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                 }
            }
            Console.WriteLine();

            for (int i = 5; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
            


            Console.ReadKey();
        }
    }
}
