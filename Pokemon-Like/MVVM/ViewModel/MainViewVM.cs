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

        public MainViewVM()
        {
            RequestLoginView = new RelayCommand(HandleRequestLoginView);
        }

        public void HandleRequestLoginView()
        {
            MessageBox.Show("Change VM");
            MainWindowVM.OnRequestVMChange?.Invoke(new LoginVM());
        }
    }
}
