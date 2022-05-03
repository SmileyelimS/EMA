using EMA.Models;
using EMA.ViewModels;
using System.Data;
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

        private void GoToOverviewButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderOverviewView());
        }

        private void GoToCartButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new CartView());
        }

        private void AddToCartButton(object sender, RoutedEventArgs e)
        {
            Items clickedItem = (Items)((Button)e.Source).DataContext;
            _viewModel.AddToCart(clickedItem);
        }

        private void PlaceholderSearchbar_GotFocus(object sender, RoutedEventArgs e)
        {
            PlaceholderSearchbar.Visibility = Visibility.Collapsed;
            Searchbar.Focus();
        }

        private void Searchbar_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Searchbar.Text))
            {
                PlaceholderSearchbar.Visibility = Visibility.Visible;
            }
        }
    }
}
