using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace increase5decrease
{
    internal class Program
    {
        static void Main(string[] args)

        /*3. Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
         * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию*/
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0,4} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    int t = array[i];
                    if (array[i] > array[j])
                    {
                        array[i] = array[j];
                        array[j] = t;
                    }

                }
                Console.Write("{0,4} ", array[i]);
            }

            for (int i = 5; i <10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    int t = array[i];
                    if (array[i] < array[j])
                    {
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
                Console.Write("{0,4} ", array[i]);
            }         

            Console.ReadLine();

        }
    }
}
