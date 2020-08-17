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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DailyNews.VideoElementNS
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class VideoElement : UserControl
    {

        public string VideoSource
        {
            get { return (string)GetValue(VideoSourceProperty); }
            set { SetValue(VideoSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for VideoSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty VideoSourceProperty =
            DependencyProperty.Register("VideoSource", typeof(string), typeof(VideoElement));



        public VideoElement()
        {
            InitializeComponent();         
        }
        // Play the media.
        void OnMouseDownPlayMedia(object sender, MouseButtonEventArgs args)
        {
            // The Play method will begin the media if it is not currently active or
            // resume media if it is paused. This has no effect if the media is
            // already running. 
            VideoPlayer.Play();
        }

        // Pause the media.
        void OnMouseDownPauseMedia(object sender, MouseButtonEventArgs args)
        {

            // The Pause method pauses the media if it is currently running.
            // The Play method can be used to resume.

            VideoPlayer.Pause();
        }

        // Stop the media.
        void OnMouseDownStopMedia(object sender, MouseButtonEventArgs args)
        {

            // The Stop method stops and resets the media to be played from
            // the beginning.
            VideoPlayer.Stop();
        }



        // When the media playback is finished. Stop() the media to seek to media start.
        private void Element_MediaEnded(object sender, EventArgs e)
        {
            VideoPlayer.Stop();
        }

        private void Grid_MouseEnter(object sender, MouseEventArgs e)
        {
            Bar.Visibility = Visibility.Visible;
        }

        private void Grid_MouseLeave(object sender, MouseEventArgs e)
        {
            Bar.Visibility = Visibility.Collapsed;
        }
    }
}
