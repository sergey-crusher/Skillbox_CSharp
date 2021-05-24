using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7.Diary
{
    class Interface
    {
        //Ежедневник
        List<Diary> diary = new List<Diary>();


        /// <summary>
        /// Загрузка файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="write">Перезапись ежедневника (если True - запись, False - нет записи)</param>
        /// <returns></returns>
        public List<Diary> Download(string path, bool write)
        {
            //определяем временный ежедневник
            List<Diary> addedDiary = new List<Diary>();
            //считываем файл
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                addedDiary = JsonConvert.DeserializeObject<List<Diary>>(json);
            }
            //запись в файл
            if (write)
                diary = addedDiary;

            return addedDiary;
        }

        /// <summary>
        /// Очистка таблицы
        /// </summary>
        /// <param name="dataGridView">Таблица DataGridView</param>
        private void ClearDataGridView(DataGridView dataGridView)
        {
            //удаляем все строки таблицы
            while (dataGridView.Rows.Count > 0)
                dataGridView.Rows.RemoveAt(0);
        }

        /// <summary>
        /// Отображение ежедневника в DataGridView
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Diary2Grid (DataGridView dataGridView)
        {
            ClearDataGridView(dataGridView);
            diary.Diary2Grid(dataGridView);
        }

        /// <summary>
        /// Копирование данных из DataGridView
        /// </summary>
        /// <param name="dataGridView"></param>
        public void Grid2Diary(DataGridView dataGridView)
        {
            diary.Grid2Diary(dataGridView.Rows);
        }

        /// <summary>
        /// Фильтр по дате
        /// </summary>
        /// <param name="start">Начало периода</param>
        /// <param name="end">Окончание периода</param>
        public void FilterByDate (DateTime start, DateTime end)
        {
            diary.FilterByDate(start, end);
        }

        /// <summary>
        /// Выгрузка файла
        /// </summary>
        public void Upload(string path)
        {
            //сохраняем текст в файл
            File.WriteAllText(path, JsonConvert.SerializeObject(diary));
        }

        public void ConcatenationFile(string path, DataGridView dataGridView)
        {
            //конкатенация файлов
            diary.ConcatenationFile(Download(path, false));
            //заполняем таблицу
            diary.Diary2Grid(dataGridView);
        }

        /// <summary>
        /// Сортировка
        /// </summary>
        /// <param name="value">Поле для сортировки</param>
        /// <param name="dataGridView">Таблица DataGridView</param>
        public void Sort(string value, DataGridView dataGridView)
        {
            switch (value)
            {
                case "Дата": diary = diary.OrderBy(x => x.Date).ToList(); break;
                case "Сумма": diary = diary.OrderBy(x => x.Sum).ToList(); break;
                case "Доход": diary = diary.OrderBy(x => x.Income).ToList(); break;
                case "Прибыль": diary = diary.OrderBy(x => x.Profit).ToList(); break;
                case "Оборот": diary = diary.OrderBy(x => x.Turnover).ToList(); break;
                case "Заметки": diary = diary.OrderBy(x => x.Note).ToList(); break;
            }
        }

    }
}
