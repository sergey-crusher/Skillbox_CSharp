using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Collections;
using System.Diagnostics;

namespace Files_and_Streams
{
    public class Program
    {
        const string outputFile = "out.txt";
        const string compFile = "compressedFile.zip";
        static List<List<int>> output;


        /// <summary>
        /// Сжатие файла
        /// </summary>
        static void Compress(string pathCompFile)
        {
            //Поток для чтения исходного файла
            using (FileStream sourceStream = new FileStream(outputFile, FileMode.OpenOrCreate))
            {
                //Поток для записи сжатого файла
                using (FileStream targetStream = File.Create(pathCompFile+compFile))
                {
                    //Поток архивации
                    using (GZipStream compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
                    {
                        //Копируем байты из одного потока в другой
                        sourceStream.CopyTo(compressionStream);
                        Console.WriteLine("Сжатие файла {0} завершено. Исходный размер: {1}  сжатый размер: {2}.",
                            outputFile, sourceStream.Length.ToString(), targetStream.Length.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Решето Эратосфена
        /// </summary>
        /// <param name="n">Конечное число алгоритма</param>
        /// <returns>Массив простых чисел</returns>
        static List<int> SieveEratosthenes(int n)
        {
            BitArray bitArray = new BitArray(n);
            bitArray.SetAll(true);
            var numbers = new List<int>();

            int check;

            for (var i = 2; i < Math.Sqrt(n); i++)
            {
                for (var j = 2; j < n; j++)
                {
                    check = i * j;
                    //удаляем кратные числа из списка
                    if (check < n && check > 0)
                    {
                        bitArray[i*j] = false;
                    }
                    else
                    { 
                        break; 
                    }
                }
            }

            for (int i = 3; i < n; i++)
            {
                if (bitArray[i])
                    numbers.Add(i);
            }

            return numbers;
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
        /// Рассчитывает и выводит в консоль в "красивом" виде
        /// </summary>
        /// <param name="N">Входящее число</param>
        static void Beautiful(int N)
        {
            int mult = 0;
            output = new List<List<int>>();
            BitArray bitArray;

            //1-ая группа
            output.Add(new List<int>());
            output[0].Add(1);
            //2-ая группа (все простые числа)
            output.Add(new List<int>());
            int number = 3;                                                                 //Начальное число для цикла
            output[1].Add(2);                                                               //Добавляем двойку
            bool check = true;                                                              //Для проверки - является ли простым
            output[1].AddRange(SieveEratosthenes(N));                                       //Наполняем простыми числами

            //3-я группа
            output.Add(new List<int>());
            bitArray = new BitArray(N+1);
            for (int i = 0; i < Math.Sqrt(output[1].Count); i++)
            {
                for (int j = 0; j < output[1].Count - i; j++)
                {
                    mult = output[1][i] * output[1][j];
                    if (mult <= N && mult > 0)
                        bitArray[mult] = true;
                    else
                        break;
                }
            }
            //Добавляем в список
            for (int i = 0; i <= N; i++)
                if (bitArray[i])
                    output[2].Add(i);

            //Последующие группы
            for (int k = 3; k < NumberOfGroups(N); k++)
            {
                bitArray = new BitArray(N+1);
                output.Add(new List<int>());
                for (int i = 0; i < Math.Sqrt(output[1].Count); i++)
                {
                    for (int j = 0; j < output[k - 1].Count - i; j++)
                    {
                        mult = output[1][i] * output[k - 1][j];
                        if (mult <= N && mult > 0)
                            bitArray[mult] = true;
                        else
                            break;
                    }
                }
                for (int i = 0; i <= N; i++)
                    if (bitArray[i])
                        output[k].Add(i);
            }
        }

        /// <summary>
        /// Быстрый расчёт
        /// </summary>
        /// <param name="N">Входящее число</param>
        static void MainTask(int N)
        {
            output = new List<List<int>>();
            output.Add(new List<int>());

            int step = 2;
            int index = 0;

            for (int i = 1; i <= N; i++)
            {
                if (i >= step)
                {
                    index++;
                    step *= 2;
                    output.Add(new List<int>());
                }
                output[index].Add(i);
            }

            //Вывод в консоль
            if (false)
            {
                for (int i = 0; i < output.Count; i++)
                {
                    for (int j = 0; j < output[i].Count; j++)
                    {
                        Console.Write(output[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            //Зацикливаем интефейс программы
            while (true)
            {
                try
                {
                    //Создаём таймер
                    Stopwatch stopWatch = new Stopwatch();
                    //Считываем количество элементов N из файла
                    int N = int.Parse(File.ReadAllText("N"));
                    //Проверяем число на вхождение в диапазон
                    if (N > 0 && N <= 1_000_000_000)
                    {
                        //Приветсвие пользователя
                        Console.WriteLine("Выберите режим работы: \r\n"+
                            "1 - посчитать количество групп\r\n" +
                            "2 - произвести красивый расчёт (не рекомендуется для больших чисел)\r\n" +
                            "3 - быстрый, полный расчёт");
                        //Считываем то что ввёл пользователь
                        string answer = Console.ReadLine();
                        stopWatch.Start();
                        //Определяем действие
                        switch (answer)
                        {
                            case "1":
                                Console.WriteLine($"Количество групп: {NumberOfGroups(N)}");
                                break;
                            case "2":
                                Beautiful(N);
                                break;
                            case "3":
                                MainTask(N);
                                break;
                            default:
                                Console.WriteLine("Введите значение \"1\", \"2\" или \"3\"");
                                continue;
                        }
                        stopWatch.Stop();
                        TimeSpan ts = stopWatch.Elapsed;

                        //Определяем формат времени и вывод
                        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
                            ts.Hours, ts.Minutes, ts.Seconds,
                            ts.Milliseconds);
                        Console.WriteLine(elapsedTime);

                        if (output != null)
                        {
                            //Создание файла
                            using (StreamWriter w = new StreamWriter(outputFile, false, Encoding.GetEncoding("UTF-8")))
                            {
                                for (int i = 0; i < output.Count; i++)
                                {
                                    w.Write($"Группа {i + 1}: ");
                                    w.WriteLine(String.Join(",", output[i]));
                                }
                            }

                            //Архивация
                            Console.WriteLine("Если желаете создать архив, " +
                            "нажмите \"Enter\" чтобы использовать путь по умолчанию (\"./compressedFile.zip\") " +
                            "или введите свой путь к файлу:");
                            //Определяем действие
                            answer = Console.ReadLine();
                            switch (answer)
                            {
                                case "":
                                    Compress("");
                                    break;
                                default:
                                    Compress(answer);
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Укажите число от 1 до 1 000 000 000");
                        continue;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
    }
}