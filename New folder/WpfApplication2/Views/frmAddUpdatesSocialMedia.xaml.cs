using DailyNew.Models;
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

namespace DailyNews.Views
{
    /// <summary>
    /// Interaction logic for AddNews.xaml
    /// </summary>
    public partial class frmAddUpdatesSocialMedia : Window
    {
        SocialMedia SocialMediaPost_Reflected; // referenced to original object
        SocialMedia SocialMediaPost_NotReflected;// Not referenced to original object 
        frmSocialMedia frmNews;
        CustomMessageBox messageBox;
        public frmAddUpdatesSocialMedia(SocialMedia pSocialMediaPost, frmSocialMedia frmSocialMedia)
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height - 50;     
            this.SocialMediaPost_Reflected = pSocialMediaPost;
            this.frmNews = frmSocialMedia;

            // this for to take clone of SocialMediaPost and when save it will reflect to original
            if (pSocialMediaPost != null)
            {
                // this means this post exists and will take copy(clone) of it
                this.SocialMediaPost_NotReflected = (SocialMedia)pSocialMediaPost.Clone();
            }
            else
            {
                // this means this post doent exists (new post)
                this.SocialMediaPost_NotReflected = new SocialMedia();
                this.SocialMediaPost_NotReflected.DateAndTime = DateTime.Now;
            }

            this.DataContext = this.SocialMediaPost_NotReflected;
            this.Images.ItemsSource = this.SocialMediaPost_NotReflected.Image;

            SetValues();
        }

        private void SetValues()
        {
            cbxObservers.ItemsSource = DataBaseManager.GetAllObservors();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TitleBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void AddImage_MouseDown(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                SocialMediaPost_NotReflected.Image.Add(openFileDialog.FileName);
            }
            this.Images.ItemsSource = null;
            this.Images.ItemsSource = SocialMediaPost_NotReflected.Image;
        }


        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtTitle.Text)     ||
                String.IsNullOrEmpty(cbxObservers.Text) ||
                String.IsNullOrEmpty(dtpDatePicker.Text)||
                String.IsNullOrEmpty(cbxRegion.Text))   
            {
                messageBox = new CustomMessageBox(CustomMessageBox.MessangeType.Information, "هنالك حقول فارغة","تأكد من إدخال كافة الحقول المطلوبة");
                messageBox.Show();
                return; 
            }

                UpdatePost();
                InsertOrUpdateDataBase();
                this.Close();     
        }

        private void UpdatePost()
        {
            // update original object (news)
            if (SocialMediaPost_Reflected is null) return; // there is no origin object this object is new
            SocialMediaPost_Reflected.Title = SocialMediaPost_NotReflected.Title;
            SocialMediaPost_Reflected.DateAndTime = SocialMediaPost_NotReflected.DateAndTime;
            SocialMediaPost_Reflected.Observer = SocialMediaPost_NotReflected.Observer;
            SocialMediaPost_Reflected.IsHidden = SocialMediaPost_NotReflected.IsHidden;
            SocialMediaPost_Reflected.Comment = SocialMediaPost_NotReflected.Comment;
            SocialMediaPost_Reflected.Image = SocialMediaPost_NotReflected.Image;
        }

        private void InsertOrUpdateDataBase()
        {
           // DataBaseManager.InsertOrUpdateNews(SocialMediaPost_NotReflected);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            frmNews.GetNews();
        }

        private void DeleteImage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Controls.Image DeleteButtonSender = (System.Windows.Controls.Image )sender;
            SocialMediaPost_NotReflected.Image.Remove(DeleteButtonSender.DataContext.ToString());        
            this.Images.ItemsSource = null;
            this.Images.ItemsSource = SocialMediaPost_NotReflected.Image;
        }
    }
}
