﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program_5
    {
        static void Main(string[] args)
        {
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