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

namespace _8_Prototype_information_system
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Экземпляр класса для работы с отделениями
        List<Department> department = new List<Department>();

        public Form()
        {
            InitializeComponent();

            //Первичное наполнение для демонстрации
            department.Add(new Department("Самый главный отдел 1", DateTime.Now));
            department.First().departments.Add(new Department("Главный отдел 1", DateTime.Now.AddDays(-1)));
            department.First().departments.Add(new Department("Главный отдел 2", DateTime.Now.AddDays(-2)));
            department.First().departments.First().departments.Add(new Department("Подразделение", DateTime.Now.AddDays(-3)));
            department.Add(new Department("Самый главный отдел 2", DateTime.Now.AddDays(-4)));
            RefreshTreeDepartment();
        }        

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
            department.Add(
                new Department(
                    CreateDepartmentName.Text, 
                    CreateDepartmentDateTime.Value
                )
            );
            CreateDepartment.Visible = false;
            RefreshTreeDepartment();
        }

        /// <summary>
        /// Обновление списка департаментов
        /// </summary>
        private void RefreshTreeDepartment()
        {
            //Очистка всех записей
            TreeDepartments.Nodes.Clear();
            //Добавление корневой записи
            RecursiveFilling(TreeDepartments.Nodes.Add("0", "Список отделений"), department);

            //Рекурсивное заполнение дерева отделений
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
        }

        /// <summary>
        /// Переключение режима главного/дочернего элемента при добавлении департамента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateDepartmentCheckRoot_CheckedChanged(object sender, EventArgs e)
        {
            if (CreateDepartmentCheckRoot.Checked)
                CreateDepartmentChangeSize(861, 1209);
            else
                CreateDepartmentChangeSize(1209, 861);
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
        /// Отображение выбора департамента на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreeDepartments_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }
    }
}
