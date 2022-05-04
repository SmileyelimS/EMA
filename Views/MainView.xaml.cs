using EMA.Models;
using EMA.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EMA.Views
{
    public partial class MainView : Page
    {
        private readonly MainViewModel _viewModel;
        public MainView()
        {
            InitializeComponent();

            _viewModel = new MainViewModel();
            DataContext = _viewModel;
            MainWindowView.SetTitle("");
        }

        private void GoToNewOrderButton(object sender, RoutedEventArgs e)
        {
            List<CartItem> emptyCartItemList = new List<CartItem>();
            NavigationService.Navigate(new NewOrderView("0 €", emptyCartItemList));
        }

        private void GoToOldOrdersOverviewButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OldOrdersOverviewView());
        }

        private void GoToUserInformationsButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserInformationsView());
        }
    }
}
