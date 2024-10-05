using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterListCreationTool.Models
{
    public abstract partial class DnD5eClass : ObservableObject
    {
        [ObservableProperty]
        private string name = "";

        [ObservableProperty]
        private string description = "";

        public Dictionary<int, List<DnD5eFeature>> FeatureDict { get; } = new();

        [ObservableProperty]
        private int hitDie = 0;

        [ObservableProperty]
        private DnD5eAbility primaryAbility;

        public ObservableCollection<DnD5eAbility> SavingThrowProficiencies { get; } = new();

        public ObservableCollection<DnD5eWeapon> WeaponProficiencies { get; } = new();

        public ObservableCollection<DnD5eArmor> ArmorProficiencies { get; } = new();
    }
}
