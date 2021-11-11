using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace _10_TelegramBot.Models
{
    public class PhoneBook
    {
        #region Переменные и константы
        /// <summary>
        /// Цвета используемые в Telegram
        /// </summary>
        private readonly Color[] colors = {
            Color.FromRgb(221, 69, 84),
            Color.FromRgb(121, 101, 193),
            Color.FromRgb(65, 164, 166),
            Color.FromRgb(99, 170, 85),
            Color.FromRgb(219, 134, 59),
            Color.FromRgb(67, 136, 185),
            Color.FromRgb(203, 79, 135)
        };
        #endregion

        #region Свойства
        /// <summary>
        /// Конвертация имено в два символа
        /// </summary>
        public string ShortName
        {
            get
            {
                return shortName;
            }
            private set
            {
                value = value.ToUpper();
                if (value.Length > 0 && value.IndexOf(' ') > -1)
                {
                    try
                    {
                        // Converted name
                        char[] char_name = value.Split(' ').Select(x => x[0]).ToArray();
                        int[] char_index = char_name.Select(x => (int)x).ToArray();
                        shortName = string.Concat(char_name[0], char_name[1]);
                        // Getting color
                        int color_index = (char_name[0] + char_name[1]) % 7;
                        ColorIcon = colors[color_index];
                    }
                    catch
                    {
                        shortName = "-";
                        ColorIcon = colors[0];
                    }
                }
                else
                {
                    if (value.Length > 1)
                        shortName = value.Substring(0, 2);
                    else if (value.Length > 0)
                        shortName = value.Substring(0, 1);
                    else
                        shortName = "-";

                    ColorIcon = colors[0];
                }
            }
        }
        private string shortName;

        /// <summary>
        /// Полное имя пользователя
        /// </summary>
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = ShortName = value;
            }
        }
        private string fullName;

        /// <summary>
        /// Цвет иконки
        /// </summary>
        public Color ColorIcon { get; set; }

        /// <summary>
        /// История сообщений
        /// </summary>
        public ObservableCollection<Message> Messages
        {
            get
            {
                return messages;
            }
            set
            {
                messages = value;
            }
        }
        private ObservableCollection<Message> messages = new ObservableCollection<Message>();
        #endregion

        #region Конструкторы
        public PhoneBook (string FullName)
        {
            this.FullName = FullName;
        }
        #endregion
    }

    public static class ListPhoneBook
    {
        #region Методы
        /// <summary>
        /// Добавление нового чата (если такого ещё нет)
        /// </summary>
        /// <param name="phoneBook">Ссылка на справочник (ref)</param>
        /// <param name="chat">Экземпляр PhoneBook</param>
        public static void Add(ref ObservableCollection<PhoneBook> phoneBook, string fullName, string message)
        {
            if (phoneBook.FirstOrDefault(x => x.FullName == fullName) == null)
            {
                phoneBook.Add(new PhoneBook(fullName));
            }
            phoneBook.FirstOrDefault(x => x.FullName == fullName).Messages.Add(new Message(message));
        }
        #endregion
    }
}
