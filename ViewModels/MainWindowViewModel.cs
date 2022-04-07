using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace EMA
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
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