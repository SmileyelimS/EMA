using EMA.Models;
using EMA.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMA.Views
{
    /// <summary>
    /// Interaction logic for OldOrderView.xaml
    /// </summary>
    public partial class OldOrderView : Page
    {
        private readonly OldOrderViewModel _viewModel;
        public OldOrderView(Orders oldOrder)
        {
            InitializeComponent();

            _viewModel = new OldOrderViewModel(oldOrder);
            DataContext = _viewModel;
            MainWindowView.SetTitle($"Bestellung vom {_viewModel.OldOrder.DateTimeText}");
        }

        private void BackToOverviewButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OldOrdersOverviewView());
        }

        private void GoToStartPageButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainView());
        }
    }
}
