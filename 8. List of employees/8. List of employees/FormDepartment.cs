using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8.List_of_employees
{
    public partial class FormDepartment : Form
    {
        /// <summary>
        /// Прослойка-агент для абстрации (инкапсуляции)
        /// </summary>
        Agent Agent = new Agent();

        public FormDepartment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка добавления отделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddDepartment(object sender, EventArgs e)
        {
            Agent.AddDepartment(NameDepartment.Text, CreationDate.SelectionStart, (int)NumberEmployees.Value);
            ReturnMainForm();
        }

        /// <summary>
        /// Кнопка отмены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close(object sender, EventArgs e)
        {
            ReturnMainForm();
        }

        /// <summary>
        /// Возврат к главной форме
        /// </summary>
        private void ReturnMainForm()
        {
            Program.mainForm.Enabled = true;
            this.Close();
            Agent.TotalEmployees();
        }
    }
}
