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
    public partial class UserInformationsView : Page
    {
        private readonly UserInformationsViewModel _viewModel;
        public UserInformationsView()
        {
            InitializeComponent();

            _viewModel = new UserInformationsViewModel();
            DataContext = _viewModel;
            MainWindowView.SetTitle("Nutzer - Informationen");
        }
    }
}
