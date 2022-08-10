using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WebView2Debugging.ViewModels
{
    public class SomethingElseVM : ViewModel
    {
        private string _Text;
        public string Text { get => _Text; set => SetProperty(ref _Text, value); }
    }
}
