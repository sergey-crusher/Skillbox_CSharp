using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _8_Prototype_information_system.models;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using System.Xml.Linq;
using System.Runtime.Serialization.Json;
using System.Xml.Serialization;

namespace _8_Prototype_information_system
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Экземпляр класса для работы с отделениями
        DepartmentList department = new DepartmentList();
        //Формат для (де)сериализации xml
        XmlSerializer formatter = new XmlSerializer(typeof(List<Department>));

        public Form()
        {
            InitializeComponent();
        }

        #region Методы для взаимодействия с отделениями
        /// <summary>
        /// Вызов панели для создания отделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDepartment.Visible = true;
        }

        /// <summary>
        /// Кнопка создания нового отделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateDepartmentButton_Click(object sender, EventArgs e)
        {
            //Создаём новый департамент
            Department newDep = new Department(
                CreateDepartmentName.Text,
                CreateDepartmentDateTime.Value
            );

            //Если выбран не корневой департамент
            if (!CreateDepartmentCheckRoot.Checked)
            {
                department.SearchById(department, TreeDepartments.SelectedNode.Name).departments.Add(newDep);
            }
            else
            {
                department.Add(newDep);
            }
            //Переход обратны из режима добавления департамента
            CreateDepartment.Visible = false;
            //Обновление перечня департаментов
            RefreshTreeDepartment(TreeDepartments.SelectedNode.Name);
        }

        /// <summary>
        /// Обновление списка департаментов
        /// </summary>
        private void RefreshTreeDepartment(string nodeName)
        {
            //Очистка всех записей
            TreeDepartments.Nodes.Clear();
            //Добавление корневой записи
            RecursiveFilling(department);

            //Раскрытие дерева к последнему узлу
            if (nodeName != null)
            {
                TreeDepartments.SelectedNode = TreeDepartments.Nodes.Find(nodeName, true).First();
                TreeDepartments.SelectedNode.Expand();
            }
            else
            {
                TreeDepartments.SelectedNode = TreeDepartments.Nodes[0];
            }
        }

        /// <summary>
        /// Рекурсивное заполнение дерева отделений
        /// </summary>
        /// <param name="department">Лист департаментов</param>
        void RecursiveFilling(List<Department> department)
        {
            foreach (var dep in department)
            {
                if (dep.departments.Count > 0)
                    RecursiveFilling(TreeDepartments.Nodes.Add(dep.id.ToString(), dep.name), dep.departments);
                else
                    TreeDepartments.Nodes.Add(dep.id.ToString(), dep.name);
            }
        }

        /// <summary>
        /// Рекурсивное заполнение дерева отделений
        /// </summary>
        /// <param name="tree">Узел дерева</param>
        /// <param name="department">Лист департаментов</param>
        void RecursiveFilling(TreeNode tree, List<Department> department)
        {
            foreach (var dep in department)
            {
                if (dep.departments.Count > 0)
                    RecursiveFilling(tree.Nodes.Add(dep.id.ToString(), dep.name), dep.departments);
                else
                    tree.Nodes.Add(dep.id.ToString(), dep.name);
            }
        }

        /// <summary>
        /// Переключение режима главного/дочернего элемента при добавлении департамента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateDepartmentCheckRoot_CheckedChanged(object sender, EventArgs e)
        {
            if (CreateDepartmentCheckRoot.Checked)
            {
                CreateDepartmentChangeSize(861, 1209);
                CreateDepartmentParent.Text = "-";
            }
            else
            {
                CreateDepartmentChangeSize(1209, 861);
            }
        }

        /// <summary>
        /// Вспомогательный метод, меняющий размер панели добавления департамента
        /// </summary>
        /// <param name="old">Старая ширина панели</param>
        /// <param name="current">Новая ширина панели</param>
        private void CreateDepartmentChangeSize(int old, int current)
        {
            CreateDepartment.Width = current;
            CreateDepartment.Left += old - current;
        }

        /// <summary>
        /// Удаляет все строки из dataGridView
        /// </summary>
        private void ClearDataGridView()
        {
            while (dataGridView.Rows.Count > 0)
                dataGridView.Rows.RemoveAt(0);
        }

        /// <summary>
        /// Отображение данных о департаменте при клике на него в дереве
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var dep = department.SearchById(department, e.Node.Name);
            if (dep != null)
            {
                //Основное меню
                nameDepartment.Text = dep.name;
                dateTimeDepartment.Value = dep.dateTime;
                employeesDepartment.Text = dep.employees.Count().ToString();

                //Создание департамента
                CreateDepartmentParent.Text = dep.name;

                //Заполнение таблицы сотрудников
                RefreshDGV(dep);
            }
        }

        /// <summary>
        /// Удаление отделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            department.RemoveDepartment(department, TreeDepartments.SelectedNode.Name);
            RefreshTreeDepartment(TreeDepartments.SelectedNode.Parent.Name);
        }
        #endregion

        #region Методы для взаимодействия с сотрудниками
        /// <summary>
        /// Добавление сотрудника в отдел
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Add();
        }

        /// <summary>
        /// Сохранение данных из формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void localSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        /// <summary>
        /// Сохранение данных из формы
        /// </summary>
        private void Save()
        {
            for (int i=0; i<dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                {
                    //Проверка на наличие данных
                    if (dataGridView.Rows[i].Cells[0].Value == null ||
                        dataGridView.Rows[i].Cells[1].Value == null ||
                        dataGridView.Rows[i].Cells[2].Value == null ||
                        dataGridView.Rows[i].Cells[4].Value == null)
                    {
                        MessageBox.Show("Заполнены не все поля пользователей");
                        return;
                    }
                    //Проверка на корректность
                    if (long.Parse()

                }
            }

            department.localSave(department, TreeDepartments.SelectedNode.Name, dataGridView, nameDepartment.Text, dateTimeDepartment.Value);
            RefreshTreeDepartment(TreeDepartments.SelectedNode.Name);
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.RemoveAt(dataGridView.CurrentRow.Index);
            Save();
        }

        /// <summary>
        /// Обновление таблицы сотрудников
        /// </summary>
        /// <param name="dep"></param>
        private void RefreshDGV(Department dep)
        {
            ClearDataGridView();
            for (int i = 0; i < dep.employees.Count; i++)
            {
                Employees emp = dep.employees[i];
                dataGridView.Rows.Add(emp.surname, emp.name, emp.age, emp.id, emp.salary);
            }
        }
        #endregion

        #region Сохранение файлов
        /// <summary>
        /// Сохранение файла JSON
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void форматJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(department));
        }

        /// <summary>
        /// Сохранение в формате XML
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void форматXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, department);
            }
        }
        #endregion

        #region Загрузка файлов
        /// <summary>
        /// Загрузка по умолчанию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            department = department.LoadJSON(defaultPath.Text);
            RefreshTreeDepartment(null);
        }

        /// <summary>
        /// Кнопка загрузки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            if (openFileDialog.FileName.IndexOf(".json") > -1)
            {
                department = department.LoadJSON(openFileDialog.FileName);
            }
            else if (openFileDialog.FileName.IndexOf(".xml") > -1)
            {
                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    List<Department> dep = (List<Department>)formatter.Deserialize(fs);
                    department = new DepartmentList();
                    foreach (var item in dep)
                    {
                        department.Add(item);
                    }
                }
            }
            RefreshTreeDepartment(null);
            RefreshDGV(department.First());
        }
        #endregion

        #region Сортировка
        private void toolStripComboBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dep = department.SearchById(department, TreeDepartments.SelectedNode.Name);
            var emp = dep.employees;

            switch (toolStripComboBoxSort.Text)
            {
                case "Фамилия": emp = emp.OrderBy(x => x.surname).ToList(); break;
                case "Имя": emp = emp.OrderBy(x => x.name).ToList(); break;
                case "Возраст": emp = emp.OrderBy(x => x.age).ToList(); break;
                case "Идентификатор": emp = emp.OrderBy(x => x.id).ToList(); break;
                case "Зарплата": emp = emp.OrderBy(x => x.salary).ToList(); break;
            }
            department.SearchById(department, TreeDepartments.SelectedNode.Name).employees = emp;
            RefreshDGV(dep);
        }
        #endregion
    }
}
