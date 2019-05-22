using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CustomerConsole.Commands;
using CustomerConsole.Models;


namespace CustomerConsole.ViewModels
{
    public class CustomerViewModel : INotifyPropertyChanged
    {
        #region Constructor
        public CustomerViewModel()
        {
            this._MyModel = new MyModel();
        } 
        #endregion

        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));

        } 
        #endregion

        #region Button Command

        private ICommand _SubmitCommand;
        public ICommand SubmitCommand
        {
            get
            {
                if (_SubmitCommand == null)
                {
                    _SubmitCommand = new RelayCommand(SubmitExecute, CanSubmitExecute, false);
                }
                return _SubmitCommand;
            }
        }

        private void SubmitExecute(object parameter)
        {
            int i = 1;
            i += 4;
        }

        private bool CanSubmitExecute(object parameter)
        {
            if (string.IsNullOrEmpty(MyModel.MyRandomData))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion

        #region Model
        private MyModel _MyModel;

        public MyModel MyModel
        {
            get { return _MyModel; }
            set
            {
                _MyModel = value;
                NotifyPropertyChanged("MyModel");
            }
        } 
        #endregion
        
    }
}
