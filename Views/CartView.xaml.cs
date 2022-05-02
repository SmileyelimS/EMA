using EMA.ViewModels;
using System.Windows.Controls;

namespace EMA.Views
{
    public partial class CartView : Page
    {
        private readonly CartViewmodel _viewModel;
        public CartView()
        {
            InitializeComponent();

            _viewModel = new CartViewmodel();
            DataContext = _viewModel;
            MainWindowView.SetTitle("Warenkorb");
        }
    }
}
