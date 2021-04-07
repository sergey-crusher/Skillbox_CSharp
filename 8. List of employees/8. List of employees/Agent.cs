using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.List_of_employees
{
    class Agent
    {
        /// <summary>
        /// Разрешение на изменение списка сотрудников
        /// </summary>
        public bool execute = true;

        // ОТДЕЛЕНИЯ //
        /// <summary>
        /// Список отделений
        /// </summary>
        private static ListDepartment Departments = new ListDepartment();

        /// <summary>
        /// Добавление отделения
        /// </summary>
        /// <param name="Name">Название отделения</param>
        /// <param name="CreationDate">Дата создания отделения</param>
        /// <param name="NumberEmployees">Количество сотрудников</param>
        public void AddDepartment(string Name, DateTime CreationDate, int NumberEmployees)
        {
            //Добавление отделения
            Departments.AddDepartment(Departments, new Department(Name, CreationDate, NumberEmployees));
            //Список отделений у сотрудника
            var dep = new DataGridViewComboBoxColumn();
            foreach (var item in Departments)
                dep.Items.Add(item.Name);
            dep.HeaderText = "Департамент";
            dep.Name = "Department";
            dep.DisplayIndex = 5;
            Program.mainForm.dataGridView.Columns.Remove("Department");
            Program.mainForm.dataGridView.Columns.Add(dep);
        }

        /// <summary>
        /// Удаление отделения
        /// </summary>
        /// <param name="id">Номер отделения по порядку</param>
        public void DeleteDepartment(int id)
        {
            Departments.RemoveAt(id);
            Program.mainForm.checkedListBox.Items.RemoveAt(id);
        }

        /// <summary>
        /// Информация об отделении
        /// </summary>
        /// <param name="id"></param>
        public void InfoDepartment(int id)
        {
            if (id > -1 && Departments.Count() > 0)
            {
                //Отображение дополнительных сведений об отделении
                Program.mainForm.CreationDate.Text = Departments.ElementAt(id).CreationDate.ToString("dd.MM.yyyy");
                Program.mainForm.NumberEmployees.Text = Departments.ElementAt(id).NumberEmployees.ToString();
                TotalEmployees();

                //Выборка сотрудников
                //Определяем какие отделения выбраны
                List<string> lb = new List<string>();
                lb.Add("");
                foreach (var item in Program.mainForm.checkedListBox.CheckedItems)
                    lb.Add(item.ToString());

                //Очищаем таблицу
                Program.mainForm.dataGridView.Rows.Clear();

                //Выводим всех сотрудников из выбранных отделений
                IEnumerable<Department> tempList = Departments.Where(x => lb.IndexOf(x.Name) > -1);

                execute = false;

                int i = 0;
                foreach (var emp in tempList)
                {
                    foreach (var x in emp.Employees)
                    {
                        Program.mainForm.dataGridView.Rows.Add(
                            x.ID,
                            Program.mainForm.dataGridView.Rows.Count,
                            x.FirstName,
                            x.Surname,
                            x.Age,
                            x.Salary,
                            x.NumberOfProjects
                        ) ;
                        Program.mainForm.dataGridView.Rows[i].Cells["Department"].Value = emp.Name;
                        i++;
                    }
                }

                execute = true;
            }
        }

        /// <summary>
        /// Количество сотрудников в выбранных отделениях
        /// </summary>
        public void TotalEmployees()
        {
            ListDepartment checkedDepartments = new ListDepartment();
            foreach (var item in Program.mainForm.checkedListBox.CheckedItems)
                checkedDepartments.Add(Departments.Where(x => x.Name == item.ToString()).First());
            Program.mainForm.TotalEmployees.Text = checkedDepartments.Sum(x => x.NumberEmployees).ToString();
        }

        // СОТРУДНИКИ //
        /// <summary>
        /// Список сотрудников
        /// </summary>
        private static ListEmployees Employees = new ListEmployees();

        /// <summary>
        /// Первичный разбор, исключение пустых ячеек
        /// </summary>
        /// <param name="cl"></param>
        public void ParseGrid(DataGridViewCellCollection cl)
        {
            //Проверка на пустую ячейку
            string IsNull(DataGridViewCell str)
            {
                if (str.Value == null)
                    return "";
                else
                    return str.Value.ToString();
            }

            EditEmployee(IsNull(cl["ID"]), IsNull(cl["FirstName"]), IsNull(cl["Surname"]), IsNull(cl["Age"]),
                IsNull(cl["Department"]), IsNull(cl["Salary"]), IsNull(cl["NumberOfProjects"]));
        }

        /// <summary>
        /// Редактирование сотрудника
        /// </summary>
        /// <param name="FirstName">Имя</param>
        /// <param name="Surname">Фамилия</param>
        /// <param name="Age">Возраст</param>
        /// <param name="Department">Отделение</param>
        /// <param name="Salary">Зарплата</param>
        /// <param name="NumberOfProjects">Количество проектов</param>
        private void EditEmployee(string ID, string FirstName, string Surname, string Age, string Department, string Salary, string NumberOfProjects)
        {
            int age, numberOfProjects;
            long id;
            float salary;
            if (FirstName != "" && Surname != "" && Department != "" && 
                int.TryParse(Age, out age) && int.TryParse(NumberOfProjects, out numberOfProjects) &&
                long.TryParse(ID, out id) && float.TryParse(Salary, out salary)
            )
            {
                //Обновление полей сотрудника
                Employees.Remove(Employees.Where(x => x.ID == id).Single());
                Departments.Where(x => x.Name == Department).Single().LinkToDepartment(
                    Employees.Where(x => x.ID == id).Single().
                    Update(id ,FirstName, Surname, age, Department, salary, numberOfProjects)
                );
            }
        }

        /// <summary>
        /// Добавление пользователя и возврат его ID
        /// </summary>
        /// <returns>ID нового пользователя</returns>
        public long AddEmployee()
        {
            var tempEmployee = new Employee();
            Employees.Add(tempEmployee);
            return tempEmployee.ID;
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="RowIndex"></param>
        public void DelEmployee(int RowIndex)
        {
            long ID = long.Parse(Program.mainForm.dataGridView.Rows[RowIndex].Cells["ID"].Value.ToString());
            string name = Program.mainForm.dataGridView.Rows[RowIndex].Cells["Department"].Value.ToString();
            var dep = Departments.Find(x => x.Name == name).Employees.Remove(Employees.Find(x => x.ID == ID));
            Program.mainForm.dataGridView.Rows.RemoveAt(RowIndex);
        }
    }
}
