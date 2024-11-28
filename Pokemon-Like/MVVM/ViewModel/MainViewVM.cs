using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Pokemon_Like.MVVM.ViewModel
{
    public class MainViewVM : BaseVM
    {
        public ICommand RequestLoginView { get; set; }
        public ICommand RequestSignUpView { get; set; }
        public ICommand RequestSettingsView { get; set; }

        public MainViewVM()
        {
            RequestLoginView = new RelayCommand(HandleRequestLoginView);
            RequestSignUpView = new RelayCommand(HandleRequestSignUpView);
            RequestSettingsView = new RelayCommand(HandleRequestSettingsView);
        }

        public void HandleRequestLoginView()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new LoginVM());
        }
        public void HandleRequestSignUpView()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new SignUpVM());
        } 
        public void HandleRequestSettingsView()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new SettingsVM());
        }
    }
}
