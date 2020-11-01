using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program_5
    {
        /// <summary>
        /// Функция Аккермана
        /// </summary>
        /// <param name="n">Первое число</param>
        /// <param name="m">Второе число</param>
        /// <returns>Результат функции Аккермана</returns>
        static double A(double n, double m)
        {
            double res = 0;
            if (n == 0)
                res = m + 1;
            else if (n != 0 && m == 0)
                res = A(n - 1, 1);
            else if (n > 0 && m > 0)
                res = A(n - 1, A(n, m - 1));
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("A(2,5) = ");
            Console.WriteLine(A(2, 5));
            Console.Write("A(1,2) = ");
            Console.WriteLine(A(1, 2));
            Console.ReadKey();
        }
    }
}

#region
//
// *Задание 5
// Вычислить, используя рекурсию, функцию Аккермана:
// A(2, 5), A(1, 2)
// A(n, m) = m + 1, если n = 0,
//         = A(n - 1, 1), если n <> 0, m = 0,
//         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
// 
// Весь код должен быть откоммментирован
#endregion