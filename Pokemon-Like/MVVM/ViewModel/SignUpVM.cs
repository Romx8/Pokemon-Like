using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Pokemon_Like.Model;
using Pokemon_Like.MVVM.View;

namespace Pokemon_Like.MVVM.ViewModel
{
    public class SignUpVM : BaseVM
    {
        private readonly LogicBDD _LogicBDD;
        public ICommand SignUpCommand { get; set; }

        public SignUpVM() : base()
        {
            SignUpCommand = new RelayCommand(SignUp);
            var dbContext = new ExerciceMonsterContext();
            _LogicBDD = new LogicBDD(dbContext);
        }

        public void SignUp()
        {
            if (_LogicBDD.Register(Username, Password))
            {
                MainWindowVM.OnRequestVMChange?.Invoke(new MonsterVM());
            }
        }

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

    }
}
