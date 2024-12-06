using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Pokemon_Like.Model;
using Pokemon_Like.MVVM.View;

namespace Pokemon_Like.MVVM.ViewModel
{
    internal class LoginVM : BaseVM
    {
        private readonly LogicBDD _LogicBDD;

        public Action RedirectToHome { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginVM() : base()
        {
            LoginCommand = new RelayCommand(Login);
             var dbContext = new ExerciceMonsterContext();
            _LogicBDD = new LogicBDD(dbContext);
        }

        public void Login()
        {
            if (_LogicBDD.Login(Username, Password))
            {
                var context = new ExerciceMonsterContext();
                MainWindowVM.OnRequestVMChange?.Invoke(new MonsterVM());
            }
        }

        private string _username;
        private string _password;
        private MonsterVM _monsterVM;

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
    }
}
