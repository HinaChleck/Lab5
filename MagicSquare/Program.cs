using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*6. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами,
             * вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
             * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.*/
            Console.WriteLine("Введите длину стороны квадрата");
            int n= Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n,n];
            int[] sumLineArray = new int[n];
            int[] sumColumnArray = new int[n];
            int sumDiag1 = 0;
            int sumDiag2 = 0;
            bool magic = false;
            #region ввод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            #endregion

            Console.Clear();
            #region Вывод массива в двумерном виде
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //array[i, j] = int.Convert.ToInt32(Console.ReadLine());
                    Console.Write("{0,4}",array[i,j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            #endregion

            #region сумма по главной диагоналям
            for (int i = 0; i < n; i++)
            {
                sumDiag1 = sumDiag1 + array[i, i];
            }
            Console.WriteLine("Сумма по главной диагонали {0,4}", sumDiag1);
            #endregion

            #region Сумма по побочной диагонали
            for (int i = 0; i < n; i++)
            {
                sumDiag2 = sumDiag2 + array[(n - i - 1), i];
            }
            Console.WriteLine("Сумма по побочной диагонали {0,4}", sumDiag2);
            #endregion

            #region сумма по строкам
            Console.WriteLine("Суммы по строкам");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sumLineArray[i] = sumLineArray[i] + array[i, j];
                }
            Console.WriteLine("{0,4}", sumLineArray[i]);
            }
            Console.WriteLine();
            #endregion

            #region сумма по столбцам
            Console.WriteLine("Суммы по столбцам");
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    sumColumnArray[j] = sumColumnArray[j] + array[i, j];
                }
                Console.Write("{0,4}", sumColumnArray[j]);
            }
            Console.WriteLine();
            #endregion

            Console.WriteLine();
            if (sumDiag1 == sumDiag2)
            {
                for (int i = 0; i < n; i++)
                {
                    if (sumColumnArray[i] != sumDiag1 || sumLineArray[i] != sumDiag1)
                    {
                        break;
                    }
                    else
                        magic = true;
                }
            }

            if (magic==true) Console.WriteLine("Магический квадрат!"); else Console.WriteLine("Ваш квадрат не магический(");
            
            Console.ReadKey();
        }
    }
}
