using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;

namespace Pokemon_Like.MVVM.ViewModel
{
    public class MainViewVM : BaseVM
    {
        public MainViewVM()
        {
            RequestLoginView = new RelayCommand(HandleRequestLoginView);
        }

        public ICommand RequestLoginView;

        public void HandleRequestLoginView()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new LoginVM());
        }
    }
}
