using System.Windows;

namespace PokemonLike
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Prêt pour l'aventure Pokémon ?");
        }
    }
}
