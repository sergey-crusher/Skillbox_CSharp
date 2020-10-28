using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Количество колонок");
            int y = int.Parse(Console.ReadLine());                                              //размерность по Y //3
            Console.WriteLine("Количество строк");
            int x = int.Parse(Console.ReadLine());                                              //размерность по X //3
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

            //maxTotal = (maxMatrix1 + maxMatrix2).ToString().Length;                           //макс. длина результата
            int maxM1 = (maxMatrix1).ToString().Length;                                         //максимальная длина 1 матрицы
            int maxM2 = (maxMatrix2).ToString().Length;                                         //максимальная длина 2 матрицы

            void result (int sign)
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
                        rowRes += (matrix1[i, j] + sign*matrix2[i, j]).ToString().PadLeft(maxTotal, ' ') + " ";
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
            Console.ReadKey();
        }
    }
}

#region
//
// ** Задание 3.2
// Заказчику требуется приложение позволяющщее складывать и вычитать математические матрицы
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Сложение_матриц
// Добавить возможность ввода количество строк и столцов матрицы.
// Матрицы заполняются автоматически
// Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
//
// Пример
//  |  1  3  5  |   |  1  3  4  |   |  2   6   9  |
//  |  4  5  7  | + |  2  5  6  | = |  6  10  13  |
//  |  5  3  1  |   |  3  6  7  |   |  8   9   8  |
//  
//  
//  |  1  3  5  |   |  1  3  4  |   |  0   0   1  |
//  |  4  5  7  | - |  2  5  6  | = |  2   0   1  |
//  |  5  3  1  |   |  3  6  7  |   |  2  -3  -6  |
//
#endregion