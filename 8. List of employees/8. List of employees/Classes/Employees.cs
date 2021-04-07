using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.List_of_employees
{
    /// <summary>
    /// Класс для работы с сотрудниками
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// Уникальный идентификатор (локальное время машины)
        /// </summary>
        public long ID { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        //public string Department { get; set; }
        public float Salary { get; set; }
        public int NumberOfProjects { get; set; }

        /// <summary>
        /// Обновление значения
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="Surname">Фамилия</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Department">Отдел</param>
        /// <param name="Salary">Зарплата</param>
        /// <param name="NumberOfProjects">Количество проектов</param>
        public Employee Update(long ID ,string FirstName, string Surname, int Age, string Department, float Salary, int NumberOfProjects)
        {
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.Age = Age;
            //this.Department = Department;
            this.Salary = Salary;
            this.NumberOfProjects = NumberOfProjects;
            return this;
        }

        public Employee()
        {
            ID = DateTime.Now.Ticks;
        }
    }

    /// <summary>
    /// Словарь сотрудников
    /// </summary>
    public class ListEmployees : List<Employee>
    {

    }
}
