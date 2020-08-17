using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using DailyNews.Converters;
using System.Windows.Threading;

namespace DailyNews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Boolean CallFavoutireNewsAndPosts = false;
        public MainWindow()
        {
            InitializeComponent();
            CheckReader();
            initializeTimerForCurrentTime();
        }

        private void CheckReader()
        {
            DataBaseManager.CheckReader();
        }

        private void initializeTimerForCurrentTime()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTimeNow();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMaximizeRestore_Click(object sender, RoutedEventArgs e)
        {
            SetWindowsState();
        }

        private void SetWindowsState()
        {
            if (this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                this.imgMaximizeRestore.Source = new BitmapImage(new Uri(@"\Resource\maximize-window-48.png", UriKind.Relative));
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                this.imgMaximizeRestore.Source = new BitmapImage(new Uri(@"\Resource\restore-window-48.png", UriKind.Relative));
            }
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        private void btnNews_Click(object sender, RoutedEventArgs e)
        {
            News.Visibility = Visibility.Visible;
        }

        private void DateTimeNow()
        {
            DateAndTimeNow.Text = ConvertToEasternNum.ConvertToEasternArabicNumerals(DateTime.Now.ToString("dddd  yyyy/MM/dd  hh:mm:ss tt", new CultureInfo("ar-JO")));
        }

        private void btnFavorite_Click(object sender, MouseButtonEventArgs e)
        {
            btnIsFavourite();
            SocialMedia.SetIsFavourite();
            SocialMedia.GetPosts();
            News.SetIsFavourite();
            News.GetNews();
        }

        private void btnIsFavourite()
        {
            BitmapImage Image = new BitmapImage();
            Image.BeginInit();
            CallFavoutireNewsAndPosts = !CallFavoutireNewsAndPosts;
            if (CallFavoutireNewsAndPosts)
            {
                Image.UriSource = new Uri(AppDomain.CurrentDomain.BaseDirectory + @"\Icons\FavouritesFolderIcon.png");
            }
            else
            {
                Image.UriSource = new Uri(AppDomain.CurrentDomain.BaseDirectory + @"\Icons\FavouritesFolderIconWiteBlack.png");
            }
            
            Image.EndInit();
            btnFavorite.Source = Image;
        }
    }

}
