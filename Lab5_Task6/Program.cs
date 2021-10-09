using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[N, N];
            double M = (N * (Math.Pow(N, 2)+1))/2;
            Console.WriteLine();

            Console.WriteLine("Заполните массив");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("i{0}  j{1}", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0,4} ", a[i, j]);
                }
                Console.WriteLine();
            }

            int b = 0;
            
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    b += a[i, j];
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            if ((b / N) == M)
            {
                Console.WriteLine("Квадрат является магическим");
            }
            else
            {
                Console.WriteLine("Квадрат не является магическим");
            }
            Console.ReadKey();



        }
    }
}
