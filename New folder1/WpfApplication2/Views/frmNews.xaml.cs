using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using DailyNews.Converters;
namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class frmNews : UserControl
    {
        List<News> news;
        frmSearch NewfrmSearch;
        Nullable<DateTime> StartDate = null;
        Nullable<DateTime> EndDate = null;
        Nullable<Boolean> IsRead = null;
        string Region = null;
        string Resource = null;
        string Observer = null;
        string KeyWord = null;
        Boolean IsFavourite = false;
        public frmNews()
        {           
            InitializeComponent();
            initilizeTimerForGetNews();
            GetNews();
            NewfrmSearch = new frmSearch(this);
        }


        public void SetIsFavourite()
        {
            IsFavourite = !this.IsFavourite;
            GetNews();
        }
       
        public void SetSearchedNewsProperties(Nullable<DateTime> StartDate, Nullable<DateTime> EndDate,
           Nullable<Boolean> IsRead, string Region, string Resource, string Observer, string KeyWord)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsRead = IsRead;
            this.Region = Region;
            this.Resource = Resource;
            this.Observer = Observer;
            this.KeyWord = KeyWord;
        }

        public void GetNews()
        {
            news = new List<News>();
            news = DataBaseManager.GetNews(this.StartDate, this.EndDate, this.IsRead,
                this.Region, this.Resource, this.Observer, this.KeyWord, this.IsFavourite);
            NewsList.ItemsSource = null;
            NewsList.ItemsSource = news;
        }

        private void initilizeTimerForGetNews()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetNews();                    
        }

        private void Notification_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Notification_Click");
        }

        private void item_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var borderSelected = (Border)sender;
            var newsSelected = (News)borderSelected.DataContext;
            int value = news.FindIndex(item => item.Id == newsSelected.Id);
            var frmView = new frmViewNews(news, value,this);
            frmView.ShowDialog();
        }

        private void Favourite_Click(object sender, RoutedEventArgs e)
        {
            Button b1 = (Button)sender;
            var News = (News)b1.DataContext;
            News.isFavourite = !(News.isFavourite);
            DataBaseManager.SetFavourite(News.Id);
            string str;
            if (News.isFavourite == true)
            {
                str= "تم إضافة الخبر الى الفائمة المفضلة";
            }
            else
            {
                str = "تم إزلة الخبر الى الفائمة المفضلة";
            }

            MessageBox.Show(str,"",MessageBoxButton.OK ,MessageBoxImage.Information , MessageBoxResult.OK, MessageBoxOptions.RtlReading | MessageBoxOptions.RightAlign );
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            
            NewfrmSearch.ShowDialog();
        }

        private void btnAddNews_Click(object sender, RoutedEventArgs e)
        {
            frmAddUpdateNews NewaddNews = new frmAddUpdateNews(null, this);
            NewaddNews.ShowDialog();
        }
    }
}
