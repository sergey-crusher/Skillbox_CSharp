using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите множитель матрицы");
            int number = int.Parse(Console.ReadLine());                                         //множитель //5
            Console.WriteLine("Количество колонок");
            int y = int.Parse(Console.ReadLine());                                              //размерность по Y //3
            Console.WriteLine("Количество строк");
            int x = int.Parse(Console.ReadLine());                                              //размерность по X //3
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

            for (int i=0; i<x; i++)
            {
                string row = "";                                                                //наполнем строку
                string rowRes = "";                                                             //наполнем строку результата
                if (i == x / 2)
                    row += number + " x | ";
                else
                    row += row.PadLeft(number.ToString().Length + 2, ' ') + " | ";
                for (int j=0; j<y; j++)
                {
                    row += (matrix[i, j]).ToString().PadLeft(maxMatrix, ' ') + " ";
                    rowRes += (number * matrix[i, j]).ToString().PadLeft(maxMatrix, ' ') + " ";
                }
                if (i == x / 2)
                    row += "| = ";
                else
                    row += "|   ";
                Console.WriteLine($"{row}|{rowRes}|");
            }
            Console.ReadKey();
        }
    }
}

#region
// 
// * Задание 3.1
// Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
// Добавить возможность ввода количество строк и столцов матрицы и число,
// на которое будет производиться умножение.
// Матрицы заполняются автоматически. 
// Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
//
// Пример
//
//      |  1  3  5  |   |  5  15  25  |
//  5 х |  4  5  7  | = | 20  25  35  |
//      |  5  3  1  |   | 25  15   5  |
//
#endregion