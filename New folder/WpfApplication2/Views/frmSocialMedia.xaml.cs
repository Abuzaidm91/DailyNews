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
    public partial class frmSocialMedia : UserControl
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
        public frmSocialMedia()
        {           
            InitializeComponent();
            initilizeTimerForHiddenLight();
            GetNews();
          //  NewfrmSearch = new frmSearch(this);
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
                this.Region, this.Resource, this.Observer, this.KeyWord);
            NewsList.ItemsSource = null;
            NewsList.ItemsSource = news;
        }

        private void initilizeTimerForHiddenLight()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < NewsList.Items.Count; i++)
            {
                ContentPresenter c = (ContentPresenter)NewsList.ItemContainerGenerator.ContainerFromItem(NewsList.Items[i]);
                Border item = c.ContentTemplate.FindName("item", c) as Border;
                Border Secret = c.ContentTemplate.FindName("Secret", c) as Border;
                var news = item.DataContext as News;
                if (news.IsHidden == true)
                {
                    if (Secret.Visibility == Visibility.Hidden)
                    {
                        Secret.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        Secret.Visibility = Visibility.Hidden;
                    }
                }
            }
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
         //   var frmView = new frmViewNews(news, value,this);
         //   frmView.ShowDialog();
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

        private void Container_Loaded(object sender, RoutedEventArgs e)
        {

              /*for (int i = 0; i < NewsList.Items.Count; i++)
              {
                  ContentPresenter c = (ContentPresenter)NewsList.ItemContainerGenerator.ContainerFromItem(NewsList.Items[i]);
                  TextBlock DateAndTime = c.ContentTemplate.FindName("DateAndTime", c) as TextBlock;
                  DateAndTime.Language = XmlLanguage.GetLanguage("ar-JO");
                  DateAndTime.Text = ConvertToEasternNum.ConvertToEasternArabicNumerals(DateAndTime.Text);
              }*/
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            
            NewfrmSearch.ShowDialog();
        }

        private void btnAddUpdateSocialMedia_Click(object sender, RoutedEventArgs e)
        {
           frmAddUpdatesSocialMedia NewaddUpdateScialMedia = new frmAddUpdatesSocialMedia(null, this);
            NewaddUpdateScialMedia.ShowDialog();
        }


    }
}
