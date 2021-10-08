using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int s = i + j;
                    if (s % 2 == 0)
                    {
                        a[i, j] = 1;

                    }

                    else
                    {
                        a[i, j] = 0;

                    }

                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();

            }



            Console.ReadKey();
        }
    }
}
