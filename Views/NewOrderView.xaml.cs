using EMA.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class NewOrderView : Page
    {
        private readonly NewOrderViewModel _viewModel;
        public NewOrderView()
        {
            InitializeComponent();

            _viewModel = new NewOrderViewModel();
            DataContext = _viewModel;
            MainWindowView.SetTitle("Neue Bestellung erfassen");
        }

        private void GoBackToStartPageButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainView());
        }

        private void AddToCart(object sender, RoutedEventArgs e)
        {

        }
    }
}
