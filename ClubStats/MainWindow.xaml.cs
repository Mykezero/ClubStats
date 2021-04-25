using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace ClubStats
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _teamsJson = "teams.json";

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            string json = JsonConvert.SerializeObject(ViewModel.Teams);
            File.WriteAllText(_teamsJson, json);
        }

        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

            ViewModel = new MainWindowViewModel();

            if (File.Exists(_teamsJson) && !string.IsNullOrEmpty(File.ReadAllText(_teamsJson)))
            {
                ViewModel.Teams = JsonConvert.DeserializeObject<string>(File.ReadAllText(_teamsJson));
            }
        }

        private MainWindowViewModel ViewModel
        {
            get => (MainWindowViewModel) DataContext;
            set => DataContext = value;
        }
    }
}