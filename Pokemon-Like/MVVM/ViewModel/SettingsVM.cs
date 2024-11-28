using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Pokemon_Like.Model;

namespace Pokemon_Like.MVVM.ViewModel
{
    internal class SettingsVM: BaseVM
    {
        public ICommand InitBD { get; set; }
        public SettingsVM() 
        {
            InitBD = new RelayCommand(HandleInitBD);
        }


        private void HandleInitBD()
        {
            new Init();
        }
    }
}
