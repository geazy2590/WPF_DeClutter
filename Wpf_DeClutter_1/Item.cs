using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Reflection;

namespace Wpf_DeClutter_1
{
    public class Item : INotifyPropertyChanged
    {
        public int pId { get; set; }

        public string pName { get; set; }

        public string pCategory { get; set; }

        public string pDesc { get; set; }

        public string pContact { get; set; }

        public string pLocation { get; set; }

        public string pImage { get; set; }

        [XmlIgnore]
        public string pImagePath
        {
            get
            {
                string currentDirectory = Assembly.GetExecutingAssembly().Location;
                if (currentDirectory.Contains("\\bin\\Debug"))
                {
                    int index = currentDirectory.IndexOf("\\bin\\Debug");
                    currentDirectory = currentDirectory.Substring(0, index);
                }
                String returnPath = currentDirectory + @"\Resources\Images\" + pImage;
                //return @"\Resources\Images\" + pImage;
                return returnPath;
            }
        }

        public string pDate { get; set; }

        //public string isDisabled { get; set; }
        public string _isDisabled;
        public string isDisabled
        {
            get { return _isDisabled; }
            set
            {
                _isDisabled = value;
                OnPropertyChanged(new PropertyChangedEventArgs("isDisabled"));
            }
        }
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }


        public string pCreatedBy { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
