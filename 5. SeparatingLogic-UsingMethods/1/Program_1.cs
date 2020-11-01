using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1
{
    class Program
    {
        /// <summary>
        /// Вывод матрицы
        /// </summary>
        /// <param name="matrix"></param>
        static void PrintMatrix (int[,] matrix)
        {
            if (matrix != null)
            {
                int maxMatrix = matrix.Cast<int>().Max();                                           //максимальное значение
                maxMatrix = (maxMatrix).ToString().Length;                                          //максимальная длина числа

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    Console.Write("| ");
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        Console.Write(matrix[i, j].ToString().PadLeft(maxMatrix) + " ");
                    }
                    Console.WriteLine("|");
                }
            }
        }

        /// <summary>
        /// Функция умножения матрицы на число
        /// </summary>
        /// <param name="number">Множитель матрицы</param>
        /// <param name="matrix">Принимаемая матрица</param>
        /// <returns>Матрица умноженная на число</returns>
        static int[,] MatrixXNumber (int number, int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result[i,j] = number * matrix[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// Функция сложения матриц
        /// </summary>
        /// <param name="matrix1">Первая матрица</param>
        /// <param name="matrix2">Вторая матрица</param>
        /// <returns>Сумма двух матриц</returns>
        static int[,] SumMatrix (int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i,j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }


        static int[,] MatrixMult (int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                Console.WriteLine("Вы ввели не верную размерность матрицы!\r\n" +
                    "Количество колонок первой и строк второй матрицы должны совпадать, попробуйте ещё раз");
                return null;
            }

            int resX = matrix1.GetLength(0);
            int resY = matrix2.GetLength(1);

            int[,] result = new int[resX, resY];                                                //произведение матриц

            for (int i = 0; i < resX; i++)
            {
                for (int j = 0; j < resY; j++)
                {
                    for (int xM = 0; xM < matrix1.GetLength(1); xM++)
                    {
                        {
                            result[i, j] += matrix1[i, xM] * matrix2[xM, j];
                        }
                    }
                }
            }
            return result;
        }

        static int[,] transposition (int[,] matrix)
        {
            int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result[i, j] = matrix[j, i];
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            //Начальные данные
            int[,] matrix1 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };

            int[,] matrix2 =
            {
                { 2, 3, 4 },
                { 5, 6, 7 }
            };

            int number = 5;

            Console.WriteLine("Первая матрица");
            PrintMatrix(matrix1);

            Console.WriteLine("Вторая матрица");
            PrintMatrix(matrix2);

            Console.WriteLine("Множитель: " + number);

            Console.WriteLine("\r\nПервая матрица умноженная на число");
            PrintMatrix(MatrixXNumber(number, matrix1));

            Console.WriteLine("\r\nСложение матриц");
            PrintMatrix(SumMatrix(matrix1, matrix2));

            Console.WriteLine("\r\nПроизведение матриц");
            Console.WriteLine("\r\nСперва транспонируем вторую матрицу");
            matrix2 = transposition(matrix2);
            PrintMatrix(matrix2);
            Console.WriteLine();
            PrintMatrix(MatrixMult(matrix1, matrix2));

            Console.ReadKey();
        }
    }
}

#region
// Домашнее задание
// Требуется написать несколько методов
//
// Задание 1.
// Воспользовавшись решением задания 3 четвертого модуля
// 1.1. Создать метод, принимающий число и матрицу, возвращающий матрицу умноженную на число
// 1.2. Создать метод, принимающий две матрицу, возвращающий их сумму
// 1.3. Создать метод, принимающий две матрицу, возвращающий их произведение
//
#endregion
