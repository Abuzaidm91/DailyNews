using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DailyNews
{
    public class News : INotify , ICloneable
    {
        //This Clone Property to get assiged by value not refernce
        public News Clone() { return (News)this.MemberwiseClone(); }
        object ICloneable.Clone() { return Clone(); }   

        //***********************************
        // Id
        public long Id { get; set; }
        //***********************************


        public News ()
        {

        }


        //***********************************
        // Tilte    
        private string _title;
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
                OnpropertyChanged("Title");
            }
        }
        //***********************************


        //***********************************
        //Details
        private string _details;
        public string Details
        {
            get
            {
                return _details;
            }
            set
            {
                _details = value;
                OnpropertyChanged("Details");
            }
        }
        //***********************************


        //***********************************
        //DateAndTime
        private DateTime _dateAndTime;
        public DateTime DateAndTime
        {
            get
            {
                return _dateAndTime;
            }
            set
            {
                _dateAndTime = value;
                OnpropertyChanged("DateAndTime");
            }
        }
        //***********************************


        //***********************************
        //Observer
        private string _observer;
        public string Observer
        {
            get
            {
                return _observer;
            }
            set
            {
                _observer = value;
                OnpropertyChanged("Observer");
            }
        }
        //***********************************


        //***********************************
        //Author
        private string _author;
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
                OnpropertyChanged("Author");
            }
        }
        //***********************************



        //***********************************
        //Resource
        private string _resource;
        public string Resource
        {
            get
            {
                return _resource;
            }
            set
            {
                _resource = value;
                OnpropertyChanged("Resource");
            }
        }
        //***********************************


        //***********************************
        //Region
        private string _region;
        public string Region
        {
            get
            {
                return _region;
            }
            set
            {
                _region = value;
                OnpropertyChanged("Region");
            }
        }
        //***********************************



        //***********************************
        //Image
        private string _image;
        public string Image
        {
            get
            {
                return _image;
            }
            set
            {
                _image = value;
                OnpropertyChanged("Image");
            }
        }
        //***********************************




      



        //***********************************
        //Video
        private string _video;
        public string Video
        {
            get
            {
                return _video;
            }
            set
            {
                _video = value;
                OnpropertyChanged("Video");
            }
        }
        //***********************************



        //***********************************
        //IsHidden
        private Boolean _isHidden;
        public Boolean IsHidden
        {
            get
            {
                return _isHidden;
            }
            set
            {
                _isHidden = value;
                OnpropertyChanged("IsHidden");
            }
        }
        //***********************************


        //***********************************
        //Comment
        private string _comment;
        public string Comment
        {
            get
            {
                return _comment;
            }
            set
            {
                _comment = value;
                OnpropertyChanged("Comment");
            }
        }
        //***********************************



        //***********************************
        //Raters
        private int _raters;
        public int Raters
        {
            get
            {
                return _raters;
            }
            set
            {
                _raters = value;
                OnpropertyChanged("Raters");
            }
        }
        //***********************************


        /********************************************************************************************
        *                                                                                           *
        *  The following properties will be get by News_Readers  table (different according reader) *
        *                                                                                           *
        ********************************************************************************************/



        //***********************************
        //IsRead
        private Boolean _isRead;
        public Boolean IsRead
        {
            get
            {
                return _isRead;
            }
            set
            {
                _isRead = value;
                OnpropertyChanged("isRead");
            }
        }
        //***********************************


        //***********************************
        //IsRated
        private Boolean _isRated;
        public Boolean IsRated
        {
            get
            {
                return _isRated;
            }
            set
            {
                _isRated = value;
                OnpropertyChanged("IsRated");
            }
        }
        //***********************************


        //***********************************
        //ReaderRate
        private float _readerRate;
        public float ReaderRate
        {
            get
            {
                return _readerRate;
            }
            set
            {
                _readerRate = value;
                OnpropertyChanged("ReaderRate");
            }
        }
        //***********************************


        //***********************************
        //AllRates
        private float _totalRate;
        public float TotalRate
        {
            get
            {
                return _totalRate;
            }
            set
            {
                _totalRate = value;
                OnpropertyChanged("TotalRate");
            }
        }
        //***********************************



  
        //***********************************
        //IsFavourite
        private Boolean _isFavourite;
        public Boolean isFavourite
        {
            get
            {
                return _isFavourite;
            }
            set
            {
                _isFavourite = value;
                OnpropertyChanged("isFavourite");
            }
        }
        //***********************************


       

    }

    public class INotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnpropertyChanged(string name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
