using Newtonsoft.Json;
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

namespace _7.Diary
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Ежедневник
        List<Diary> diary = new List<Diary>();
        //UI объекты меню
        List <ToolStripMenuItem> toolStripMenuItems = new List<ToolStripMenuItem>();

        /* Форма */

        public Form()
        {
            InitializeComponent();
            dataGridView1.Columns["Note"].Width = 350;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AllowUserToAddRows = false;
            checkGrid();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 41;
            dataGridView1.Height = this.Height - 89;
        }

        /// <summary>
        /// Проверка изменения количества строк в dataGridView
        /// </summary>
        void checkGrid()
        {
            if (dataGridView1.Rows.Count == 0)
                toolStripMenuItems.ForEach(x => x.Enabled = false);
            else
                toolStripMenuItems.ForEach(x => x.Enabled = true);
        }

        /* Файл */

        /// <summary>
        /// Выгрузка файла
        /// </summary>
        public void Upload()
        {
            //вызываем диалоговое окно сохранения файла
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            //получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            //сохраняем текст в файл
            File.WriteAllText(filename, JsonConvert.SerializeObject(diary));
        }

        /// <summary>
        /// Загрузка файла
        /// </summary>
        public List<Diary> Download()
        {
            //вызываем диалоговое окно открытия файла
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return null;

            //получаем выбранный файл
            string filePath = openFileDialog1.FileName;

            //определяем временный ежедневник
            List<Diary> addedDiary = new List<Diary>();

            //считываем файл
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                addedDiary = JsonConvert.DeserializeObject<List<Diary>>(json);
            }
            return addedDiary;
        }

        private void загрузкиДаннахИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //удаляем все строки таблицы
            while (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.RemoveAt(0);
            //загружаем файл
            diary = Download();
            //заполняем таблицу
            diary.Diary2Grid(dataGridView1);
        }

        private void выгрузкиДаннахВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //считываем данные с таблицы
            diary.Grid2Diary(dataGridView1.Rows);
            //выгружаем файл
            Upload();            
        }

        private void добавленияДанныхВТекущийЕжедневникИзВыбранногоФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //конкатенация файлов
            diary.ConcatenationFile(Download());
            //заполняем таблицу
            diary.Diary2Grid(dataGridView1);
        }

        /// <summary>
        /// Импорт по диапазону дат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportByDate_Click(object sender, EventArgs e)
        {
            //удаляем все строки таблицы
            while (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.RemoveAt(0);
            //загружаем файл
            diary = Download();
            //Фильтруем данные
            diary.FilterByDate(DateTime.Parse(start.Text), DateTime.Parse(end.Text));
            //заполняем таблицу
            diary.Diary2Grid(dataGridView1);
        }

        /// <summary>
        /// Событие на удаления строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            //Список элементов UI которые необходимо отключать и включать
            toolStripMenuItems.AddRange(new ToolStripMenuItem[]
            {
                UploadFile, ConcatenationFile, RemoveRow, Sort
            });
            checkGrid();
        }

        /* Правка */

        /// <summary>
        /// Событие на добавления строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            checkGrid();
        }

        /// <summary>
        /// Добавление строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        /// <summary>
        /// Удаление строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        /* Сортировка */

        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sort_Click(object sender, EventArgs e)
        {
            //считываем данные из таблицы (вообще это всё для задания, ведь dateGridView и сам умеет сортировать)
            diary.Grid2Diary(dataGridView1.Rows);
            //сортируем
            switch (SortBox.Text)
            {
                case "Дата": diary = diary.OrderBy(x => x.Date).ToList(); break;
                case "Сумма": diary = diary.OrderBy(x => x.Sum).ToList(); break;
                case "Доход": diary = diary.OrderBy(x => x.Income).ToList(); break;
                case "Прибыль": diary = diary.OrderBy(x => x.Profit).ToList(); break;
                case "Оборот": diary = diary.OrderBy(x => x.Turnover).ToList(); break;
                case "Заметки": diary = diary.OrderBy(x => x.Note).ToList(); break;
            }
            //удаляем все строки таблицы
            while (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows.RemoveAt(0);
            //заполняем таблицу
            diary.Diary2Grid(dataGridView1);
        }
    }
}
