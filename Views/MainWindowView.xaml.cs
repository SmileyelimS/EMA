using System.Windows;
using System.Windows.Input;

namespace EMA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        private MainWindowViewModel _viewModel;
        public MainWindowView()
        {
            InitializeComponent();
            
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;
        }

        private void Rectangle_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnReduceOrMaximize_Click(object sender, RoutedEventArgs e)
        {
            switch(WindowState)
            {
                case WindowState.Normal:
                    WindowState = WindowState.Maximized;
                    break;
                case WindowState.Maximized:
                    WindowState = WindowState.Normal;
                    break;
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
    }
}
