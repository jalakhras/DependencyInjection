﻿using PeopleViewer.Presentation;
using PersonDataReader.CSV;
using PersonDataReader.Service;
using System.Windows;

namespace PeopleViewer
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            ComposeObject();
            Current.MainWindow.Title = "With Dependency Injection";
            Current.MainWindow.Show();
        }

        private static void ComposeObject()
        {
            var reader = new CSVReader();
            var viewModel = new PeopleViewModel(reader);
            Current.MainWindow = new PeopleViewerWindow(viewModel);
        }
    }
}
