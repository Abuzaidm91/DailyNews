using DailyNew.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MessageBox = System.Windows.MessageBox;

namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for AddNews.xaml
    /// </summary>
    public partial class frmAddUpdateNews : Window
    {
        News News_Reflected; // referenced to original object
        News News_NotReflected;// Not referenced to original object
        frmNews frmNews;
        CustomMessageBox messageBox;
        public frmAddUpdateNews(News pNews , frmNews frmNews)
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50;     
            this.News_Reflected = pNews;
            this.frmNews = frmNews;

            // this for to take clone of news and when save it will reflect to original
            if (News_Reflected != null)
            {
                this.News_NotReflected = (News)pNews.Clone();
            }
            else
            {
                this.News_NotReflected = new News();
                this.News_NotReflected.DateAndTime = DateTime.Now;
            }

            this.DataContext = this.News_NotReflected;

            SetValues();
        }

        private void SetValues()
        {
            cbxResources.ItemsSource = DataBaseManager.GetAllResources();
            cbxObservers.ItemsSource = DataBaseManager.GetAllObservors();
            cbxAuthers.ItemsSource = DataBaseManager.GetAllAuthers();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btnOpenFileImage_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                News_NotReflected.Image = openFileDialog.FileName;
            }
        }

        private void btnOpenFileVedio_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                News_NotReflected.Video = openFileDialog.FileName;
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitle.Text)     ||
                String.IsNullOrEmpty(cbxResources.Text) ||
                String.IsNullOrEmpty(cbxAuthers.Text)   ||
                String.IsNullOrEmpty(txtDetails.Text)   ||
                String.IsNullOrEmpty(cbxObservers.Text) ||
                String.IsNullOrEmpty(dtpDatePicker.Text)||
                String.IsNullOrEmpty(cbxRegion.Text))   
            {
                messageBox = new CustomMessageBox(CustomMessageBox.MessangeType.Information, "هنالك حقول فارغة","تأكد من إدخال كافة الحقول المطلوبة");
                messageBox.Show();
                return; 
            }
            
            UpdateNews();
            InsertOrUpdateDataBase();

            // If this news is new it will create new news automatically
            if (News_Reflected is null)  // there is no origin object this object is new
            {
                // create new news
                News_NotReflected = new News(); 

                // add Previous news data to new news
                News_NotReflected.Observer = this.cbxObservers.Text;
                News_NotReflected.DateAndTime = DateTime.Now;
                News_NotReflected.Resource = cbxResources.Text;

                // Binding new news to form
                this.DataContext = News_NotReflected; 
            }
            else
            {
                this.Close();
            }
        }

        private void UpdateNews()
        {
            // update original object (news)
            if (News_Reflected is null) return; // there is no origin object this object is new

            News_Reflected.Title = News_NotReflected.Title;
            News_Reflected.DateAndTime = News_NotReflected.DateAndTime;
            News_Reflected.Author = News_NotReflected.Author;
            News_Reflected.Details = News_NotReflected.Details;
            News_Reflected.Resource = News_NotReflected.Resource;
            News_Reflected.Observer = News_NotReflected.Observer;
            News_Reflected.IsHidden = News_NotReflected.IsHidden;
            News_Reflected.Comment = News_NotReflected.Comment;
            News_Reflected.Image = News_NotReflected.Image;
            News_Reflected.Video = News_NotReflected.Video;
        }

        private void InsertOrUpdateDataBase()
        {
            DataBaseManager.InsertOrUpdateNews(News_NotReflected);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            frmNews.GetNews();
        }
    }
}
