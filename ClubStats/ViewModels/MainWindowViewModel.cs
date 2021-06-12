using System;
using System.Collections.Generic;
using System.Linq;
using ClubStats.API;
using ClubStats.API.Helpers;
using Prism.Commands;
using Prism.Mvvm;

namespace ClubStats.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _teams;
        private static readonly NhlService NhlService;
        
        private const string StatsFile = "stats.csv";
        private const string SettingsFile = "teams.json";

        // ReSharper disable once MemberCanBePrivate.Global
        public string Teams
        {
            get => _teams;
            set => SetProperty(ref _teams, value);
        }
        
        // ReSharper disable once MemberCanBePrivate.Global
        public DelegateCommand DownloadCommand { get; set; }

        public MainWindowViewModel()
        {
            DownloadCommand = new DelegateCommand(Download);
        }

        static MainWindowViewModel()
        {
            NhlService = new NhlService(new NhlApi());
        }

        private void Download()
        {
            List<string> clubNames = Teams.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToList();
            NhlService.DownloadStats(clubNames, StatsFile);
        }

        public void OnInitialized()
        {
            Teams = IoHelper.LoadJson<string>(SettingsFile);
        }

        public void OnClosing()
        {
            IoHelper.SaveJson(SettingsFile, Teams);
        }
    }
}