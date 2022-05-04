using EMA.Models;
using EMA.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class CartView : Page
    {
        private readonly CartViewModel _viewModel;
        public CartView(List<CartItem> cartItems, string sum)
        {
            InitializeComponent();

            _viewModel = new CartViewModel(cartItems, sum);
            DataContext = _viewModel;
            MainWindowView.SetTitle("");
        }

        private void BackToNewOrder(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderView(_viewModel.Sum, _viewModel.CartItems));
            _viewModel.DeleteEmptyCartItem(_viewModel.CartItems.ToList());
        }

        private void GoToOverviewButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderOverviewView());
        }

        private void ComboboxCart_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.CalculateSum();
        }
    }
}
