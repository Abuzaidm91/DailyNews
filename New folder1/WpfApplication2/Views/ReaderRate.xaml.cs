using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class ReaderRate : Window
    {
        News news;
        int[] NewsRateAndCount = {0,0};
        public ReaderRate(News news)
        {
            InitializeComponent();
            this.news = news;
            this.DataContext = news;
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            int[] NewsRateAndCount = DataBaseManager.SetReaderRate(news.Id, (int)Slider.Value);
            news.Raters = NewsRateAndCount[0];
            news.TotalRate = NewsRateAndCount[1];
            this.Close();
        }
    }
}
