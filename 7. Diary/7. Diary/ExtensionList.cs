using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Diary
{
    /// <summary>
    /// Расширение List
    /// </summary>
    static class extensionList
    {
        /// <summary>
        /// Функция проверки пустоты ячейки в таблице DataGridView
        /// </summary>
        /// <param name="val">Значение ячейки DataGridView</param>
        /// <param name="def">Значение по умолчанию, определяемое пользователем</param>
        /// <returns>Если значение ячейки null, возвращается значение по умолчанию, иначе значение ячейки</returns>
        public static string Validation(DataGridViewCell val, string def)
        {
            return val.Value == null ? def : val.Value.ToString();
        }

        /// <summary>
        /// Функция проверки пустоты ячейки в таблице DataGridView
        /// </summary>
        /// <param name="val">Значение ячейки DataGridView</param>
        /// <returns>Если значение ячейки null, возвращается значение int 0, иначе значение ячейки</returns>
        public static string Validation(DataGridViewCell val)
        {
            string def = "0";
            return val.Value == null ? def : val.Value.ToString();
        }

        /// <summary>
        /// Считывание данных из DataGridView
        /// </summary>
        /// <param name="grid">Данные таблицы DataGridView</param>
        /// <returns>Собранные данные из таблицы DataGridView</returns>
        public static void Grid2Diary(this List<Diary> list, DataGridViewRowCollection grid)
        {
            list.Clear();
            foreach (DataGridViewRow elem in grid)
            {
                //try
                {
                    list.Add(new Diary(
                        int.Parse(Validation(elem.Cells["Index"])),
                        DateTime.Parse(Validation(elem.Cells["Date"], DateTime.Now.ToString())),
                        float.Parse(Validation(elem.Cells["Sum"])),
                        float.Parse(Validation(elem.Cells["Income"])),
                        float.Parse(Validation(elem.Cells["Profit"])),
                        float.Parse(Validation(elem.Cells["Turnover"])),
                        Validation(elem.Cells["Note"], "Замечания отсутствуют")
                    ));
                }
                //catch (Exception e)
                {
                    //MessageBox.Show("Убедитесь в правильности вводимых данных: \r\n" + e.Message);
                    //return;
                }
            };
        }

        /// <summary>
        /// Запись данных в DataGridView
        /// </summary>
        /// <param name="grid">Таблица DataGridView</param>
        public static void Diary2Grid(this List<Diary> list, DataGridView grid)
        {
            //очищаем таблицу
            grid.DataSource = null;
            grid.Rows.Clear();

            //добавляем данные в таблицу
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    grid.Rows.Add();
                    grid.Rows[i].Cells["Index"].Value = list[i].Index;
                    grid.Rows[i].Cells["Date"].Value = list[i].Date;
                    grid.Rows[i].Cells["Sum"].Value = list[i].Sum;
                    grid.Rows[i].Cells["Income"].Value = list[i].Income;
                    grid.Rows[i].Cells["Profit"].Value = list[i].Profit;
                    grid.Rows[i].Cells["Turnover"].Value = list[i].Turnover;
                    grid.Rows[i].Cells["Note"].Value = list[i].Note;
                }
                int lastIndex = list.Count - 1;
                grid.Rows[lastIndex].Cells["Index"].Value = list.Last().Index;
                grid.Rows[lastIndex].Cells["Date"].Value = list.Last().Date;
                grid.Rows[lastIndex].Cells["Sum"].Value = list.Last().Sum;
                grid.Rows[lastIndex].Cells["Income"].Value = list.Last().Income;
                grid.Rows[lastIndex].Cells["Profit"].Value = list.Last().Profit;
                grid.Rows[lastIndex].Cells["Turnover"].Value = list.Last().Turnover;
                grid.Rows[lastIndex].Cells["Note"].Value = list.Last().Note;
            }
        }

        /// <summary>
        /// Фильтр по дате
        /// </summary>
        /// <param name="list"></param>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        public static void FilterByDate(this List<Diary> list, DateTime start, DateTime end)
        {
            list.RemoveAll(x => x.Date < start || x.Date > end);
        }

        /// <summary>
        /// Конкатенация данных из файла, создаёт новые индексы у второго файла (иключает совпадение индексов)
        /// </summary>
        /// <param name="addedList">Файл для конкатенации</param>
        public static void ConcatenationFile(this List<Diary> list, List<Diary> addedList)
        {
            int maxIndex = list.Max(x => x.Index);
            foreach (var item in addedList)
            {
                list.Add(new Diary(
                    ++maxIndex,
                    item.Date,
                    item.Sum,
                    item.Income,
                    item.Profit,
                    item.Turnover,
                    item.Note
                ));
            }
        }
    }
}
