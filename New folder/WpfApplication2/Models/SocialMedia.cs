using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyNew.Models
{
    public class SocialMedia : INotify, ICloneable
    {

            //This Clone Property to get assiged by value not refernce
            public SocialMedia Clone() { return (SocialMedia)this.MemberwiseClone(); }
            object ICloneable.Clone() { return Clone(); }






            //***********************************
            // Id
            public long Id { get; set; }
            //***********************************





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
            private List<string> _image = new List<string>();
            public List<string> Image
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

