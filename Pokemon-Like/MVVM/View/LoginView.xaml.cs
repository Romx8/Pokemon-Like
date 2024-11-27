using System.Windows.Controls;
using System.Windows;

namespace Pokemon_Like.MVVM.View
{
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (DataContext is ViewModel.LoginVM loginVM)
            {
                loginVM.Password = ((PasswordBox)sender).Password;
            }
        }
    }
}
