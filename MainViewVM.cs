using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Pokemon_Like.MVVM.ViewModel
{
    public class MainViewVM : INotifyPropertyChanged
    {
        private string _imageSource;

        public string ImageSource
        {
            get => _imageSource;
            set
            {
                _imageSource = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
