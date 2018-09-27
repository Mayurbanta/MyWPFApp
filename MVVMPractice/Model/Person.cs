using System;
using System.ComponentModel;

namespace MVVMPractice.Model
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {

        private string fName;

        public string FName
        {
            get { return fName; }
            set
            {
                fName = value;
                //OnPropertyChanged(FName);
            }
        }

        private string lName;

        public string LName
        {
            get { return lName; }
            set
            {
                lName = value;
                //OnPropertyChanged(LName);
            }
        }

        private string fullName;

        public string FullName
        {
            get { return fullName = FName + " " + lName; }
            set
            {
                if (fullName != value)
                {
                    fullName = value;
                }
            }
        }

        public DateTime DateAdded { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(p));

        }

        #region IDataErrorInfo
        
        public string Error
        {
            get
            {
                return null;
            }
        }


        public string this[string PropertyName] //Indexer or Indexed Property
        {
            get
            {
                string result = string.Empty;

                switch (PropertyName)
                {
                    case "FName":
                        if (string.IsNullOrEmpty(FName))
                        {
                            result = "First Name is required";
                        }
                        break;

                    case "LName":
                        if (string.IsNullOrEmpty(FName))
                        {
                            result = "Last Name is required";
                        }
                        break;
                }
                return result;
            }
        }
        #endregion
    }
}
