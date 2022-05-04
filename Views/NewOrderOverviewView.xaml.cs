using EMA.ViewModels;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class NewOrderOverviewView : Page
    {
        private readonly NewOrderOverviewViewModel _viewModel;
        public NewOrderOverviewView()
        {
            InitializeComponent();

            _viewModel = new NewOrderOverviewViewModel();
            DataContext = _viewModel;
            MainWindowView.SetTitle("Bestellübersicht");
        }
    }
}
