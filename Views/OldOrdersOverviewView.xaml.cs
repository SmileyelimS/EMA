using EMA.Models;
using EMA.ViewModels;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class OldOrdersOverviewView : Page
    {
        private readonly OldOrdersOverviewViewModel _viewModel;
        public OldOrdersOverviewView()
        {
            InitializeComponent();

            _viewModel = new OldOrdersOverviewViewModel();
            DataContext = _viewModel;
            MainWindowView.SetTitle("Übersicht alte Bestellungen");
        }

        private void GoToOldOrderView(object sender, System.Windows.RoutedEventArgs e)
        {
            Order clickedOrder = (Order)((Button)e.Source).DataContext;
            NavigationService.Navigate(new OldOrderView(clickedOrder));
        }

        private void BackToMainView(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainView());
        }
    }
}
