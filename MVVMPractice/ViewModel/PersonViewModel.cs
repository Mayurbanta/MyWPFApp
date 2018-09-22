using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using MVVMPractice.Command;
using MVVMPractice.Model;

namespace MVVMPractice.ViewModel
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        public PersonViewModel()
        {
            this._person = new Person();
            this._people = new ObservableCollection<Person>();
        }

        private Person _person;

        public Person Person
        {
            get { return _person; }
            set
            {
                _person = value;
                NotifyPropertyChanged("Person");
            }
        }

        private ObservableCollection<Person> _people;

        public ObservableCollection<Person> People
        {
            get { return _people; }
            set
            {
                _people = value;
                NotifyPropertyChanged("People");
            }
        }

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
            People.Add(Person);
        }

        private bool CanSubmitExecute(object parameter)
        {
            if (string.IsNullOrEmpty(Person.FName) || string.IsNullOrEmpty(Person.LName))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void NotifyPropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));

        }
    }
}
