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

namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for frmViewNews.xaml
    /// </summary>
    public partial class frmViewNews : Window
    {

        List<News> ListNews;
        News CurrentNews = new News();
        frmNews frmNews; // to refer to frmNews to be get updated after insertion or update
        public int ListLength
        {
            get { return (int)GetValue(ListLengthProperty); }
            set { SetValue(ListLengthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for myText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ListLengthProperty =
            DependencyProperty.Register("ListLength", typeof(int), typeof(frmViewNews), new PropertyMetadata(null));

        public int selectedOne
        {
            get { return (int)GetValue(selectedOneProperty); }
            set { SetValue(selectedOneProperty, value); }
        }

        // Using a DependencyProperty as the backing store for myText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty selectedOneProperty =
            DependencyProperty.Register("selectedOne", typeof(int), typeof(frmViewNews), new PropertyMetadata(null));

        public int CurrnetNewsNumber
        {
            get { return (int)GetValue(CurrnetNewsProperty); }
            set { SetValue(CurrnetNewsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for myText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrnetNewsProperty =
            DependencyProperty.Register("CurrnetNews", typeof(int), typeof(frmViewNews), new PropertyMetadata(null));
        public frmViewNews(List<News> ListNews, int PselectedOne , frmNews frmNews)
        {
            InitializeComponent();
            this.frmNews = frmNews;
            this.ListNews = ListNews;
            ListLength = ListNews.Count;
            this.selectedOne = PselectedOne;
            CurrnetNewsNumber = selectedOne + 1;
            tbkCurrentNewsNumber.DataContext = this;
            tbkTotalNewsNumber.DataContext = this;
            UpdateCurrentNews();
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50;
        }




        private void UpdateCurrentNews()
        {
            CurrentNews = ListNews[selectedOne] as News;
            this.DataContext = CurrentNews;
            DataBaseManager.SetNewsAsRead(CurrentNews.Id);
        }


        private void Next(object sender, RoutedEventArgs e)
        {
            if (selectedOne < ListLength - 1)
            {
                selectedOne++;
                CurrnetNewsNumber++;
                UpdateCurrentNews();
            }
        }

        private void Back(object sender, RoutedEventArgs e)
        {
            if (selectedOne > 0)
            {
                selectedOne--;
                CurrnetNewsNumber--;
                UpdateCurrentNews();
            }
        }

        private void First(object sender, RoutedEventArgs e)
        {
            selectedOne = 0;
            CurrnetNewsNumber = 1;
            UpdateCurrentNews();
        }

        private void Last(object sender, RoutedEventArgs e)
        {
            selectedOne = ListLength - 1;
            CurrnetNewsNumber = ListLength;
            UpdateCurrentNews();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            frmAddUpdateNews frmAddEditNews = new frmAddUpdateNews(ListNews[selectedOne], frmNews);
            this.Hide();
            frmAddEditNews.ShowDialog();
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

        private void ratings1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            ReaderRate readerRate = new ReaderRate(CurrentNews);
            readerRate.ShowDialog();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            frmNews.GetNews();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            DataBaseManager.DeleteCurrnetNews(CurrentNews.Id);
            this.Close();
        }
    }
    public class ConvertToEasternNumarics : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ConvertToEasternNum.ConvertToEasternArabicNumerals(value.ToString());
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }


}