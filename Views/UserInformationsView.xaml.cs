using EMA.Models;
using EMA.ViewModels;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class UserInformationsView : Page
    {
        private readonly UserInformationsViewModel _viewModel;
        public UserInformationsView(string sum, List<CartItem> cartItems)
        {
            InitializeComponent();

            _viewModel = new UserInformationsViewModel(sum,cartItems);
            DataContext = _viewModel;
            MainWindowView.SetTitle("Nutzer - Informationen");

            SaveChanges.Visibility = Visibility.Collapsed;
            Cancel.Visibility = Visibility.Collapsed;
        }

        private void GoBackButton(object sender, RoutedEventArgs e)
        {
            if(_viewModel.CartItemsFromOtherView.Count == 0)
            {
                NavigationService.Navigate(new MainView());
                return;
            }

            NavigationService.Navigate(new NewOrderOverviewView(_viewModel.SumCartFromOtherView, _viewModel.CartItemsFromOtherView));
        }

        private void EditCustomerDataButton(object sender, RoutedEventArgs e)
        {
            SaveChanges.Visibility = Visibility.Visible;
            Cancel.Visibility = Visibility.Visible;
            _viewModel.EnableTextBoxes();
            EditUserInfo.IsEnabled = false;
        }

        private void SaveChangesButton(object sender, RoutedEventArgs e)
        {
            _viewModel.SetNewCustomerData();
            EditUserInfo.IsEnabled = true;
            _viewModel.DisableTextBoxes();
            SaveChanges.Visibility = Visibility.Collapsed;
            Cancel.Visibility = Visibility.Collapsed;
            //Todo: In Datenbank speichern
        }

        private void CancelButton(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show(
                "Sind Sie sicher, dass Sie die eingegebenen Daten nicht übernehmen möchten?",
                "Bearbeitung abbrechen", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    _viewModel.SetCustomerDataWhenCancelled();
                    EditUserInfo.IsEnabled = true;
                    _viewModel.DisableTextBoxes();
                    SaveChanges.Visibility = Visibility.Collapsed;
                    Cancel.Visibility = Visibility.Collapsed;
                    break;
                case MessageBoxResult.No:
                    return;
            }
        }
    }
}
