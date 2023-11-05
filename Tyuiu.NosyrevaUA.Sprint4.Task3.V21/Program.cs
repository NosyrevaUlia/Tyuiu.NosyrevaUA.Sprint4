using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosyrevaUA.Sprint4.Task3.V21.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task3.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5] { { 8, 3, 3, 3, 5 }, { 6, 7, 3, 3, 7 }, { 4, 5, 4, 6, 6 }, { 5, 5, 8, 8, 7 }, { 4, 6, 6, 7, 7 } };
            int rows = array.GetUpperBound(0);
            int col = array.Length / rows;
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Носырева Ю. А.| ИИПб-23-3 ";
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнила: Носырева Юлия Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 8. Найдите произведение     *");
            Console.WriteLine("* элементов в последнем столбце массива.                                  *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for(int i = 0; i <= rows; i++)
            {
                for (int j = 0; j <= rows; j++)
                {
                    Console.Write($"{array[i, j]}");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);

            Console.WriteLine("Произведение элементов последнего столбца массива: " + res);
            Console.ReadKey();

        }
    }
}
