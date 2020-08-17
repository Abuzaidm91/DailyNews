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
using DailyNew.Models;
using DailyNews.Converters;
namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class frmSocialMedia : UserControl
    {
        List<SocialMedia> Posts;
        frmSearchSocialMedia frmSearchSocialMedia;
        Nullable<DateTime> StartDate = null;
        Nullable<DateTime> EndDate = null;
        Nullable<Boolean> IsRead = null;
        string Region = null;
        string Observer = null;
        string KeyWord = null;
        Boolean IsFavourite = false;
        public frmSocialMedia()
        {           
            InitializeComponent();
            initilizeTimerForGetPosts();
            GetPosts();
            frmSearchSocialMedia = new frmSearchSocialMedia(this);
        }
       
        public void SetSearchedPostsProperties(Nullable<DateTime> StartDate, Nullable<DateTime> EndDate,
           Nullable<Boolean> IsRead, string Region, string Observer, string KeyWord)
        {
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.IsRead = IsRead;
            this.Region = Region;
            this.Observer = Observer;
            this.KeyWord = KeyWord;
            GetPosts();
        }


        public void GetPosts()
        {
            Posts = new List<SocialMedia>();
            Posts = DataBaseManager.GetSocialMedia(this.StartDate, this.EndDate, this.IsRead,
                this.Region, this.Observer, this.KeyWord, this.IsFavourite);
            PostsList.ItemsSource = null;
            PostsList.ItemsSource = Posts;
        }


        public void SetIsFavourite()
        {
            IsFavourite = !this.IsFavourite;
            GetPosts();
        }

        private void initilizeTimerForGetPosts()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += timer_Tick;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetPosts();
        }

        private void Notification_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Notification_Click");
        }

        private void item_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var borderSelected = (Border)sender;
            var newsSelected = (SocialMedia)borderSelected.DataContext;
            int value = Posts.FindIndex(item => item.Id == newsSelected.Id);
            var frmView = new frmViewSocialMediaPost(Posts, value, this);
            frmView.ShowDialog();
        }

        private void Favourite_Click(object sender, RoutedEventArgs e)
        {
            Button b1 = (Button)sender;
            var Post = (SocialMedia)b1.DataContext;
            Post.isFavourite = !(Post.isFavourite);
            DataBaseManager.SetFavouritePost(Post.Id);
            string str;
            if (Post.isFavourite == true)
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
            frmSearchSocialMedia.ShowDialog();
        }

        private void btnAddUpdateSocialMedia_Click(object sender, RoutedEventArgs e)
        {
           frmAddUpdatesSocialMedia NewaddUpdateScialMedia = new frmAddUpdatesSocialMedia(null, this);
            NewaddUpdateScialMedia.ShowDialog();
        }


    }
}
