using System;
using System.Collections.Generic;

namespace HomeWork2
{
    class Program
    {
        /// <summary>
        /// Класс студента
        /// </summary>
        class Person
        {
            public string   name;                                                           //имя
            public int      age;                                                            //возраст
            public int      height;                                                         //рост
            public Dictionary<string, int> study = new Dictionary<string, int>();           //предметы

            /// <summary>
            /// Функция среднее арифметическое
            /// </summary>
            /// <returns>Среднее арифметическое</returns>
            public double GetAverage ()
            {
                double avr = 0;
                foreach (var x in study)
                {
                    avr += x.Value;
                }
                return avr/study.Count;
            }

            /// <summary>
            /// Обычный вывод
            /// </summary>
            public void GetInfo1()
            {
                String str = "Имя: " + name + " Возраст: " + age + " Рост " + height + " Средний бал " + GetAverage().ToString("f2");
                int centerX = (Console.WindowWidth / 2) - (str.Length / 2);
                int centerY = (Console.WindowHeight / 2) - 1;
                Console.SetCursorPosition(centerX, centerY);
                Console.WriteLine(str);
            }

            /// <summary>
            /// Форматированный вывод
            /// </summary>
            public void GetInfo2()
            {
                Console.WriteLine("Имя: {0} Возраст: {1} Рост {2} Средний бал {3:f2}",name,age,height,GetAverage());
            }

            /// <summary>
            /// Вывод с интерполяцией строк
            /// </summary>
            public void GetInfo3()
            {
                Console.WriteLine($"Имя: {name} Возраст: {age} Рост {height} Средний бал {GetAverage():f2}");
            }
        }
        static void Main(string[] args)
        {
            Person student = new Person();
            student.name = "Сергей";
            student.age = 26;
            student.height = 178;
            student.study.Add("История", 84);
            student.study.Add("Математика", 100);
            student.study.Add("Русский", 91);
            student.GetInfo3();
            student.GetInfo2();
            student.GetInfo1();
        }
    }
    //Условия задания
    #region
    // Заказчик просит написать программу «Записная книжка». Оплата фиксированная - $ 120.

    // В данной программе, должна быть возможность изменения значений нескольких переменных для того,
    // чтобы персонифецировать вывод данных, под конкретного пользователя.

    // Для этого нужно: 
    // 1. Создать несколько переменных разных типов, в которых могут храниться данные
    //    - имя;
    //    - возраст;
    //    - рост;
    //    - баллы по трем предметам: история, математика, русский язык;

    // 2. Реализовать в системе автоматический подсчёт среднего балла по трем предметам, 
    //    указанным в пункте 1.

    // 3. Реализовать возможность печатки информации на консоли при помощи 
    //    - обычного вывода;
    //    - форматированного вывода;
    //    - использования интерполяции строк;

    // 4. Весь код должен быть откомментирован с использованием обычных и хml-комментариев

    // **
    // 5. В качестве бонусной части, за дополнительную оплату $50, заказчик просит реализовать 
    //    возможность вывода данных в центре консоли.
    #endregion
}
