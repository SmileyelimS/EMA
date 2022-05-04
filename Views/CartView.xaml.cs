using EMA.Models;
using EMA.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class CartView : Page
    {
        private readonly CartViewModel _viewModel;
        public CartView(Dictionary<Items, int> dictionaryCartItems, string sum)
        {
            InitializeComponent();

            _viewModel = new CartViewModel(dictionaryCartItems, sum);
            DataContext = _viewModel;
            MainWindowView.SetTitle("");
        }

        

        private void BackToNewOrder(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderView());
        }

        private void GoToOverviewButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderOverviewView());
        }
    }
}
