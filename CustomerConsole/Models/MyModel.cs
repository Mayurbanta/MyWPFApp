using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConsole.Models
{
    public class MyModel : INotifyPropertyChanged
    {        
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string p)
        {
            PropertyChangedEventHandler ph = PropertyChanged;
            if (ph != null)
                ph(this, new PropertyChangedEventArgs(p));

        }

        private string _MyRandomData;

        public string MyRandomData
        {
            get { return _MyRandomData; }
            set {
                _MyRandomData = value;
                OnPropertyChanged(MyRandomData);
            }
        }


    }
}
