using System;
using System.Collections.Generic;
using System.Text;

namespace _10_TelegramBot.Models
{
    public class Message
    {
        #region Свойства
        /// <summary>
        /// Сообщения
        /// </summary>
        public string MessageText 
        {
            get
            {
                return messageText;
            }
            set
            {
                messageText = value;
            }
        }
        private string messageText;
        /// <summary>
        /// True - сообщение собеседника; False - бота
        /// </summary>
        public bool Interlocutor { get; set; }
        #endregion

        #region Конструкторы
        public Message (string MessageText)
        {
            this.MessageText = MessageText;
            this.Interlocutor = true;
        }
        public Message (string MessageText, User user)
        {
            this.MessageText = MessageText;
            this.Interlocutor = user.ToString() == "Bot" ? false : true;
        }
        #endregion
    }
}