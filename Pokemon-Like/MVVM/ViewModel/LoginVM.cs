using System.ComponentModel;
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
                SetProperty(ref _username, value);
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                SetProperty(ref _password, value);
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand LoginCommand { get; set; }

        public LoginVM() : base()
        {
            LoginCommand = new RelayCommand(Login);
        }

        public void Login()
        {
            MessageBox.Show($"Username: {Username}\nPassword: {Password}");
        }
    }
}
