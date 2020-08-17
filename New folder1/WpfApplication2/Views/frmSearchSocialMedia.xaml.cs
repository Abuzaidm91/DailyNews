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
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class frmSearchSocialMedia : Window
    {
        frmSocialMedia frmSocialMedia;
        public frmSearchSocialMedia(frmSocialMedia frmSocialMedia)
        {
            InitializeComponent();
            setValuesForFields(); // To get values for Filds from database
            this.frmSocialMedia = frmSocialMedia;
        }

        private void setValuesForFields()
        {
            // To get values for Observers 'الراصد'
            ObservableCollection<string> GetAllObservors = DataBaseManager.GetAllObservors();
            GetAllObservors.Add("الكل");
            cbxObserver.ItemsSource = GetAllObservors;
        }


        // remember that
        private void radioPeriod_Click(object sender, RoutedEventArgs e)
        {
             dpFrom.IsEnabled = radioPeriod.IsChecked.Value;
             dpTo.IsEnabled = radioPeriod.IsChecked.Value;
        }
        private void radioPeriod_Unchecked(object sender, RoutedEventArgs e)
        {
              dpFrom.IsEnabled = radioPeriod.IsChecked.Value;
              dpTo.IsEnabled = radioPeriod.IsChecked.Value;
        }


        private void Title_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }



        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
             Nullable<DateTime> pStartDate;
             Nullable<DateTime> pEndDate;
            if (radioToday.IsChecked == true)
            {

                pStartDate = DateTime.Today;
                pEndDate = DateTime.Today;
            }
            else if (radioAllNews.IsChecked == true)
            {
                pStartDate = null;
                pEndDate = null;
            }
            else
            {
                pStartDate = dpFrom.SelectedDate;
                pEndDate = dpTo.SelectedDate;
            }


            Nullable<Boolean> IsRead;
            if (radioAllViews.IsChecked == true)
            {
                IsRead = null;
            }
            else if (radioViewed.IsChecked == true)
            {
                IsRead = true;
            }
            else
            {
                IsRead = false;
            }


            string Region;
            if (radioGlobalLocal.IsChecked == true)
            {
                Region = null;
            }
            else if (radioGlobal.IsChecked == true)
            {
                Region = "دولي";
            }
            else
            {
                Region = "المحلي";
            }


            string Observer;
            if (cbxObserver.SelectedItem as string == "الكل")
            {
                Observer = null;
            }
            else
            {
                Observer = cbxObserver.SelectedItem as string;
            }




            string KeyWord;
            if ( string.IsNullOrEmpty(cbxKeyword.Text))
            {
                KeyWord = null;
            }
            else
            {
                KeyWord = cbxKeyword.Text;
            }


            frmSocialMedia.SetSearchedPostsProperties(pStartDate, pEndDate, IsRead, Region , Observer, KeyWord);
            this.Hide();
        }
    }
}
