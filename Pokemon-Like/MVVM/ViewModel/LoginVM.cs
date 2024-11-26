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
    internal class LoginVM : BaseVM
    {
        public LoginVM()
        {
            LoginCommand = new RelayCommand(Login);
        }

        public ICommand LoginCommand;

        public void Login()
        {
            MessageBox.Show("Login");
        }
    }
}
