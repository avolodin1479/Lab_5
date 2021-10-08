using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] a = new double[7];
            double sum = 0;

            Console.WriteLine("Введите 7 элементов массива ");
            for (int i = 0; i < 7; i++)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
                sum += a[i];
            }


            double aM = sum / 7;
            Console.WriteLine("Среднее арифметическое значение равно {0}", aM);
            Console.ReadKey();
            }
    }
}
