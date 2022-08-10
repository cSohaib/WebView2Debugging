using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WebView2Debugging.ViewModels
{
    public class WebViewVM : ViewModel
    {
        private string _URL;
        public string URL { get => _URL; set => SetProperty(ref _URL, value); }
    }
}
