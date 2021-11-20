/*Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры,
 * определить среднее арифметическое элементов.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int [] array=new int[7];
            float S = 0;
            //Random random = new Random();   
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
               // Console.Write(array[i]);
                S += array[i];

            }
            Console.WriteLine();
            float average=S/array.Length;
            Console.WriteLine("Среднее арифметическое массива = {0:f2}",average);    

            Console.ReadKey();
        }
    }
}
