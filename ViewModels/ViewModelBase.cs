using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace EMA
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string _windowStateImage;
        public string WindowStateImage
        {
            get { return _windowStateImage; }
            set
            {
                _windowStateImage = value;
                OnPropertyChange();
            }
        }

        public void SetWindowStateImage(WindowState windowState)
        {
            switch (windowState)
            {
                case WindowState.Normal:
                    WindowStateImage = @"\Resources\maximize.png";
                    break;
                case WindowState.Maximized:
                    WindowStateImage = @"\Resources\reduce.png";
                    break;
            }
        }
    }
}