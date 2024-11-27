﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Pokemon_Like.MVVM.ViewModel
{
    internal class LoginVM : BaseVM
    {
        private string _username;
        private string _password;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public ICommand LoginCommand { get; set; }
        public ICommand RequestMainView { get; set; }

        public LoginVM()
        {
            LoginCommand = new RelayCommand(Login);
            RequestMainView = new RelayCommand(HandleRequestMainView);
        }

        public void Login()
        {
            MessageBox.Show($"Username: {Username}\nPassword: {Password}");
        }


        public void HandleRequestMainView()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new MainViewVM());
        }
    }
}
