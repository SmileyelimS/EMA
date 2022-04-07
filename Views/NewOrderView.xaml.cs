using EMA.ViewModels;
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
    }
}
