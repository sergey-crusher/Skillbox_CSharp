using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _8.List_of_employees
{
    /// <summary>
    /// Класс для работы с отеделениями
    /// </summary>
    [Serializable]
    public class Department
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public int NumberEmployees {
            get { return Employees.Count; ; }
            set {; }
        }
        public ListEmployees Employees { get; set; } = new ListEmployees();

        public Department (string Name, DateTime CreationDate, int NumberEmployees)
        {
            this.Name = Name;
            this.CreationDate = CreationDate;
            this.NumberEmployees = NumberEmployees;
        }
        public Department() { }
        
        /// <summary>
        /// Связь сотрудника с отделением
        /// </summary>
        /// <param name="employee">Сотрудник</param>
        public void LinkToDepartment(Employee employee)
        {
            if (Employees.Exists(x => x.ID == employee.ID))
            {
                Employees.Remove(Employees.Find(x => x.ID == employee.ID));
            }
            Employees.Add(employee);
        }
    }

    /// <summary>
    /// Словарь отделений, унаследованно от List
    /// Как бы здесь использовать this в методах... было бы очень удобно
    /// </summary>
    [Serializable]
    public class ListDepartment : List<Department>
    {
        public ListDepartment() { }
        /// <summary>
        /// Добавление отделения
        /// </summary>
        /// <param name="departments">Вместо this</param>
        /// <param name="department">Отделение</param>
        public void AddDepartment(ListDepartment departments, Department department)
        {
            if (!departments.Where(x => x.Name == department.Name).Any())
            {
                departments.Add(department);
                Program.mainForm.checkedListBox.Items.Add(department.Name);
            }
            else
            {
                MessageBox.Show("Отделение с названием \"" + department.Name + "\" уже существует");
            }
        }
    }
}
