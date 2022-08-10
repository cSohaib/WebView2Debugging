using WebView2Debugging.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WebView2Debugging
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            var mainWindow = new MainWindow();
            mainWindow.DataContext = GetMainVM();
            mainWindow.Show();
        }

        private MainVM GetMainVM()
        {
            var mainVM = new MainVM();

            var webViewVM = new WebViewVM { URL = "https://www.google.com/" };

            var somethingElseVM = new SomethingElseVM { Text = "Some random text" };

            mainVM.ShowWebView = new Command(() => mainVM.CurrentViewModel = webViewVM);
            mainVM.ShowSomethingElse = new Command(() => mainVM.CurrentViewModel = somethingElseVM);

            return mainVM;
        }
    }
}
