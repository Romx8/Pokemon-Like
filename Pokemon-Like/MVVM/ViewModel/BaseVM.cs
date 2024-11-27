using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Pokemon_Like.MVVM.ViewModel
{
    public abstract class BaseVM : ObservableObject
    {
        public ICommand RequestMainView { get; set; }

        public BaseVM()
        {
            RequestMainView = new RelayCommand(HandleRequestMainView);
        }

        public void HandleRequestMainView()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new MainViewVM());
        }

        /* Fonctions qui marchent dans toutes les VMs*/
    }
}
