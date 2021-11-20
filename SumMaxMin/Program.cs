

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMaxMin
{
    internal class Program
    {
        /*2. Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
         * Определить сумму максимального и минимального элементов массива.*/
        static void Main(string[] args)
        {
            int[] array = new int [15];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {

                    int t = array[i];
                    if (array[i] < array[j])
                    {
                        array[i] = array[j];
                        array[j] = t;
                    }

                }
                //Console.Write("{0} ", array[i]);
            }
            Console.WriteLine( );        
            Console.WriteLine("Максимальный элемент {0}",array[0]);
            Console.WriteLine("Минимальный элемент {0}", array.Last());
            Console.WriteLine("Сумма максимального и минимального элементов {0}", array[0]+array.Last());

            Console.ReadLine();
        }
    }
}
