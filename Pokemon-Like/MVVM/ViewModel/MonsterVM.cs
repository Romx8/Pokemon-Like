using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Pokemon_Like.Model;

namespace Pokemon_Like.MVVM.ViewModel
{
    internal class MonsterVM : BaseVM
    {
        public ICommand RequestCombatView { get; set; }

        private readonly ExerciceMonsterContext _context;

        public ObservableCollection<Monster> Monsters { get; private set; }
        public ObservableCollection<Spell> Spells { get; private set; }

        public MonsterVM()
        {
            RequestCombatView = new RelayCommand(Combat);
            _context = new ExerciceMonsterContext();
            var monstersInDb = _context.Monsters.ToList();
            var spellsInDb = _context.Spells.ToList();
            Monsters = new ObservableCollection<Monster>(monstersInDb);
            Spells = new ObservableCollection<Spell>(spellsInDb);
        }

        public void Combat()
        {
            MainWindowVM.OnRequestVMChange?.Invoke(new CombatVM());
        }


    }
}
