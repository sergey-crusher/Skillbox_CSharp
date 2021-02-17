using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _7.Diary
{
    public partial class Form : System.Windows.Forms.Form
    {
        //Для работы с интерфейсом
        Interface Interface = new Interface();
        //UI объекты меню
        List<ToolStripMenuItem> toolStripMenuItems = new List<ToolStripMenuItem>();

        /* Форма */
        public Form()
        {
            InitializeComponent();
            dataGridView1.Columns["Note"].Width = 350;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AllowUserToAddRows = false;
            checkGrid();
        }

        /// <summary>
        /// Включение/отключение активных кнопок в меню
        /// </summary>
        private void checkGrid()
        {
            if (dataGridView1.Rows.Count == 0)
                toolStripMenuItems.ForEach(x => x.Enabled = false);
            else
                toolStripMenuItems.ForEach(x => x.Enabled = true);
        }

        /// <summary>
        /// Перегрузка: Включение/отключение активных кнопок в меню
        /// </summary>
        /// <param name="on">true - для включение элементов UI</param>
        private void checkGrid(bool on)
        {
            if (on)
                toolStripMenuItems.ForEach(x => x.Enabled = true);
            else
                toolStripMenuItems.ForEach(x => x.Enabled = false);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            dataGridView1.Width = this.Width - 41;
            dataGridView1.Height = this.Height - 89;
        }

        /**************
         * БЛОКИ МЕНЮ *
         *************/

        /* Файл */
        private void загрузкиДаннахИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //вызываем диалоговое окно открытия файла
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            { 
                //загружаем файл
                Interface.Download(openFileDialog1.FileName, true);
                //заполняем таблицу
                Interface.Diary2Grid(dataGridView1);
            }
        }

        private void выгрузкиДаннахВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //считываем данные с таблицы
            try
            {
                Interface.Grid2Diary(dataGridView1);
                //вызываем диалоговое окно сохранения файла
                if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
                    Interface.Upload(saveFileDialog1.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Убедитесь в правильности вводимых данных: \r\n" + ex.Message);
            }
        }

        private void добавленияДанныхВТекущийЕжедневникИзВыбранногоФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //вызываем диалоговое окно открытия файла
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                //конкатенация файлов
                Interface.ConcatenationFile(openFileDialog1.FileName, dataGridView1);
                //заполняем таблицу
                Interface.Diary2Grid(dataGridView1);
            }
        }

        /// <summary>
        /// Импорт по диапазону дат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ImportByDate_Click(object sender, EventArgs e)
        {
            //вызываем диалоговое окно открытия файла
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                //загружаем файл
                Interface.Download(openFileDialog1.FileName, true);
                //Фильтруем данные
                Interface.FilterByDate(DateTime.Parse(start.Text), DateTime.Parse(end.Text));
                //заполняем таблицу
                Interface.Diary2Grid(dataGridView1);
            }
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
            checkGrid();
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
            Interface.Grid2Diary(dataGridView1);
            //сортируем
            Interface.Sort(SortBox.Text, dataGridView1);
            //заполняем таблицу
            Interface.Diary2Grid(dataGridView1);
        }

        /// <summary>
        /// Изменения значений ячеек (первый уровень защиты)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //переключение состояния ячейки (рабочее состояние true, не рабочее false)
            void switchGrid(bool on)
            {
                if (on)
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.White;
                    checkGrid();
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                    checkGrid(false);
                }
            }

            if (e.RowIndex > -1)
            {
                Regex floatReg = new Regex(@"^((0|[1-9])\d*[.]\d+)$");
                Regex intReg = new Regex(@"^(\d*)$");
                //не спасёт от 32 января, для всего остального есть try/catch
                Regex dateReg = new Regex(@"^(([0-3])\d{1}.([0-1])\d{1}.(0|[1-9])\d{3}[\s](0|[1-2])\d{1}:(0|[1-59])\d{1}:(0|[1-59])\d{1}$)");

                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    //значение ячейки
                    string value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    //Определяем с какой колонкой мы работаем
                    switch (e.ColumnIndex)
                    {
                        case 1:
                            {
                                if (!dateReg.IsMatch(value))
                                {
                                    switchGrid(false);
                                    MessageBox.Show("Укажите дату в формате ДД.ММ.ГГГГ чч:мм:сс");
                                }
                                else
                                {
                                    switchGrid(true);
                                }
                                break;
                            }
                        case 2: case 3: case 4: case 5:
                            {
                                if (!floatReg.IsMatch(value) && !intReg.IsMatch(value))
                                {
                                    switchGrid(false);
                                    MessageBox.Show("Укажите число с плавающей точкой");
                                }
                                else
                                {
                                    switchGrid(true);
                                }
                                break;
                            }
                    }
                }
                else
                {
                    checkGrid(false);
                    MessageBox.Show("Заполните ячейку");
                }
            }
        }
    }
}
