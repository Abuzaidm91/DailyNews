using MaterialDesignThemes.Wpf.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace DailyNew.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class CustomMessageBox : Window
    {
        public enum MessangeType
        {
            Information, Exclamation
        }
        public CustomMessageBox(MessangeType messangeType,string MessageTitle, string MessageDescription)
        {
            InitializeComponent();
            tbkTitle.Text = MessageTitle;
            tbkDescription.Text = MessageDescription;
            if (messangeType == MessangeType.Exclamation)
            {
                Image.Source = new BitmapImage(new Uri(@"C:\Users\NCO\Desktop\New folder (3)\New folder\WpfApplication2\Images\Button-Info-icon.png"));
            }
            else
            {
                Image.Source = new BitmapImage(new Uri(@"C:\Users\NCO\Desktop\New folder (3)\New folder\WpfApplication2\Images\Exclamation-icon.png"));
            }
            var desktopWorkingArea = System.Windows.SystemParameters.WorkArea;
            this.Left = desktopWorkingArea.Right - this.Width;
            this.Top = desktopWorkingArea.Bottom - this.Height;
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
