using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_Prototype_information_system.models
{
    /// <summary>
    /// Класс для работы с отделениями
    /// </summary>
    public class Department
    {
        #region Свойства
        /// <summary>
        /// Уникальный идентификатор
        /// </summary>
        public long id { get; set; }
        /// <summary>
        /// Название отделения
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Дата создание отделения
        /// </summary>
        public DateTime dateTime { get; set; }
        public List<Employees> employees { get; set; }
        public List<Department> departments { get; set; }
        #endregion

        #region Конструкторы        
        /// <summary>
        /// Создание нового отделения
        /// </summary>
        /// <param name="name">Название отделения</param>
        /// <param name="dateTime">Дата создания отеделения</param>
        /// <param name="parentId">Идентификатор родителя</param>
        internal Department(string name, DateTime dateTime)
        {
            //Уникальный идентификатор созданные из текущего времени
            this.id = DateTime.Now.Ticks;
            this.name = name;
            this.dateTime = dateTime;
            this.employees = new List<Employees>();
            this.departments = new List<Department>();
        }

        internal Department(long id, string name, DateTime dateTime)
        {
            this.id = id;
            this.name = name;
            this.dateTime = dateTime;
            this.employees = new List<Employees>();
            this.departments = new List<Department>();
        }

        [Newtonsoft.Json.JsonConstructor]
        public Department(long id, string name, DateTime dateTime, List<Employees> employees, List<Department> departments)
        {
            this.id = id;
            this.name = name;
            this.dateTime = dateTime;
            this.employees = employees;
            this.departments = departments;
        }

        public Department() { }
        #endregion

        #region Методы
        public void Update(string name, DateTime dateTime)
        {
            this.name = name;
            this.dateTime = dateTime;
        }
        #endregion
    }

    [Serializable()]
    public class DepartmentList : List<Department>
    {
        #region Методы
        /// <summary>
        /// Поиск отделения по id
        /// </summary>
        /// <param name="department">Лист департаментов</param>
        /// <param name="id">Уникальный номер департамента</param>
        /// <returns></returns>
        public Department SearchById(List<Department> department, string id)
        {
            Department res;
            if ((res = department.Find(x => x.id == long.Parse(id))) != null)
            {
                return res;
            }
            else
            {
                foreach (var dep in department)
                {
                    var tempRes = SearchById(dep.departments, id);
                    if (tempRes != null)
                        res = tempRes;
                }
                return res;
            }
        }

        /// <summary>
        /// Сохранение данных из интерфейса
        /// </summary>
        /// <param name="department">Департамент</param>
        /// <param name="id">Уникальный номер департамента</param>
        /// <param name="dataGridView">Таблица сотрудников</param>
        public void localSave(List<Department> department, string id, DataGridView dataGridView, string nameDep, DateTime dateTime)
        {
            //Находим необходый департамент
            Department dep = SearchById(department, id);
            //Обновляем данные о самом департаменте
            dep.Update(nameDep, dateTime);
            //Обновляем данные о сотрудниках
            dep.employees.Clear();
            //Переносим структура таблицы сотрудников в класс сотрудников необходимого департамента
            for (int i=0; i<dataGridView.Rows.Count; i++)
            {
                var row = dataGridView.Rows[i];

                //Сохранение для пользователей без id
                long ID;
                if (row.Cells["id"].Value == null) ID = DateTime.Now.Ticks;
                else ID = long.Parse(row.Cells["id"].Value.ToString());

                dep.employees.Add(new Employees(
                    ID,
                    row.Cells["surname"].Value.ToString(),
                    row.Cells["firstName"].Value.ToString(),
                    int.Parse(row.Cells["age"].Value.ToString()),
                    double.Parse(row.Cells["salary"].Value.ToString())
                ));
            }
        }
        
        //Удаление отделения
        public Department RemoveDepartment(List<Department> department, string id)
        {
            int index;
            Department res;
            if ((res = department.Find(x => x.id == long.Parse(id))) != null)
            {
                if ((index = department.FindIndex(x => x.id == long.Parse(id))) > -1)
                    department.RemoveAt(index);
                return res;
            }
            else
            {
                foreach (var dep in department)
                {
                    var tempRes = RemoveDepartment(dep.departments, id);
                    if (tempRes != null)
                    {
                        if ((index = department.FindIndex(x => x.id == long.Parse(id))) > -1)
                            department.RemoveAt(index);
                        res = tempRes;
                    }
                }
                return res;
            }
        }

        /// <summary>
        /// Загрузка JSON файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns>Десериализованные данные из файла</returns>
        public DepartmentList LoadJSON(string path)
        {
            return JsonConvert.DeserializeObject<DepartmentList>(File.ReadAllText(path));
        }
        #endregion
    }
}
