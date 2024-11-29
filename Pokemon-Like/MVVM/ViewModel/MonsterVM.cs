using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Pokemon_Like.Model;

namespace Pokemon_Like.MVVM.ViewModel
{
    internal class MonsterVM : BaseVM
    {
        private readonly ExerciceMonsterContext _context;

        public ObservableCollection<Monster> Monsters { get; set; }

        public MonsterVM(ExerciceMonsterContext context)
        {
            _context = context;

            // Charger les monstres depuis la base de données
            var monstersInDb = _context.Monsters.ToList();
            if (monstersInDb.Any())
            {
                Monsters = new ObservableCollection<Monster>(monstersInDb);
            }
            else
            {
                MessageBox.Show("No Pokémon found in the database!");
            }
        }

        public MonsterVM() { }
    }
}
