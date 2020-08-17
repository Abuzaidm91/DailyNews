using DailyNews;
using DailyNews.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Markup;
using DailyNews.Converters;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using DailyNew.Models;

namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for frmViewNews.xaml
    /// </summary>
    public partial class frmViewSocialMediaPost : Window
    {

        List<SocialMedia> ListPosts;
        SocialMedia CurrentPost = new SocialMedia();
        frmSocialMedia frmSocialMedia; // to refer to frmNews to be get updated after insertion or update
        public int ListLength
        {
            get { return (int)GetValue(ListLengthProperty); }
            set { SetValue(ListLengthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for myText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListLengthProperty =
            DependencyProperty.Register("ListLength", typeof(int), typeof(frmViewSocialMediaPost), new PropertyMetadata(null));

        public int selectedOne
        {
            get { return (int)GetValue(selectedOneProperty); }
            set { SetValue(selectedOneProperty, value); }
        }

        // Using a DependencyProperty as the backing store for myText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty selectedOneProperty =
            DependencyProperty.Register("selectedOne", typeof(int), typeof(frmViewSocialMediaPost), new PropertyMetadata(null));

        public int CurrnetPostNumber
        {
            get { return (int)GetValue(CurrnetNewsProperty); }
            set { SetValue(CurrnetNewsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for myText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrnetNewsProperty =
            DependencyProperty.Register("CurrnetNews", typeof(int), typeof(frmViewSocialMediaPost), new PropertyMetadata(null));
        public frmViewSocialMediaPost(List<SocialMedia> ListPosts, int PselectedOne , frmSocialMedia frmSocialMedia)
        {
            InitializeComponent();
            this.frmSocialMedia = frmSocialMedia;
            this.ListPosts = ListPosts;
            ListLength = ListPosts.Count;
            this.selectedOne = PselectedOne;
            CurrnetPostNumber = selectedOne + 1;
            tbkCurrentPostNumber.DataContext = this;
            tbkTotalPostNumber.DataContext = this;
            UpdateCurrentPost();
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50;
        }




        private void UpdateCurrentPost()
        {
            CurrentPost = ListPosts[selectedOne] as SocialMedia;
            this.DataContext = CurrentPost;
            this.Images.ItemsSource = null;
            this.Images.ItemsSource = CurrentPost.Image;
            DataBaseManager.SetPostAsRead(CurrentPost.Id);
        }


        private void Next(object sender, RoutedEventArgs e)
        {
            if (selectedOne < ListLength - 1)
            {
                selectedOne++;
                CurrnetPostNumber++;
                UpdateCurrentPost();
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            if (selectedOne > 0)
            {
                selectedOne--;
                CurrnetPostNumber--;
                UpdateCurrentPost();
            }
        }

        private void First(object sender, RoutedEventArgs e)
        {
            selectedOne = 0;
            CurrnetPostNumber = 1;
            UpdateCurrentPost();
        }

        private void Last(object sender, RoutedEventArgs e)
        {
            selectedOne = ListLength - 1;
            CurrnetPostNumber = ListLength;
            UpdateCurrentPost();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            frmAddUpdatesSocialMedia frmAddEditPost = new frmAddUpdatesSocialMedia(ListPosts[selectedOne], frmSocialMedia);
            this.Hide();
            frmAddEditPost.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }



        private void Window_Closed(object sender, EventArgs e)
        {
            frmSocialMedia.GetPosts();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            DataBaseManager.DeleteCurrnetPost(CurrentPost.Id);
            this.Close();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            UpdateCurrentPost();
        }
    }

}