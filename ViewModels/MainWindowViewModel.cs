using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EMA
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            Age = 12;
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { OnPropertyChange(); _name = value; }
        }

        private int _age;

        public int Age
        {
            get { return _age; }
            set 
            { 
                _age = value; 
                OnPropertyChange();
            }
        }

        public void SetAge(int age)
        {
            Age = age;
        }
    }
}