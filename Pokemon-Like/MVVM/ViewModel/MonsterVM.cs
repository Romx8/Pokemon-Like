using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Pokemon_Like.Model;

namespace Pokemon_Like.MVVM.ViewModel
{
    internal class MonsterVM : BaseVM
    {
        private readonly ExerciceMonsterContext _context;

        public ObservableCollection<Monster> Monsters { get; private set; }

        public MonsterVM()
        {
            _context = new ExerciceMonsterContext();
            var monstersInDb = _context.Monsters.ToList();
            Monsters = new ObservableCollection<Monster>(monstersInDb);
        }


        public MonsterVM(ExerciceMonsterContext context)
        {

            _context = context;

            var monstersInDb = _context.Monsters.ToList();

            if (monstersInDb.Any())
            {
                MessageBox.Show("Monstres trouvés dans la base de données !");
                Monsters = new ObservableCollection<Monster>(monstersInDb);
                var firstMonster = monstersInDb.First();
                MessageBox.Show($"Premier monstre trouvé : {firstMonster.Name}, Santé : {firstMonster.Health}");
            }
            else
            {
                MessageBox.Show("Aucun monstre trouvé dans la base de données !");
            }
        }

        private Monster? _selectedMonster;
        public Monster? SelectedMonster
        {
            get => _selectedMonster;
            set
            {
                if (SetProperty(ref _selectedMonster, value))
                {
                    OnPropertyChanged(nameof(SelectedMonster.Spells));
                }
            }
        }

    }
}
