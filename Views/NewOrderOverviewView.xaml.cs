using EMA.Models;
using EMA.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class NewOrderOverviewView : Page
    {
        private readonly NewOrderOverviewViewModel _viewModel;
        public NewOrderOverviewView(string sumOrderItems, List<CartItem> orderItems)
        {
            InitializeComponent();

            _viewModel = new NewOrderOverviewViewModel(sumOrderItems, orderItems);
            DataContext = _viewModel;
            MainWindowView.SetTitle("Bestellübersicht");
        }

        private void BackToNewOrderButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderView(_viewModel.SumItemsForOrder, _viewModel.ItemsForOrder));
            _viewModel.DeleteEmptyOrderItem();
        }

        private void CompletePurchaseButton(object sender, RoutedEventArgs e)
        {
            if(_viewModel.BillViaAddress || _viewModel.BillViaEMail)
            {
                //Todo: In Datenbank speichern
                return;
            }

            MessageBox.Show("Sie müssen mindestens eine Option für die Rechnungsadresse auswählen.",
                "Bestellung abschließen nicht möglich!", MessageBoxButton.OK);
        }

        private void DeleteOrderButton(object sender, RoutedEventArgs e)
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

        private void ComboboxOrderOverview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _viewModel.CalculateOrderSum();
            _viewModel.CalculateTotalShipping();
            _viewModel.GetTotalPrice();
        }

        private void ChangeAddressButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserInformationsView(_viewModel.SumItemsForOrder, _viewModel.ItemsForOrder));
        }
    }
}
