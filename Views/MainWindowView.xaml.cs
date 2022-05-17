using EMA.Views;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace EMA
{
    public partial class MainWindowView : Window
    {
        private static Window mainWindow;

        private readonly MainWindowViewModel _viewModel;
        public MainWindowView()
        {
            mainWindow = this;

            InitializeComponent();
            Main.Content = new MainView();
            
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;
            _viewModel.SetWindowStateImage(WindowState);
        }

        private void Rectangle_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnReduceOrMaximize_Click(object sender, RoutedEventArgs e)
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
            _viewModel.SetWindowStateImage(WindowState);
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        public static void SetTitle(string title)
        {
            mainWindow.Title = title;
        }
    }
}
