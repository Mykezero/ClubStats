using System;
using System.ComponentModel;
using System.Windows;
using ClubStats.ViewModels;

namespace ClubStats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ViewModel.OnClosing();
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            ViewModel = new MainWindowViewModel();
            ViewModel.OnInitialized();
        }

        private MainWindowViewModel ViewModel
        {
            get => (MainWindowViewModel) DataContext;
            set => DataContext = value;
        }
    }
}