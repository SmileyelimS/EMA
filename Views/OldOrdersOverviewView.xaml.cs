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
    }
}
