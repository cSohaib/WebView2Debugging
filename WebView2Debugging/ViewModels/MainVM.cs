using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace WebView2Debugging.ViewModels
{
    public class MainVM : ViewModel
    {

        private ICommand _ShowWebView;
        public ICommand ShowWebView { get => _ShowWebView; set => SetProperty(ref _ShowWebView, value); }

        private ICommand _ShowSomethingElse;
        public ICommand ShowSomethingElse { get => _ShowSomethingElse; set => SetProperty(ref _ShowSomethingElse, value); }

        private ViewModel _CurrentViewModel;
        public ViewModel CurrentViewModel { get => _CurrentViewModel; set => SetProperty(ref _CurrentViewModel, value); }
    }
}
