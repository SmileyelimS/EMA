using EMA.Models;
using EMA.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class NewOrderView : Page
    {
        private readonly NewOrderViewModel _viewModel;
        public NewOrderView(string sum, List<CartItem> cartItems)
        {
            InitializeComponent();

            _viewModel = new NewOrderViewModel(sum, cartItems);
            DataContext = _viewModel;
            MainWindowView.SetTitle("Neue Bestellung erfassen");
        }

        private void GoBackToStartPageButton(object sender, RoutedEventArgs e)
        {
            if(_viewModel.SumCart != "0 €")
            {
                MessageBoxResult result = MessageBox.Show(
                "Sind Sie sicher, dass Sie die Artikel im Warenkorb löschen und zur Startseite zurückkehren möchten?",
                "Bestellung abbrechen", MessageBoxButton.YesNo);
                switch (result)
                {
                    case MessageBoxResult.Yes:
                        NavigationService.Navigate(new MainView());
                        break;
                    case MessageBoxResult.No:
                        return;
                }
            }

            NavigationService.Navigate(new MainView());
        }

        private void GoToOverviewButton(object sender, RoutedEventArgs e)
        {
            if (_viewModel.SumCart != "0 €")
            {
                NavigationService.Navigate(new NewOrderOverviewView());
            }

            GoToOverview.IsEnabled = false;
        }

        private void GoToCartButton(object sender, RoutedEventArgs e)
        {
            if (_viewModel.SumCart != "0 €")
            {
                NavigationService.Navigate(new CartView(_viewModel.ItemsInCart, _viewModel.SumCart));
            }

            GoToCart.IsEnabled = false;
        }

        private void AddToCartButton(object sender, RoutedEventArgs e)
        {
            Items clickedItem = (Items)((Button)e.Source).DataContext;
            _viewModel.AddToCart(clickedItem);

            GoToOverview.IsEnabled = true;
            GoToCart.IsEnabled = true;
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
