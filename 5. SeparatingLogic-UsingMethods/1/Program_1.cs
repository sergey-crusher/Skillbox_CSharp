using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

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
        /// <returns>Возвращает матрицу умноженную на число</returns>
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


        /// <summary>
        /// Произведение двух матриц
        /// </summary>
        /// <param name="matrix1">Двумерная матрица первого множителя</param>
        /// <param name="matrix2">Двумерная матрица второго множителя</param>
        /// <returns>Возвращает результат произведения двух матриц</returns>
        static int[,] MatrixMult (int[,] matrix1, int[,] matrix2)
        {
            if (matrix1.GetLength(1) != matrix2.GetLength(0))
            {
                throw new Exception("Количество колонок первой и строк второй матрицы должны совпадать, попробуйте ещё раз");
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

        /// <summary>
        /// Транспонирование матрицы
        /// </summary>
        /// <param name="matrix">Двумерная матрица</param>
        /// <returns>Возвращает транспонированную матрицу</returns>
        static int[,] Transposition (int[,] matrix)
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

        /// <summary>
        /// Заполнение матрицы случайными значениями
        /// </summary>
        /// <param name="matrix">Двумерная матрица</param>
        /// <returns></returns>
        static int[,] MatrixFilling (int[,] matrix)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int[,] result = new int[matrix.GetLength(1), matrix.GetLength(0)];

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    result[i, j] = rnd.Next(0,100);
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            //Начальные данные
            int x, y = 0;

            int[,] matrix1;
            int[,] matrix2;

            int number = 0;

            while (true)
            {
                Console.WriteLine("Выберите один из варинтов:\r\n" +
                    "1 - Произведение матрицы на число\r\n" +
                    "2 - Сложение матриц\r\n" +
                    "3 - Произведение матриц");
                string answer = Console.ReadLine();

                while (true)
                {
                    //Произведение матрицы на число
                    if (answer == "1")
                    {
                        Console.WriteLine("Вы выбрали произведение матрицы на число\r\n" +
                            "Введите ширину матрицы:");
                        int.TryParse(Console.ReadLine(), out x);

                        Console.WriteLine("Введите высоту матрицы:");
                        int.TryParse(Console.ReadLine(), out y);
                        if (y <= 0 || x <= 0)
                        {
                            Console.WriteLine("Размерность матрицы не должна быть меньше 1х1, введите корректные данные");
                            continue;
                        }
                        Console.WriteLine("Введите множитель матрицы:");
                        int.TryParse(Console.ReadLine(), out number);

                        matrix1 = new int[y, x];
                        matrix1 = MatrixFilling(matrix1);

                        Console.WriteLine("Произведение матрицы:");
                        PrintMatrix(matrix1);
                        Console.WriteLine("На число:");
                        Console.WriteLine(number);
                        Console.WriteLine("Результат:");
                        PrintMatrix(MatrixXNumber(number, matrix1));
                        break;
                    }
                    //Сложение матриц
                    if (answer == "2")
                    {
                        Console.WriteLine("Вы выбрали произведение сложение матриц\r\n" +
                            "Введите ширину для матриц:");
                        int.TryParse(Console.ReadLine(), out x);

                        Console.WriteLine("Введите высоту для матриц:");
                        int.TryParse(Console.ReadLine(), out y);
                        if (y <= 0 || x <= 0)
                        {
                            Console.WriteLine("Размерность матрицы не должна быть меньше 1х1, введите корректные данные");
                            continue;
                        }

                        matrix1 = new int[y, x];
                        matrix1 = MatrixFilling(matrix1);

                        matrix2 = new int[y, x];
                        matrix2 = MatrixFilling(matrix2);

                        Console.WriteLine("Первое слагаемое:");
                        PrintMatrix(matrix1);
                        Console.WriteLine("Второе слагаемое:");
                        PrintMatrix(matrix2);
                        Console.WriteLine("Результат:");
                        PrintMatrix(SumMatrix(matrix1, matrix2));
                        break;
                    }
                    //Произведение матриц
                    if (answer == "3")
                    {
                        Console.WriteLine("Вы выбрали сложение матриц\r\n" +
                                "Введите ширину ПЕРВОЙ матрицы:");
                        int.TryParse(Console.ReadLine(), out x);

                        Console.WriteLine("Введите высоту ПЕРВОЙ матрицы:");
                        int.TryParse(Console.ReadLine(), out y);
                        if (y <= 0 || x <= 0)
                        {
                            Console.WriteLine("Размерность матрицы не должна быть меньше 1х1, введите корректные данные");
                            continue;
                        }

                        matrix1 = new int[y, x];
                        matrix1 = MatrixFilling(matrix1);

                        Console.WriteLine("Введите ширину ВТОРОЙ матрицы:");
                        int.TryParse(Console.ReadLine(), out x);

                        Console.WriteLine("Введите высоту ВТОРОЙ матрицы:");
                        int.TryParse(Console.ReadLine(), out y);
                        if (y <= 0 || x <= 0)
                        {
                            Console.WriteLine("Размерность матрицы не должна быть меньше 1х1, введите корректные данные");
                            continue;
                        }

                        matrix2 = new int[y, x];
                        matrix2 = MatrixFilling(matrix2);
                        try
                        {
                            Console.WriteLine("Произведение матрицы:");
                            PrintMatrix(matrix1);
                            Console.WriteLine("На матрицу:");
                            PrintMatrix(matrix2);
                            Console.WriteLine("Результат:");
                            PrintMatrix(MatrixMult(matrix1, matrix2));
                        }
                        catch (Exception e)
                        {
                            if (e.Message == "Количество колонок первой и строк второй матрицы должны совпадать, попробуйте ещё раз")
                            {
                                Console.WriteLine(e.Message);
                                continue;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Выберите один из трёх вариантов");
                        break;
                    }
                }
                Console.WriteLine("Если хотите продолжить, нажмите любую клавишу...");

                Console.ReadKey();
            }
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
