using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            int sum=0;
            for (int i = 0; i < 7; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                sum += array[i];
            }
            int S = sum / 7;
            Console.WriteLine("Среднее арифметическое чисел равно {0}", S);
            Console.ReadKey();
        }
    }
}