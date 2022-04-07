﻿using EMA.ViewModels;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EMA.Views
{
    public partial class MainView : Page
    {
        private readonly MainViewModel _viewModel;
        public MainView()
        {
            InitializeComponent();

            _viewModel = new MainViewModel();
            DataContext = _viewModel;
        }

        private void GoToNewOrderButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NewOrderView());
        }
        private void GoToOldOrdersOverviewButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OldOrdersOverviewView());
        }
        private void GoToUserInformationsButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserInformationsView()
);
        }
    }
}
