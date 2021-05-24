using System;
using System.IO;
using System.Net.Http;
using Telegram.Bot;

namespace _9_TelegramBot
{
    class Program
    {
        static TelegramBotClient bot;
        static void Main(string[] args)
        {
            //загружаем токен
            string token = File.ReadAllText(@"token.tok");
            //создаём экземпляр бота
            bot = new TelegramBotClient(token);

            bot.OnMessage += MessageListener;
            bot.StartReceiving();
            Console.ReadKey();
        }

        private static void MessageListener(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            string text = $"{DateTime.Now.ToLongTimeString()}: {e.Message.Chat.FirstName} {e.Message.Chat.Id} {e.Message.Text}";

            Console.WriteLine($"{text} TypeMessage: {e.Message.Type.ToString()}");


            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Document)
            {
                Console.WriteLine(e.Message.Document.FileId);
                Console.WriteLine(e.Message.Document.FileName);
                Console.WriteLine(e.Message.Document.FileSize);

                //DownLoad(e.Message.Document.FileId, e.Message.Document.FileName);
            }

            if (e.Message.Text == null) return;

            var messageText = e.Message.Text;


            bot.SendTextMessageAsync(e.Message.Chat.Id,
                $"{messageText}"
                );
        }
    }
}
