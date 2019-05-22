using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWPFApp
{
    public class ComboBoxesViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));

        }
        //public ObservableCollection<MyColors> ColorCollcation;

        private ObservableCollection<MyColors> _colorCollcation;

        public ObservableCollection<MyColors> ColorCollcation
        {
            get { return _colorCollcation; }
            set { _colorCollcation = value; }
        }



        private MyColors _selectedColor;

        public MyColors SelectedColor
        {
            get { return _selectedColor; }
            set
            {
                _selectedColor = value;
                NotifyPropertyChanged("SelectedColor");
            }
        }


        public ComboBoxesViewModel()
        {
            MyColors green = new MyColors
            {
                ColorId = 2,
                ColorName = "Green"
            };

            ColorCollcation = new ObservableCollection<MyColors>
            {
                new MyColors { ColorId = 1, ColorName = "Red" },
                green,
                new MyColors { ColorId = 3, ColorName = "Blue" }
            };

            SelectedColor = green;
        }

    }
    public class MyColors
    {
        public int ColorId { get; set; }
        public string ColorName { get; set; }
    }


}
