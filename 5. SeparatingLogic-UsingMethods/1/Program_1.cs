using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        /// <summary>
        /// Возвращает матрицу умноженную на число
        /// </summary>
        /// <param name="number">Число на которое будет умножаться матрица</param>
        /// <param name="x">Ширина матрицы</param>
        /// <param name="y">Высота матрицы</param>
        static void MatrixXNumber (int number, int x, int y)
        {
            int[,] matrix = new int[x, y];                                                      //матрица
            int maxMatrix = 0;                                                                  //максимальное значение
            Random rnd = new Random();                                                          //генератор рандома

            //Наполняем матрицу
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    int temp = rnd.Next(0, 100);
                    matrix[i, j] = temp;
                    if (maxMatrix < temp)                                                       //находим максимальное значение
                        maxMatrix = temp;
                }
            }

            maxMatrix = (maxMatrix * number).ToString().Length;                                 //максимальная длина числа

            for (int i = 0; i < x; i++)
            {
                string row = "";                                                                //наполнем строку
                string rowRes = "";                                                             //наполнем строку результата
                if (i == x / 2)
                    row += number + " x | ";
                else
                    row += row.PadLeft(number.ToString().Length + 2, ' ') + " | ";
                for (int j = 0; j < y; j++)
                {
                    row += (matrix[i, j]).ToString().PadLeft(maxMatrix, ' ') + " ";
                    rowRes += (number * matrix[i, j]).ToString().PadLeft(maxMatrix, ' ') + " ";
                }
                if (i == x / 2)
                    row += "| = ";
                else
                    row += "|   ";
                Console.WriteLine($"{row}| {rowRes}|");
            }
        }

        /// <summary>
        /// Сумма матриц
        /// </summary>
        /// <param name="x">Ширина матрицы</param>
        /// <param name="y">Высота матрицы</param>
        static void SumMatrix (int x, int y)
        {
            int[,] matrix1 = new int[x, y];                                                     //матрица 1
            int[,] matrix2 = new int[x, y];                                                     //матрица 2
            int maxMatrix1 = 0;                                                                 //максимальное значение 1 матрицы
            int minMatrix1 = 0;                                                                 //минимательное значение 1 матрицы
            int maxMatrix2 = 0;                                                                 //максимальное значение 2 матрицы
            int maxTotal = 0;                                                                   //максимальное значение результата
            Random rnd = new Random();                                                          //генератор рандома

            //Наполняем матрицы
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    //Первая матрица
                    int temp = rnd.Next(0, 150);
                    matrix1[i, j] = temp;
                    if (maxMatrix1 < temp)                                                      //находим максимальное значение
                        maxMatrix1 = temp;
                    if (minMatrix1 > temp)
                        minMatrix1 = temp;                                                      //находим минимальное значение
                    //Вторая матрица
                    temp = rnd.Next(0, 150);
                    matrix2[i, j] = temp;
                    if (maxMatrix2 < temp)                                                      //находим максимальное значение
                        maxMatrix2 = temp;
                }
            }

            int maxM1 = (maxMatrix1).ToString().Length;                                         //максимальная длина 1 матрицы
            int maxM2 = (maxMatrix2).ToString().Length;                                         //максимальная длина 2 матрицы

            void result(int sign)
            {
                maxTotal = (sign > 0)
                    ? (maxMatrix1 + maxMatrix2).ToString().Length
                    : (minMatrix1 - maxMatrix2).ToString().Length;                              //макс. длина результата
                string textSign = (sign > 0) ? "+" : "-";
                for (int i = 0; i < x; i++)
                {
                    string rowM1 = "| ";                                                        //наполнем строку для 1 матрицы
                    string rowM2 = "| ";                                                        //наполнем строку для 2 матрицы
                    string rowRes = "";                                                         //наполнем строку результата

                    for (int j = 0; j < y; j++)
                    {
                        rowM1 += (matrix1[i, j]).ToString().PadLeft(maxM1, ' ') + " ";
                        rowM2 += (matrix2[i, j]).ToString().PadLeft(maxM2, ' ') + " ";
                        rowRes += (matrix1[i, j] + sign * matrix2[i, j]).ToString().PadLeft(maxTotal, ' ') + " ";
                    }

                    if (i == x / 2)
                        Console.WriteLine($"{rowM1}| {textSign} {rowM2}| = | {rowRes}|");
                    else
                        Console.WriteLine($"{rowM1}|   {rowM2}|   | {rowRes}|");
                }
            }

            result(1);
            Console.WriteLine();
            result(-1);
        }

        /// <summary>
        /// Произведение двух матриц
        /// </summary>
        /// <param name="x1">Ширина первой матрицы</param>
        /// <param name="y1">Высота первой матрицы</param>
        /// <param name="x2">Ширина второй матрицы</param>
        /// <param name="y2">Высота второй матрицы</param>
        static void MatrixMult (int x1, int y1, int x2, int y2)
        {
            void output(int x, int y, int maxM, int[,] matrix)
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

            if (y1 != x2)
            {
                Console.WriteLine("Вы ввели не верную размерность матрицы!\r\n" +
                    "Количество колонок первой и строк второй матрицы должны совпадать, попробуйте ещё раз");
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

            maxTotal = 3;                                                                       //макс. длина результата
            int maxM1 = (maxMatrix1).ToString().Length;                                         //максимальная длина 1 матрицы
            int maxM2 = (maxMatrix2).ToString().Length;                                         //максимальная длина 2

            Console.WriteLine("Произведение матрицы:");
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
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Матрица умноженная на число");
            MatrixXNumber(5,3,4);
            Console.WriteLine("\r\nСложение и вычитание матриц");
            SumMatrix(5,7);
            Console.WriteLine();
            MatrixMult(3,4,4,5);

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
