using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _8.List_of_employees
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Прослойка-агент для абстрации (инкапсуляции)
        /// </summary>
        Agent Agent = new Agent();

        public MainForm()
        {
            InitializeComponent();
            Program.mainForm = this;
        }

        // ОТДЕЛЕНИЯ //
        /// <summary>
        /// Добавление отделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormToDepartment(object sender, EventArgs e)
        {
            FormDepartment form = new FormDepartment();
            this.Enabled = false;
            form.Show();
            Agent.InfoDepartment(checkedListBox.SelectedIndex);
        }

        /// <summary>
        /// Удаление отделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteDepartment(object sender, EventArgs e)
        {
            Agent.DeleteDepartment(checkedListBox.SelectedIndex);
        }

        /// <summary>
        /// Сведения об отделении
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Agent.InfoDepartment(checkedListBox.SelectedIndex);
        }

        // СОТРУДНИКИ //
        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployee(object sender, EventArgs e)
        {
            //Добавление строки в таблицу
            dataGridView.Rows.Add();
            //Создание пустого пользователя и присвоение ему ID
            dataGridView.Rows[dataGridView.Rows.Count-1].Cells[0].Value = Agent.AddEmployee().ToString();
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveEmployee(object sender, EventArgs e)
        {
            Agent.DelEmployee(dataGridView.CurrentCell.RowIndex);
        }

        /// <summary>
        /// Изменение данных сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && Agent.execute)
            {
                Agent.ParseGrid(dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].OwningRow.Cells);
            }
        }

        /// <summary>
        /// Выгрузка xml или json файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void выгрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(ListDepartment));
            using (FileStream fs = new FileStream("./Employees.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Agent.Departments);
            }
        }
    }
}
