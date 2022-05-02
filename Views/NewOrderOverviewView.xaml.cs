using EMA.ViewModels;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class NewOrderOverviewView : Page
    {
        private readonly NewOrderOverviewViewmodel _viewModel;
        public NewOrderOverviewView()
        {
            InitializeComponent();

            _viewModel = new NewOrderOverviewViewmodel();
            DataContext = _viewModel;
            MainWindowView.SetTitle("Bestellübersicht");
        }
    }
}
