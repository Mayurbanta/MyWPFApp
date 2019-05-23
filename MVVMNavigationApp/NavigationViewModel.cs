using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMNavigationApp
{
   public class NavigationViewModel: INotifyPropertyChanged
    {
        public ICommand EmpCommand { get; set; }

        public ICommand DeptCommand { get; set; }

        private object selectedViewModel;

        public object SelectedViewModel

        {

            get { return selectedViewModel; }

            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }

        }


        public NavigationViewModel()

        {

            EmpCommand = new BaseCommand(OpenEmp);

            DeptCommand = new BaseCommand(OpenDept);

        }

        private void OpenEmp(object obj)
        {
            SelectedViewModel = new EmployeeViewModel();
        }
        private void OpenDept(object obj)
        {
            SelectedViewModel = new DepartmentViewModel();
        }




        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)

        {

            if (PropertyChanged != null)

            {

                PropertyChanged(this, new PropertyChangedEventArgs(propName));

            }

        }

    }

    public class BaseCommand : ICommand
    {
        private Predicate<object> _canExecute;
        private Action<object> _method;
        public event EventHandler CanExecuteChanged;

        public BaseCommand(Action<object> method)
            : this(method, null)
        {
        }

        public BaseCommand(Action<object> method, Predicate<object> canExecute)
        {
            _method = method;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute == null)
            {
                return true;
            }

            return _canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            _method.Invoke(parameter);
        }
    }
}
