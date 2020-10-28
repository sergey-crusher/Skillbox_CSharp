using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3
{
    class Program
    {
        /// <summary>
        /// Вывод матриц
        /// </summary>
        /// <param name="x">Ширина матрицы</param>
        /// <param name="y">Высота матрицы</param>
        /// <param name="maxM">Максимальное значение в матрице</param>
        /// <param name="matrix">Матрица</param>
        static void output(int x, int y, int maxM, int[,] matrix)
        {
            for (int i = 0; i < x; i++)
            {
                string row = "";
                for (int j = 0; j < y; j++)
                {
                    row += (matrix[i, j]).ToString().PadLeft(maxM, ' ') + " ";
                }
                Console.WriteLine($"| {row}|");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Первая матрица");
                Console.WriteLine("Количество строк");
                int x1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Количество колонок");
                int y1 = int.Parse(Console.ReadLine());                                     

                Console.WriteLine("Вторая матрица");
                Console.WriteLine("Количество строк");
                int x2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Количество колонок");
                int y2 = int.Parse(Console.ReadLine());

                if (y1 != x2)
                {
                    Console.WriteLine("Вы ввели не верную размерность матрицы!\r\n" +
                        "Количество колонок первой и строк второй матрицы должны совпадать, попробуйте ещё раз");
                    continue;
                }

                int resX = x1;
                int resY = y2;

                int[,] matrix1 = new int[x1, y1];                                                   //матрица 1
                int[,] matrix2 = new int[x2, y2];                                                   //матрица 2
                int[,] resMatrix = new int[resX, resY];                                             //произведение матриц

                int maxMatrix1 = 0;                                                                 //максимальное значение 1 матрицы
                int maxMatrix2 = 0;                                                                 //максимальное значение 2 матрицы
                int maxTotal = 0;                                                                   //максимальное значение результата
                Random rnd = new Random();                                                          //генератор рандома

                //Наполняем первую матрицу
                for (int i = 0; i < x1; i++)
                {
                    for (int j = 0; j < y1; j++)
                    {
                        int temp = rnd.Next(1, 11);
                        matrix1[i, j] = temp;
                        if (maxMatrix1 < temp)                                                      //находим максимальное значение
                            maxMatrix1 = temp;
                    }
                }

                //Наполняем вторую матрицу
                for (int i = 0; i < x2; i++)
                {
                    for (int j = 0; j < y2; j++)
                    {
                        int temp = rnd.Next(1, 11);
                        matrix2[i, j] = temp;
                        if (maxMatrix2 < temp)                                                      //находим максимальное значение
                            maxMatrix2 = temp;
                    }
                }

                maxTotal = 3;                             //макс. длина результата
                int maxM1 = (maxMatrix1).ToString().Length;                                         //максимальная длина 1 матрицы
                int maxM2 = (maxMatrix2).ToString().Length;                                         //максимальная длина 2

                Console.WriteLine("Произведение матриц:");
                output(x1, y1, maxM1, matrix1);
                Console.WriteLine("На матрицу:");
                output(x2, y2, maxM2, matrix2);
                Console.WriteLine("Результат:");

                for (int i = 0; i < resX; i++)
                {
                    string row = "";
                    for (int j = 0; j < resY; j++)
                    {
                        for (int xM = 0; xM < y1; xM++)
                        {
                            {
                                resMatrix[i, j] += matrix1[i, xM] * matrix2[xM, j];
                            }
                        }
                        row += resMatrix[i, j].ToString().PadLeft(maxTotal, ' ') + " ";
                    }
                    Console.WriteLine($"| {row}|");
                }

                Console.ReadKey();
                break;
            }
        }
    }
}

#region
// *** Задание 3.3
// Заказчику требуется приложение позволяющщее перемножать математические матрицы
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
// Добавить возможность ввода количество строк и столцов матрицы.
// Матрицы заполняются автоматически
// Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
//  
//  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
//  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
//  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
//
//  
//                  | 4 |   
//  |  1  2  3  | х | 5 | = | 32 |
//                  | 6 |  
//
#endregion
