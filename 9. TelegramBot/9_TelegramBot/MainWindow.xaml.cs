using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using _10_TelegramBot.Models;
using Placeholder;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace _10_TelegramBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Справочник контактов
        /// </summary>
        public ObservableCollection<PhoneBook> phoneBook = new ObservableCollection<PhoneBook>();
        /// <summary>
        /// Токен для доступа к API
        /// </summary>
        private static string Token = Properties.Settings.Default.Token;
        /// <summary>
        /// Переменная для взаимодействия с API Telegram
        /// </summary>
        private TelegramBotClient Bot = new TelegramBotClient(Token);

        public MainWindow()
        {
            InitializeComponent();
            DataGridPhoneBook.ItemsSource = phoneBook;
            DataGridChat.ItemsSource = phoneBook;

            //phoneBook.Add(new PhoneBook("Pro Verka") { Messages = new List<Message>() { new Message("Message Text"), new Message("Otvet 42") } });
        }

        #region Шапка
        /// <summary>
        /// Перемещение окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        /// <summary>
        /// Сворачивание окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinMinimize_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// Разворачивание окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinMaximized_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        /// <summary>
        /// Закрытие окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinClose_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }
        #endregion

        /// <summary>
        /// Закрытие формы (отключение приёма взаимодействия с API)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WinForm_Closed(object sender, EventArgs e)
        {
            Bot.StopReceiving();
        }

        /// <summary>
        /// Первичные операции
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void WinForm_Loaded(object sender, RoutedEventArgs e)
        {
            var me = await Bot.GetMeAsync();                                                // Получение сведений о боте
            WinTitle.Text = me.Username;                                                    // Никнейм устанавливаем в заголовок

            Bot.OnMessage += BotOnMessageReceived;                                          // Получение сообщений
            //Bot.OnMessageEdited += BotOnMessageReceived;
            //Bot.OnCallbackQuery += BotOnCallbackQueryReceived;
            //Bot.OnInlineQuery += BotOnInlineQueryReceived;
            //Bot.OnInlineResultChosen += BotOnChosenInlineResultReceived;
            //Bot.OnReceiveError += BotOnReceiveError;

            Bot.StartReceiving(Array.Empty<UpdateType>());
        }

        /// <summary>
        /// Получение сообщений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BotOnMessageReceived(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (message == null || message.Type != MessageType.Text)
                return;

            Dispatcher.Invoke(new Action(() =>
            {
                ListPhoneBook.Add(ref phoneBook, $"{message.Chat.FirstName} {message.Chat.LastName}", message.Text);
            }));
        }
    }
}
