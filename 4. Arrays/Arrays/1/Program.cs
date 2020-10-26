using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1
{
    class Program
    {
        /// <summary>
        /// Класс финансового учёта
        /// </summary>
        public class accountingOfFunds
        {
            public float[] DT = new float[12];                                                  //Доход, тыс. руб.
            public float[] KT = new float[12];                                                  //Расход, тыс. руб.
            public float[] profit = new float[12];                                              //Прибыль, тыс. руб.
            public int profitable;
            /// <summary>
            /// Наполняем массив случайными значениями
            /// </summary>
            public void filling ()
            {
                profitable = 0;
                Random rnd = new Random();
                for (int i=0; i<DT.Length; i++)
                {
                    DT[i] = rnd.Next(50, 151)*1000;
                    KT[i] = rnd.Next(40, 101)*1000;
                    profit[i] = DT[i] - KT[i];
                    if (profit[i] > 0)
                        profitable++;
                }
            }
        }
        static void Main(string[] args)
        {
            //Объявляем заголовки
            string[] columnHeaders = new string[4] {
                "Месяц",
                "Доход, тыс. руб.",
                "Расход, тыс. руб.",
                "Прибыль, тыс. руб."
            };

            accountingOfFunds fin = new accountingOfFunds();                                    //Создаём экземпляр класса
            fin.filling();                                                                      //Наполняем случайными значениями
                                                                                                
            foreach (var item in columnHeaders)                                                 //Выводим заголовки
                Console.Write(item + "  ");  

            //Пробегаемся по массивам
            for (int i = 0; i < fin.DT.Length; i++)
            {
                /* 
                 * Возможно ли было как-то вывести что-то вроде
                 * Console.Write($"{0,columnHeaders[0].Length}", i+1);
                 * Чтобы вручную не считать количество символов или как можно по другому красиво вывести столбцы
                 */
                Console.WriteLine();
                Console.Write("{0,5}", i+1);
                Console.Write("{0,18}", fin.DT[i].ToString("### ###"));
                Console.Write("{0,19}", fin.KT[i].ToString("### ###"));
                fin.profit[i] = fin.DT[i] - fin.KT[i];
                if (fin.profit[i] == 0)
                    Console.Write("{0,20}","0");
                else
                    Console.Write("{0,20}", fin.profit[i].ToString("### ###"));
            }

            float[] threeWorst = new float[12];                                             //Создаём массив для трех наихудших значений
            Array.Copy(fin.profit, threeWorst, fin.profit.Length);                          //Копируем массив
            threeWorst = threeWorst.Distinct().ToArray();                                   //Удаляем дубли
            Array.Sort(threeWorst);                                                         //Сортируем по возрастанию

            string temp = "";                                               
            Console.Write($"\r\nХудшая прибыль в месяцах:");                                //Временная строка (чтобы обрезать лишний ",")
            for (int i=0; i < 3; i++)
            {
                for (int j=0; j< fin.profit.Length; j++)
                {
                    if (fin.profit[j] == threeWorst[i])
                    {
                        temp += $" {j + 1},";
                    }
                }
            }
            Console.WriteLine(temp.Substring(0,temp.Length-1));

            Console.WriteLine($"Месяцев с положительной прибылью: {fin.profitable}");

            Console.ReadKey();
        }
    }
}

#region
// Задание 1.
// Заказчик просит вас написать приложение по учёту финансов
// и продемонстрировать его работу.
// Суть задачи в следующем: 
// Руководство фирмы по 12 месяцам ведет учет расходов и поступлений средств. 
// За год получены два массива – расходов и поступлений.
// Определить прибыли по месяцам
// Количество месяцев с положительной прибылью.
// Добавить возможность вывода трех худших показателей по месяцам, с худшей прибылью, 
// если есть несколько месяцев, в некоторых худшая прибыль совпала - вывести их все.
// Организовать дружелюбный интерфейс взаимодействия и вывода данных на экран

// Пример
//       
// Месяц      Доход, тыс. руб.  Расход, тыс. руб.     Прибыль, тыс. руб.
//     1              100 000             80 000                 20 000
//     2              120 000             90 000                 30 000
//     3               80 000             70 000                 10 000
//     4               70 000             70 000                      0
//     5              100 000             80 000                 20 000
//     6              200 000            120 000                 80 000
//     7              130 000            140 000                -10 000
//     8              150 000             65 000                 85 000
//     9              190 000             90 000                100 000
//    10              110 000             70 000                 40 000
//    11              150 000            120 000                 30 000
//    12              100 000             80 000                 20 000
// 
// Худшая прибыль в месяцах: 7, 4, 1, 5, 12
// Месяцев с положительной прибылью: 10
#endregion
