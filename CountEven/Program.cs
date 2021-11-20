using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountEven
{
    internal class Program
    {
        static void Main(string[] args)

        /*4.Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
         * Определить количество   нечетных положительных элементов, стоящих на четных местах.
        */
        {
            int[] array = new int[20];
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i+=2)
            {
                if ((array[i] % 2) > 0) count++;
            }
            Console.WriteLine();
            
            Console.WriteLine("Количество нечетных положительных элементов на четных местах = {0}", count);

            Console.ReadLine();
        }
    }
}
