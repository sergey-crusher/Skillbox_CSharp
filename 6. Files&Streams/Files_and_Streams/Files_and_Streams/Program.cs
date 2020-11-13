using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Files_and_Streams
{
    class Program
    {
        const string output = "out.txt";
        const string compFile = "compressedFile.zip";

        /// <summary>
        /// Сжатие файла
        /// </summary>
        static void Compress()
        {
            //Поток для чтения исходного файла
            using (FileStream sourceStream = new FileStream(output, FileMode.OpenOrCreate))
            {
                //Поток для записи сжатого файла
                using (FileStream targetStream = File.Create(compFile))
                {
                    //Поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        sourceStream.CopyTo(compressionStream);                                 //копируем байты из одного потока в другой
                        Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.",
                            output, sourceStream.Length.ToString(), targetStream.Length.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Возвращает количество групп
        /// </summary>
        /// <param name="N">Конечное число алгоритма</param>
        /// <returns>Количество групп</returns>
        static int NumberOfGroups(int N)
        {
            int count = 1;
            while (N > 1)
            {
                N /= 2;
                count++;
            }
            return count;
        }

        /// <summary>
        /// Запись в файл результа разбиения чисел по группа
        /// </summary>
        /// <param name="N">Конечное число алгоритма</param>
        static void Writing2File(int N)
        {
            long step = 2;
            int index = 1;

            using (StreamWriter w = new StreamWriter(output, false, Encoding.GetEncoding("UTF-8")))
            {
                w.Write("Группа 1: 1");
                for (long i = 2; i <= N; i++)
                {
                    if (i >= step)
                    {
                        w.Write($"\r\nГруппа {index + 1}: ");
                        index++;
                        step *= 2;
                    }
                    w.Write($"{i} ");
                }
            }
        }

        /// <summary>
        /// Отчёт времени
        /// </summary>
        /// <param name="dt">Затраченное время</param>
        /// <param name="unit">Формат вывода: s - секунды, ms - миллисекунды</param>
        /// <returns>Возвращает время в указанном формате</returns>
        static string ElapsedTime(TimeSpan dt, string unit)
        {
            string[] time = dt.ToString().Split('.', ':');
            string res = "";
            switch (unit)
            {
                case "ms":
                    {
                        res = (long.Parse(time[1]) * 60_000 + long.Parse(time[2]) * 1000 + long.Parse(time[3].Substring(0,3))).ToString();
                        break;
                    }
                case "s":
                    {
                        res = (float.Parse(time[1]) * 60 + float.Parse(time[2]) + float.Parse(time[3].Substring(0, 3)) /1000).ToString();
                        break;
                    }
            }
            return res;
        }

        static void Main(string[] args)
        {
            string pathToNumber = "./number.txt";                                               //путь по умолчанию
            Console.WriteLine($"Укажите путь к файлу или нажимите клавишу (Enter) " +
                $"чтобы использовать путь по умолчанию \"{pathToNumber}\":");                   //сообщение приветсвия

            int N = 50;                                                                         //число N

            //Проверка наличия ввода нового пути
            string input = Console.ReadLine();
            pathToNumber = input != "" ? input : pathToNumber;
            Console.WriteLine(pathToNumber);

            //Считываем значение из файла
            try
            {
                if (int.TryParse(File.ReadAllText(pathToNumber), out N))
                    Console.WriteLine($"Количество элементов: {N}");
                else
                {
                    Console.WriteLine($"Число в файле было не корректно");
                    Console.WriteLine("Исправьте ошибку и перезапустите программу. Нажимите любую клавишу чтобы выйти.");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Произошла ошибка с файлом: \"{pathToNumber}\"");
                Console.WriteLine(e.Message);
                Console.WriteLine("Исправьте ошибку и перезапустите программу. Нажимите любую клавишу чтобы выйти.");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //Развила выбора действий
            string change;                                                                      //хранит выбор пользователя
            DateTime beginDate = new DateTime();

            while (true)
            {
                Console.WriteLine("Выберите один из двух вариантов:");
                Console.WriteLine("1 - Показать только количество групп");
                Console.WriteLine("2 - Получить заполненные группы и записать их в файл");

                change = Console.ReadLine();
                beginDate = DateTime.Now;
                DateTime endTime;
                if (change == "1")
                {
                    Console.WriteLine($"Количество групп: {NumberOfGroups(N)}");
                    endTime = DateTime.Now;
                    Console.WriteLine($"Затраченное количество секунд: {ElapsedTime(endTime - beginDate, "s")}");
                    Console.WriteLine($"Затраченное количество миллисекунд: {ElapsedTime(endTime - beginDate, "ms")}");
                }
                else if (change == "2")
                {
                    Writing2File(N);
                    Console.WriteLine($"Запись файла {Path.GetFullPath(output)} завершена");
                    endTime = DateTime.Now;
                    Console.WriteLine($"Затраченное количество секунд: {ElapsedTime(endTime - beginDate, "s")}");
                    Console.WriteLine($"Затраченное количество миллисекунд: {ElapsedTime(endTime - beginDate, "ms")}");

                    while (true)
                    {
                        Console.WriteLine("Если желаете архивировать данные нажмите [y], в противном случае [n]");
                        char tempKey = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                        if (tempKey == 'y')
                        {
                            Compress();
                        }
                        else if (tempKey == 'n')
                            break;
                        else
                            continue;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка выбора ответа, выберите один из двух вариантов");
                    continue;
                }
            }

            //Напоминание о впустую потраченном дне

            //List<List<ulong>> numbers = new List<List<ulong>>();
            //numbers.Add(new List<ulong>());
            //int Range = 1;
            //numbers[0].Add(1);

            //int index = 2;

            //index++;
            //for (int j = 0; j < Range; j++)
            //{
            //    bool check = true;
            //    if (index > Math.Pow(2, j))
            //    {
            //        for (int i = 0; i < numbers[j].Count; i++)
            //        {
            //            if (check)
            //            {
            //                if ((index) % numbers[j][i] == 0)
            //                {
            //                    check = false;

            //                    if (j < numbers.Count - 1)
            //                        continue;
            //                    else
            //                    {
            //                        numbers.Add(new List<int>());
            //                        numbers[j + 1].Add(index);
            //                        Range++;
            //                        i = -1;
            //                        j = 0;
            //                        index++;
            //                        break;
            //                    }
            //                }
            //            }
            //            else
            //                break;
            //        }
            //    }
            //    if (check)
            //    {
            //        numbers[j].Add(index);
            //        index++;
            //        j = 0;
            //        if (index > N)
            //            break;
            //    }
            //}
        }
    }
}

#region Домашнее задание
///
/// Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
/// своих навыков. 
/// 
/// Немного подумав они вспомнили, что не так давно на занятиях по математике
/// они проходили тему "свойства делимости целых чисел". На этом занятии преподаватель показывал
/// пример с использованием фактов делимости. 
/// Пример заключался в следующем: 
/// Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
/// так, что если одно число делится на другое, то эти числа попадают в разные группы. 
/// В результате этого разбиения получилось M групп, для N = 50, M = 6
/// 
/// N = 50
/// Группы получились такими: 
/// 
/// Группа 1: 1
/// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
/// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
/// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
/// Группа 5: 16 24 36 40
/// Группа 6: 32 48
/// 
/// M = 6
/// 
/// ===========
/// 
/// N = 10
/// Группы получились такими: 
/// 
/// Группа 1: 1
/// Группа 2: 2 7 9
/// Группа 3: 3 4 10
/// Группа 4: 5 6 8
/// 
/// M = 4
/// 
/// Участники хакатона решили эту задачу, добавив в неё следующие возможности:
/// 1. Программа считыват из файла (путь к которому можно указать) некоторое N, 
///    для которого нужно подсчитать количество групп
///    Программа работает с числами N не превосходящими 1 000 000 000
///   
/// 2. В ней есть два режима работы:
///   2.1. Первый - в консоли показывается только количество групп, т е значение M
///   2.2. Второй - программа получает заполненные группы и записывает их в файл используя один из
///                 вариантов работы с файлами
///            
/// 3. После выполения пунктов 2.1 или 2.2 в консоли отображается время, за которое был выдан результат 
///    в секундах и миллисекундах
/// 
/// 4. После выполнения пунта 2.2 программа предлагает заархивировать данные и если пользователь соглашается -
/// делает это.
/// 
/// Попробуйте составить конкуренцию начинающим программистам и решить предложенную задачу
/// (добавление новых возможностей не возбраняется)
///
/// * При выполнении текущего задания, необходимо документировать код 
///   Как пометками, так и xml документацией
///   В обязательном порядке создать несколько собственных методов
///   
#endregion
