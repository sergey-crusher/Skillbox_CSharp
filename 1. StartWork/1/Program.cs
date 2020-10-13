using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_01
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите номер задания введя цифру от 1 до 3 и нажмите ввод");
                String valInput = Console.ReadLine();
                Repository repository = null;

                int people = 0;

                switch (valInput)
                {
                    case "1":
                        {
                            people = 20;
                            // Создание массива сотрудников
                            repository = new Repository(people);
                            // Печать в консоль всех сотрудников
                            repository.Print("База данных до преобразования");
                            // Увольнение всех Агат
                            repository.DeleteWorkerByName("Агата");
                            // Печать в консоль сотрудников, которые не попали под увольнение
                            repository.Print("База данных после первого преобразования");
                            break;
                        }
                    case "2":
                        {
                            // Создание массива сотрудников
                            people = 20;
                            // Более наглядно
                            //people = 120;
                            repository = new Repository(people);
                            // Печать в консоль всех сотрудников
                            repository.Print("База данных до преобразования");
                            //Удалять пока больше 30 сотрудников
                            while (repository.Workers.Count > 30) 
                            {
                                repository.DeleteWorkerByName(repository.Workers[0].FirstName);
                            }
                            // Печать в консоль сотрудников, которые не попали под увольнение
                            repository.Print("База данных после первого преобразования");
                            break;
                        }
                    case "3":
                        {
                            people = 50;
                            // Создание массива сотрудников
                            repository = new Repository(people);
                            // Печать в консоль всех сотрудников
                            repository.Print("База данных до преобразования");
                            // Увольнение работников чья зарплата превышает 30000руб
                            repository.DeleteWorkerBySalary(30000);
                            // Печать в консоль сотрудников, которые не попали под увольнение
                            repository.Print("База данных после первого преобразования");
                            break;
                        }
                }
                Console.ReadKey();
            }

            #region Домашнее задание

            // Уровень сложности: просто
            // Задание 1. Переделать программу так, чтобы до первой волны увольнени в отделе было не более 20 сотрудников

            // Уровень сложности: средняя сложность
            // * Задание 2. Создать отдел из 40 сотрудников и реализовать несколько увольнений, по результатам
            //              которых в отделе болжно остаться не более 30 работников

            // Уровень сложности: сложно
            // ** Задание 3. Создать отдел из 50 сотрудников и реализовать увольнение работников
            //               чья зарплата превышает 30000руб



            #endregion

        }
    }
}
