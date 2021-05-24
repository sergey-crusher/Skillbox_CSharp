using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Prototype_information_system.models
{
    public class Employees
    {
        #region Свойства
        public long id { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
        #endregion

        #region Конструкторы
        internal Employees(string surname, string name, int age, double salary)
        {
            this.id = DateTime.Now.Ticks;
            this.surname = surname;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        [Newtonsoft.Json.JsonConstructor]
        public Employees(long id, string surname, string name, int age, double salary)
        {
            this.id = id;
            this.surname = surname;
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public Employees() { }
        #endregion
    }
}
