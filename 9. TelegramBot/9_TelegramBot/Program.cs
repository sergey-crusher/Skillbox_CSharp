using System;
using System.IO;
using Telegram.Bot;
using System.Linq;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.Enums;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.Text;
using Fizzler;
using Fizzler.Systems.HtmlAgilityPack;

namespace _9_TelegramBot
{
    class Program
    {
        static TelegramBotClient bot;
        static void Main(string[] args)
        {
            string token = File.ReadAllText(@"token.tok");
            bot = new TelegramBotClient(token);
            bot.OnMessage += MessageListener;
            bot.StartReceiving();
            Console.ReadKey();
        }

        async static void MessageListener(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            await bot.SetWebhookAsync("");
            string text = $"{DateTime.Now.ToLongTimeString()}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";
            string userText = e.Message.Text;

            Console.WriteLine($"{text} TypeMessage: {e.Message.Type}");

            //Определяем типы сообщений которые мы скачиваем
            switch (e.Message.Type)
            {
                //Документы
                case Telegram.Bot.Types.Enums.MessageType.Document: 
                    DownLoad(e.Message.Document.FileId, e.Message.Type.ToString(), e.Message.Document.FileUniqueId+"_"+e.Message.Document.FileName, e.Message.Chat.Id, "Документ сохранён");
                    break;
                //Аудио - отправляет как документ
                //case Telegram.Bot.Types.Enums.MessageType.Audio:
                //    DownLoad(e.Message.Audio.FileId, e.Message.Type.ToString(), e.Message.Audio.FileUniqueId+".mp3", e.Message.Chat.Id, "Аудио сохранено");
                //    break;
                //Голосовое сообщение
                case Telegram.Bot.Types.Enums.MessageType.Voice:
                    DownLoad(e.Message.Voice.FileId, e.Message.Type.ToString(), e.Message.Voice.FileUniqueId+".mp3", e.Message.Chat.Id, "Голосовое сообщение сохранено");
                    break;
                //Изображения
                case Telegram.Bot.Types.Enums.MessageType.Photo:
                    var lastPhoto = e.Message.Photo.Last(); //последний самый качественный
                    DownLoad(lastPhoto.FileId, e.Message.Type.ToString(), lastPhoto.FileUniqueId+".jpg", e.Message.Chat.Id, "Изображение сохранено"); //это .jps, но jpeg удобней
                    break;
                //Видео - отправляет как документ
                //case Telegram.Bot.Types.Enums.MessageType.Video:
                //    DownLoad(e.Message.Video.FileId, e.Message.Type.ToString(), e.Message.Video.FileId, e.Message.Chat.Id, "Видео сохранено");
                //    break;
            }

            //Выходим если текст сообщения отсутсвует
            if (userText == null) return;

            string messageText = String.Empty;

            //Диалог

            //Начальная команда
            if (userText == "/start")
            {
                messageText = $"Здравствуйте {e.Message.Chat.FirstName} !\r\n" +
                    $"Вы можете вызвать меню управления используя команду /menu\r\n" +
                    $"Так же вы можете отправлять различные фото, аудио, видео и т.д. файлы, они будут сохранены в архиве\r\n\r\n" +
                    $"Чтобы вызвать снова это сообщение, используйте команду /start";
            }
            //Вызов меню
            else if (userText == "/menu")
            {
                var keyboard = new ReplyKeyboardMarkup(new[]
                {
                    new []
                    {
                        new KeyboardButton("Новости финансов")
                    },
                    new []
                    {
                        new KeyboardButton("Скачать файлы")
                    }
                });

                 bot.SendTextMessageAsync(e.Message.Chat.Id, "Меню", replyMarkup: keyboard);
            }
            //Скачивание файлов
            else if (userText == "Скачать файлы")
            {
                bot.SendTextMessageAsync(e.Message.Chat.Id, "Директории", replyMarkup: ShowDir());
            }
            //Выбор нужной папки и файла
            else if (userText.Length > 2 && userText.Substring(0,2) == ".\\")
            {
                if (userText.Count(x => x == '\\') > 1)
                {
                    Console.WriteLine("Отправка файла");

                    using (FileStream fs = System.IO.File.Open(userText, FileMode.Open))
                    {
                        await bot.SendChatActionAsync(e.Message.Chat.Id, ChatAction.UploadDocument);
                        var fts = new InputOnlineFile(fs, Path.GetFileName(userText));
                        await bot.SendDocumentAsync(e.Message.Chat.Id, document: fts, fts.FileName);
                    }
                }
                else
                {
                    bot.SendTextMessageAsync(e.Message.Chat.Id, "Файлы", replyMarkup: ShowFiles(userText));
                    messageText = "Чтобы вернуться в директориям, воспользуйтесь /menu";
                }
            }
            //
            else if (userText == "Новости финансов")
            {
                var html = new HtmlDocument();
                html.LoadHtml(await RequestAsync("https://ru.investing.com/news/latest-news"));
                HtmlNode doc = html.DocumentNode;
                //блок новостей
                doc = doc.QuerySelector(".largeTitle");
                //новости
                var news = doc.QuerySelectorAll(".title");
                messageText = String.Empty;
                foreach (var ns in news)
                {
                    messageText += ns.InnerText +"\r\n" +
                        "https://ru.investing.com/news/latest-news" + ns.Attributes["href"].Value + "\r\n\r\n";
                }

            }
            else
            {
                messageText = "Чтобы вернуться в начало, используйте команду /start";
            }

            //Формируем ответ
            bot.SendTextMessageAsync(e.Message.Chat.Id, $"{messageText}");
        }

        #region Отправка файла пользователю
        /// <summary>
        /// Список директорий
        /// </summary>
        /// <returns>Массив директорий</returns>
        static ReplyKeyboardMarkup ShowDir()
        {
            ReplyKeyboardMarkup keyboard = Directory.GetDirectories(".\\");
            keyboard.ResizeKeyboard = true;
            return keyboard;
        }

        /// <summary>
        /// Мой микрошедевр, показывает файлы в папке
        /// </summary>
        /// <param name="path">Путь к папке</param>
        /// <returns>Файлы в папке</returns>
        static ReplyKeyboardMarkup ShowFiles(string path)
        {
            int length = Directory.GetFiles(path).Length;
            string[] dir = Directory.GetFiles(path);
            KeyboardButton[][] arr = new KeyboardButton[length][];
            for (int i=0; i<length; i++)
            {
                arr[i] = new KeyboardButton[] { dir[i]};
            }
            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup(arr);
            keyboard.ResizeKeyboard = true;
            return keyboard;
        }

        #endregion

        #region Скачивание файлов от пользователя
        /// <summary>
        /// Скачивание файлов
        /// </summary>
        /// <param name="fileId">Индентификатор файла</param>
        /// <param name="type">Тип</param>
        /// <param name="name">Название</param>
        static async void DownLoad(string fileId, string type, string name, long chatId, string messageText)
        {
            var file = await bot.GetFileAsync(fileId);
            EnsureFolder($"./{type}");
            FileStream fs = new FileStream($"./{type}/{name}", FileMode.CreateNew);
            await bot.DownloadFileAsync(file.FilePath, fs);
            fs.Close();
            fs.Dispose();

            await bot.SendTextMessageAsync(chatId, $"{messageText}");
        }

        /// <summary>
        /// Создание дирректории при её отсутствии
        /// </summary>
        /// <param name="path">Путь к папке</param>
        static void EnsureFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        #endregion

        #region Работа с внешними ресурсами
        /// <summary>
        /// Получение исходного html кода страницы
        /// </summary>
        /// <returns>Ответ на запрос</returns>
        private static async Task<String> RequestAsync(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = ".NET Framework Test Client";
                request.Accept = "text/html";

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    Stream resStream = response.GetResponseStream();
                    StreamReader streamReader = new StreamReader(
                                                  resStream,
                                                  Encoding.GetEncoding(response.CharacterSet)
                                                );
                    return(streamReader.ReadToEnd());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        #endregion
    }
}
