using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program_2
    {
        /// <summary>
        /// Вывод самого короткого слова
        /// </summary>
        /// <param name="str">Принимаемая строка</param>
        /// <returns></returns>
        static string MinChar (string str)
        {
            string[] arr;                                                                   //массив элементов строки
            arr = str.Split(' ');                                                           //преобразование строки в массив

            int min = int.MaxValue;                                                         //минимальная длина
            int index = 0;

            //Нахождение самого короткого элемента массива
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length < min)
                {
                    min = arr[i].Length;
                    index = i;
                }
            }
            return arr[index];
        }

        /// <summary>
        /// Вывод всех самых длинных слов
        /// </summary>
        /// <param name="str">Принимаемая строка</param>
        /// <returns></returns>
        static string MaxChar(string str)
        {
            string[] arr;                                                                   //массив элементов строки
            arr = str.Split(' ');                                                           //преобразование строки в массив

            int max = 0;                                                                    //максимальная длина
            int[] index;

            //Нахождение самого большего элемента массива
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > max)
                {
                    max = arr[i].Length;
                }
            }

            str = "";                                                                       //опустощаем строку

            foreach (var item in arr)
            {
                if (item.Length == max)
                {
                    str += item + " ";
                }
            }
            return str;
        }

        static void Main(string[] args)
        {
            string str = "AА ББ ВВВ ГГГГ ДДДД Д ЕЕ ЖЖ ЗЗЗ";
            Console.WriteLine(MinChar(str));
            Console.WriteLine(MaxChar(str));
            Console.ReadKey();
        }
    }
}

#region
//
// Задание 2.
// 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
// 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
// Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
// Пример: Текст: "A ББ ВВВ ГГГГ ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
// 1. Ответ: А
// 2. ГГГГ, ДДДД
//
#endregion