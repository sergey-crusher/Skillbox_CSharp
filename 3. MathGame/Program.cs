using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;

namespace MathGame
{
    class Program
    {
        public static player Activ (List<player> players)
        {
            foreach (var player in players)
                if (player.activ)
                    return player;
            return null;
        }
        /// <summary>
        /// Переключение игрока на следующего (при неограниченном количестве игроков)
        /// </summary>
        /// <param name="players"></param>
        /// <returns></returns>
        public static List<player> Next (List<player> players)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].activ)
                {
                    players[i].activ = false;
                    if (i + 1 >= players.Count)
                        players[0].activ = true;
                    else
                        players[i + 1].activ = true;
                    break;
                }
            }
            return players;
        }
        /// <summary>
        /// Класс игрока(никнейм, право хода)
        /// </summary>
        public class player
        {
            public string nickname;
            public bool activ;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                //Режим игры
                string gameMode = ""; //1 - несколько игроков; 2 - NPC
                string difficultyLevel = ""; //1 - простой; 2 - сложный
                //Объявляем игроков
                List<player> Players = new List<player>();
                //Количество игроков
                int countPlayer = 0;
                //Случайное число от 12 до 120
                int gameNumber = 0;
                //Выбор игрока
                int userTry = 0;
                //Возможные значения
                int[] permitted = new int[] { 1, 2, 3, 4 };
                //Приветсвие игрока
                string helloPlayer = "";

                Console.WriteLine("Выбор режима:\r\n1 - несколько игроков\r\n2 - NPC");
                gameMode = Console.ReadLine();

                Random rnd = new Random();
                gameNumber = rnd.Next(12, 120);

                //ЦИКЛ ИГРЫ
                while (gameNumber > 0)
                {
                    //ПЕРВОНАЧАЛЬНАЯ НАСТРОЙКА ИГРЫ
                    //ВЫБИРАЕМ РЕЖИМ ИГРЫ
                    //Несколько игроков
                    if (gameMode == "1")
                    {
                        if (countPlayer == 0)
                        {
                            //Определяем количество игроков
                            Console.WriteLine("Сколько игроков будет играть?\r\nВведите число от 2 до бесконечности");
                            try
                            {
                                countPlayer = int.Parse(Console.ReadLine());
                                if (countPlayer < 2)
                                {
                                    Console.WriteLine("Выберите больше одного игрока");
                                    continue;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Количество игроков введено не корректно");
                                continue;
                            }
                            for (int i = 0; i < countPlayer; i++)
                            {
                                Players.Add(new player());
                            }
                            Players[countPlayer-1].activ = true;

                            //Вводим никнеймы всем игрокам
                            for (int i = 0; i < countPlayer; i++)
                            {
                                Console.WriteLine($"Введите имя для игрока №{i + 1} из {Players.Count}");
                                Players[i].nickname = Console.ReadLine();
                                helloPlayer += Players[i].nickname + ", ";
                            }
                            helloPlayer = helloPlayer.Substring(0, helloPlayer.Length - 2);
                        }
                    }
                    //NPC
                    else if (gameMode == "2")
                    {
                        if (userTry == 0)
                        {
                            Players.Add(new player());
                            Players[0].activ = true;
                            Console.WriteLine("Введите имя для игрока");
                            helloPlayer = Players[0].nickname = Console.ReadLine();

                            //ВЫБОР УРОВНЯ СЛОЖНОСТИ
                            Console.WriteLine("Выберите уровень сложности:\r\n" +
                                "1 - простой\r\n" +
                                "2 - сложный");
                            difficultyLevel = Console.ReadLine();
                            if (difficultyLevel != "1" && difficultyLevel != "2")
                                continue;
                        }
                    }
                    else
                        continue;

                    //ПРИВЕТСТВИЕ
                    if (helloPlayer != "")
                    {
                        Console.WriteLine($"{helloPlayer} добро пожаловать " +
                            $"в математическую баталию");
                        helloPlayer = "";
                    }

                    //ОТРАБОТКА ПО РЕЖИМУ С ИГРОКАМИ
                    if (gameMode == "1")
                    {
                        Next(Players);
                    }
                    else
                    {
                        //ОСНОВНОЙ АЛГОРИМ NPC
                        Console.WriteLine($"Текущее значение игрового числа {gameNumber}");
                        userTry = rnd.Next(1, 5);
                        Console.WriteLine($"Ход компьютера {userTry}");

                        //МЕНЯЕМ АЛГОРИМТ ДЛЯ ПОВЫШЕННОГО УРОВНЯ СЛОЖНОСТИ
                        if (difficultyLevel == "2")
                        {
                            if (gameNumber <= 8)
                            {
                                //НЕБОЛЬШОЙ АНАЛИЗ ПЕРЕД ФИНАЛОМ
                                if (gameNumber > 4 && gameNumber <= 8)
                                {
                                    userTry = 1;
                                }
                                else
                                {
                                    userTry = 4;
                                }
                            }
                        }
                        gameNumber -= userTry;
                        if (gameNumber <= 0)
                        {
                            Console.WriteLine("Компьютер одержал победу\r\nЧтобы повторить игру, нажмите любую клавишу");
                            continue;
                        }
                    }

                    //ДУША И СЕРДЦЕ ИГРЫ
                    Console.WriteLine($"Текущее значение игрового числа {gameNumber}");
                    Console.WriteLine($"Ход игрока {Activ(Players).nickname}, введите число от 1 до 4");
                    try
                    {
                        //Ввод игрового числа
                        userTry = int.Parse(Console.ReadLine());
                        if (Array.IndexOf(permitted,userTry)<0)
                        {
                            Console.WriteLine("Число выходит из диапазона");
                            continue;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Ошибка при вводе игрового числа");
                        continue;
                    }
                    gameNumber -= userTry;

                    if (gameNumber <= 0)
                        Console.WriteLine($"{Activ(Players).nickname} одержал победу\r\nЧтобы повторить игру, нажмите любую клавишу");
                }

                Console.ReadKey();
            }
        }
    }
}

#region
// Просматривая сайты по поиску работы, у вас вызывает интерес следующая вакансия:

// Требуемый опыт работы: без опыта
// Частичная занятость, удалённая работа
//
// Описание 
//
// Стартап «Micarosppoftle» занимающийся разработкой
// многопользовательских игр ищет разработчиков в свою команду.
// Компания готова рассмотреть C#-программистов не имеющих опыта в разработке, 
// но желающих развиваться в сфере разработки игр на платформе .NET.
//
// Должность Интерн C#/
//
// Основные требования:
// C#, операторы ввода и вывода данных, управляющие конструкции 
// 
// Конкурентным преимуществом будет знание процедурного программирования.
//
// Не технические требования: 
// английский на уровне понимания документации и справочных материалов
//
// В качестве тестового задания предлагается решить следующую задачу.
//
// Написать игру, в которою могут играть два игрока.
// При старте, игрокам предлагается ввести свои никнеймы.
// Никнеймы хранятся до конца игры.
// Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
// Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
// Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
// введенное число вычитается из gameNumber
// Новое значение gameNumber показывается игрокам на экране.
// Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
// Игра поздравляет победителя, предлагая сыграть реванш
// 
// * Бонус:
// Подумать над возможностью реализации разных уровней сложности.
// В качестве уровней сложности может выступать настраиваемое, в начале игры,
// значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

// *** Сложный бонус
// Подумать над возможностью реализации однопользовательской игры
// т е игрок должен играть с компьютером


// Демонстрация
// Число: 12,
// Ход User1: 3
//
// Число: 9
// Ход User2: 4
//
// Число: 5
// Ход User1: 2
//
// Число: 3
// Ход User2: 3
//
// User2 победил!
#endregion
