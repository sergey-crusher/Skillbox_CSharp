using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static decimal Factorial(decimal x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от 1 до 25");
            decimal n = decimal.Parse(Console.ReadLine());
            string str = "";
            int max = ((Factorial(n) / (Factorial((int)n/2) * Factorial(n - (int)n/2)))).ToString().Length+1;
            for (decimal i = 0; i <= n; i++)  
            {
                for (decimal j = 0; j <= i; j++)
                {
                    str += $"{(Factorial(i) / (Factorial(j) * Factorial(i - j))).ToString().PadLeft(max, ' ')}";
                }
                int centerX = Math.Abs((Console.WindowWidth / 2) - (str.Length / 2));
                Console.SetCursorPosition(centerX, Console.CursorTop);
                Console.WriteLine(str);
                str = "";
            }
            Console.ReadKey();
        }
    }
}

#region
// * Задание 2
// Заказчику требуется приложение строящее первых N строк треугольника паскаля. N < 25
// 
// При N = 9. Треугольник выглядит следующим образом:
//                                 1
//                             1       1
//                         1       2       1
//                     1       3       3       1
//                 1       4       6       4       1
//             1       5      10      10       5       1
//         1       6      15      20      15       6       1
//     1       7      21      35      35       21      7       1
//                                                              
//                                                              
// Простое решение:                                                             
// 1
// 1       1
// 1       2       1
// 1       3       3       1
// 1       4       6       4       1
// 1       5      10      10       5       1
// 1       6      15      20      15       6       1
// 1       7      21      35      35       21      7       1
// 
// Справка: https://ru.wikipedia.org/wiki/Треугольник_Паскаля
#endregion