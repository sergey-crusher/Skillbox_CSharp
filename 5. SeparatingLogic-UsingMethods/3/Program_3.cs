using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program_3
    {
        /// <summary>
        /// Возвращает строку без повторяющихся символов (без учёта регистра)
        /// </summary>
        /// <param name="str">Передаваемая строка</param>
        /// <returns></returns>
        static string ExtraChar (string str)
        {
            string res = "";
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].ToString().ToLower() != str[i + 1].ToString().ToLower())
                {
                    res += str[i];
                }
            }
            return res + str[str.Length-1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("ПППОООГГГООООДДДААА");
            Console.WriteLine(ExtraChar("ПППОООГГГООООДДДААА"));
            Console.WriteLine("Ххххоооорррооошшшиий деееннннь");
            Console.WriteLine(ExtraChar("Ххххоооорррооошшшиий деееннннь"));
            Console.ReadKey();
        }
    }
}

#region
//
// Задание 3. Создать метод, принимающий текст. 
// Результатом работы метода должен быть новый текст, в котором
// удалены все кратные рядом стоящие символы, оставив по одному 
// Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
// Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день
// 
#endregion