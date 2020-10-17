using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MathGame
{
    class Program
    {
        /// <summary>
        /// Возвращает игрока отличного от activPlayer (меняет активного)
        /// </summary>
        /// <param name="activPlayer"></param>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <returns></returns>
        static string changePlayer(string activPlayer, string player1, string player2)
        {
            if (activPlayer == player1)
                activPlayer = player2;
            else
                activPlayer = player1;
            return activPlayer;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                //Режим игры
                string gameMode = ""; //1 - два игрока; 2 - NPC
                                      //Никнеймы игроков
                string player1 = "";
                string player2 = "";
                //Проверка первый ли игрок
                string activPlayer = "";
                //Случайное число от 12 до 120
                int gameNumber = 0;
                //Выбор игрока
                int userTry = 0;
                //Возможные значения
                int[] permitted = new int[] { 1, 2, 3, 4 };

                Console.WriteLine("Выбор режима:\r\n1 - два игрока\r\n2 - NPC");
                gameMode = Console.ReadLine();

                Random rnd = new Random();
                gameNumber = rnd.Next(12, 120);

                //РЕЖИМ ДВУХ ИГРОКОВ
                if (gameMode == "1")
                {
                    //Приветсвие игроков
                    Console.WriteLine("Первый игрок - введите ваш никнейм");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Второй игрок - введите ваш никнейм");
                    activPlayer = player2 = Console.ReadLine();
                    Console.WriteLine($"{player1} и {player2} добро пожаловать в удивительный Мир Математики, " +
                        $"где вам предстоит решить не простую задачку, победит тот кто первым обнулит " +
                        $"игровое число(ИЧ), отнимая от 1 до 4, но победит лишь один, желаю удачи");
                    while (gameNumber > 0)
                    {
                        activPlayer = changePlayer(activPlayer, player1, player2);

                        Console.WriteLine($"ИЧ = {gameNumber}, {activPlayer} ваш ход");
                        //Обработка введённого числа
                        try
                        {
                            userTry = int.Parse(Console.ReadLine());
                            if (Array.IndexOf(permitted, userTry) < 0)
                            {
                                throw new Exception("Выход из диапазона чисел");
                            }
                            gameNumber -= userTry;
                        }
                        catch
                        {
                            activPlayer = changePlayer(activPlayer, player1, player2);
                            Console.WriteLine("Введите числовое значение от 1 до 4");
                        }
                    }
                    Console.WriteLine($"{activPlayer} ПОЗДРАВЛЯЕМ С ГРАНДИОЗНОЙ ПОБЕДОЙ!!!\r\nЖелаете ещё разок?");
                }
                //РЕЖИМ NPC
                else if (gameMode == "2")
                {
                    Console.WriteLine("Введите свой никнейм");
                    player1 = Console.ReadLine();
                    Console.WriteLine("Раз вы такой смелый, выберите уровень сложности:\r\n" +
                        "1 - для слабаков\r\n" +
                        "2 - для истинных профи");
                    string difficultyLevel = Console.ReadLine();
                    //ВЫБОР УРОВНЯ СЛОЖНОСТИ
                    if (difficultyLevel == "1")
                    {
                        player2 = "Сергей Слабачков";
                        Console.WriteLine($"Теперь твой противник {player2}, проиграть = позор");
                        while (gameNumber > 0)
                        {
                            activPlayer = changePlayer(activPlayer, player1, player2);
                            if (activPlayer == player1)
                            {
                                Console.WriteLine($"ИЧ = {gameNumber}, {player1} ваш ход");
                                //Обработка введённого числа
                                try
                                {
                                    userTry = int.Parse(Console.ReadLine());
                                    if (Array.IndexOf(permitted, userTry) < 0)
                                    {
                                        throw new Exception("Выход из диапазона чисел");
                                    }
                                    gameNumber -= userTry;
                                }
                                catch
                                {
                                    activPlayer = changePlayer(activPlayer, player1, player2);
                                    Console.WriteLine("Введите числовое значение от 1 до 4");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ИЧ = {gameNumber}, ходит {player2}");
                                userTry = rnd.Next(1, 5);
                                gameNumber -= userTry;
                                Console.WriteLine(userTry);
                            }
                        }
                        if (activPlayer == player1)
                            Console.WriteLine($"{player1} ну типо молодец...\r\nЖелаете ещё разок?");
                        else
                            Console.WriteLine($"{player2} всухую уделал тебя\r\nЕщё разок?");
                    }
                    else if (difficultyLevel == "2")
                    {
                        player2 = "Сергей СОКРУШИТЕЛЬ!";
                        Console.WriteLine($"Теперь твой противник {player2}, желаю удачи, она тебе пригодится");
                        while (gameNumber > 0)
                        {
                            activPlayer = changePlayer(activPlayer, player1, player2);
                            if (activPlayer == player1)
                            {
                                Console.WriteLine($"ИЧ = {gameNumber}, {player1} ваш ход");
                                //Обработка введённого числа
                                try
                                {
                                    userTry = int.Parse(Console.ReadLine());
                                    if (Array.IndexOf(permitted, userTry) < 0)
                                    {
                                        throw new Exception("Выход из диапазона чисел");
                                    }
                                    gameNumber -= userTry;
                                }
                                catch
                                {
                                    activPlayer = changePlayer(activPlayer, player1, player2);
                                    Console.WriteLine("Введите числовое значение от 1 до 4");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"ИЧ = {gameNumber}, ходит {player2}");
                                if (gameNumber > 8)
                                {
                                    userTry = rnd.Next(1, 5);
                                    gameNumber -= userTry;
                                }
                                else
                                {
                                    //НЕБОЛЬШОЙ АНАЛИЗ ПЕРЕД ФИНАЛОМ
                                    if (gameNumber > 4 && gameNumber <= 8)
                                    {
                                        userTry = 1;
                                        gameNumber -= userTry;
                                    }
                                    else
                                    {
                                        userTry = 4;
                                        gameNumber -= userTry;
                                    }
                                }
                                Console.WriteLine(userTry);
                            }
                        }
                        if (activPlayer == player1)
                            Console.WriteLine($"{player1} это было сильно!\r\nЖелаете ещё разок?");
                        else
                            Console.WriteLine($"{player2} всухую уделал тебя\r\nЕщё разок?");
                    }
                    else
                    {
                        Console.WriteLine("Испугался и выбрал что-то другое? Будь мужиком! Выбери хардкор, нажми 2");
                    }
                }
                else
                {
                    Console.WriteLine("Уважаемый, будьте любезны выбрать одно из двух");
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
