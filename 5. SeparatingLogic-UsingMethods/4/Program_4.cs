using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program_4
    {
        /// <summary>
        /// Проверка на арифметическую прогрессию
        /// </summary>
        /// <param name="first">Первый элемент</param>
        /// <param name="last">Последний элемент</param>
        /// <param name="coef">Коэффициент</param>
        /// <param name="args">Весь массив чисел</param>
        /// <returns>True - если прогрессия, False - если нет</returns>
        static bool Arithmetic(double first, double last, double coef, params double[] args)
        {
            int i = args.Length-1;
            while (last > first && args[i] == last)
            {
                last -= coef;
                i--;
            }
            if (last == first)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Проверка на геометрическую прогрессию
        /// </summary>
        /// <param name="first">Первый элемент</param>
        /// <param name="last">Последний элемент</param>
        /// <param name="coef">Коэффициент</param>
        /// <param name="args">Весь массив чисел</param>
        /// <returns>True - если прогрессия, False - если нет</returns>
        static bool Geometric(double first, double last, double coef, params double[] args)
        {
            int i = args.Length - 1;
            while (last > first && args[i] == last)
            {
                last /= coef;
                i--;
            }
            if (last == first)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Возвращает строку с типом прогрессии
        /// </summary>
        /// <param name="args">Ряд чисел</param>
        /// <returns></returns>
        static string Progression (params double[] args)
        {
            if (args[0] > args[1])
            {
                Array.Reverse(args);
            }

            double first = args.First();
            double last = args.Last();

            string res = "";

            if (Geometric(first, last, args[1] / args[0], args))
                res = "Геометрическая прогрессия";
            else if (Arithmetic(first, last, args[1] - args[0], args))
                res = "Арифметическая прогрессия";
            else
                res = "Ни то ни другое";

            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("4, 6, 9, 13.5 -> ");
            Console.WriteLine(Progression(4, 6, 9, 13.5));
            Console.Write("9, 6, 3, 0, -3 -> ");
            Console.WriteLine(Progression(9, 6, 3, 0, -3));
            Console.Write("1, 2, 3, 5, 6 -> ");
            Console.WriteLine(Progression(1, 2, 3, 5, 6));
            Console.ReadKey();
        }
    }
}

#region
//
// Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
// является заданная последовательность элементами арифметической или геометрической прогрессии
// 
// Примечание
//             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
//             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия
//
#endregion