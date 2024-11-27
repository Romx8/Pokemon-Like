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
    internal class SignUpVM : BaseVM
    {
        public ICommand SignUpCommand { get; set; }
        public ICommand RequestMainView { get; set; }

        public SignUpVM() 
        {
            SignUpCommand = new RelayCommand(SignUp);
            RequestMainView = new RelayCommand(HandleRequestMainView);
        }

        public void SignUp() 
        {
            MessageBox.Show("ok");
        }

        public void HandleRequestMainView()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new MainViewVM());
        }
    }
}
