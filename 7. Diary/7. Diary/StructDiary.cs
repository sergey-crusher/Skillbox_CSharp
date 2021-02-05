using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Security;

namespace _7.Diary
{
    public struct Diary
    {
        public int Index;
        public DateTime Date;
        public float Sum;
        public float Income;
        public float Profit;
        public float Turnover;
        public string Note;
    }

    public static class extensionList
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
                list.Add(new Diary()
                {
                    Index = int.Parse(Validation(elem.Cells["Index"])),
                    Date = DateTime.Parse(Validation(elem.Cells["Date"], DateTime.Now.ToString())),
                    Sum = float.Parse(Validation(elem.Cells["Sum"])),
                    Income = float.Parse(Validation(elem.Cells["Income"])),
                    Profit = float.Parse(Validation(elem.Cells["Profit"])),
                    Turnover = float.Parse(Validation(elem.Cells["Turnover"])),
                    Note = Validation(elem.Cells["Note"], "Замечания отсутствуют")
                });
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

        /// <summary>
        /// Фильтр по дате
        /// </summary>
        /// <param name="list"></param>
        /// <param name="start">Начальная дата</param>
        /// <param name="end">Конечная дата</param>
        public static void FilterByDate (this List<Diary> list, DateTime start, DateTime end)
        {
            list.RemoveAll(x => x.Date < start || x.Date > end);
        }

        /// <summary>
        /// Конкатенация данных из файла, создаёт новые индексы у второго файла (иключает совпадение индексов)
        /// </summary>
        /// <param name="addedList">Файл для конкатенации</param>
        public static void ConcatenationFile (this List<Diary> list, List<Diary> addedList)
        {
            int maxIndex = list.Max(x => x.Index);
            foreach (var item in addedList)
            {
                list.Add(new Diary()
                {
                    Index = ++maxIndex,
                    Income = item.Income,
                    Date = item.Date,
                    Note = item.Note,
                    Profit = item.Profit,
                    Sum = item.Sum,
                    Turnover = item.Turnover
                });
            }
        }
    }
}
