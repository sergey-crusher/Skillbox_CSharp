using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Prototype_information_system.models
{
    /// <summary>
    /// Класс для работы с отделениями
    /// </summary>
    class Department
    {
        #region Свойства
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public long id { get; private set; }
        /// <summary>
        /// Название отделения
        /// </summary>
        public string name { get; private set; }
        /// <summary>
        /// Дата создание отделения
        /// </summary>
        public DateTime dateTime { get; private set; }
        public List<Employees> employees { get; private set; }
        public List<Department> departments { get; private set; }
        #endregion

        #region Конструкторы
        /// <summary>
        /// Создание нового отделения
        /// </summary>
        /// <param name="name">Название отделения</param>
        /// <param name="dateTime">Дата создания отеделения</param>
        /// <param name="parentId">Идентификатор родителя</param>
        public Department (string name, DateTime dateTime)
        {
            //Уникальный идентификатор созданные из текущего времени
            this.id = DateTime.Now.Ticks;
            this.name = name;
            this.dateTime = dateTime;
            this.employees = new List<Employees>();
            this.departments = new List<Department>();
        }
        #endregion
    }
}
