using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvvm_binding_styles.Model;
using System.Windows.Input;

namespace mvvm_binding_styles.ViewModel
{
    class ViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public ObservableCollection<Patient> Patients { get; set; }


        public ViewModel()
        {
            ObservableCollection<Patient> patients = new ObservableCollection<Patient>();
            patients.Add(new Patient("Jim", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim1", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim2", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim3", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim4", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim1", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim2", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim3", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim4", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim1", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim2", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim3", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim4", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim1", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim2", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim3", "Kirk", new DateTime(2243, 5, 8)));
            patients.Add(new Patient("Jim4", "Kirk", new DateTime(2243, 5, 8)));
            Patients = patients;
        }

        public ICommand ChangeItemBtnPressed
        {
            get { return new RelayCommand(param => changeItemBtnPressed()); }
        }

        private void changeItemBtnPressed()
        {
            Random rand = new Random();
            int n = rand.Next(0, 19);
            Selected = n;
        }

        private int _selected;
        public int Selected
        {
            get { return _selected; }
            set
            {
                _selected = value;
                OnPropertyChanged("Selected");
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private Action<object> commandTask;

        public RelayCommand(Action<object> extCommand)
        {
            commandTask = extCommand;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            commandTask(parameter);
        }
    }
}
