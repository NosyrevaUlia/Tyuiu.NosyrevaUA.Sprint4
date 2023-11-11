using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosyrevaUA.Sprint4.Task4.V30.Lib;

namespace Tyuiu.NosyrevaUA.Sprint4.Task4.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнила: Носырева Ю. А.| ИИПб-23-3 ";
         
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнила: Носырева Юлия Алексеевна | ИИПб-23-3                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапазоне от 3 до 7. Заменить нечетные        *");
            Console.WriteLine("* элементы массива на 0.                                                  *");
            Console.WriteLine("* 3, 4, 6, 6, 5,                                                          *");
            Console.WriteLine("* 6, 7, 6, 3, 5,                                                          *");
            Console.WriteLine("* 5, 3, 5, 7, 6,                                                          *");
            Console.WriteLine("* 6, 4, 7, 6, 6,                                                          *");
            Console.WriteLine("* 7, 4, 3, 4, 5,                                                          * ");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов в массиве: ");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[rows, col];
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i<rows; i++)
            {
                for (int j = 0; j<col; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент массива: ");
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nМассив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{mat[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int[,] res = ds.Calculate(mat);

            Console.WriteLine("Измененный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{res[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
