using CharacterListCreationTool.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterListCreationTool.ViewModels
{
    public partial class DnD5eViewModel : ViewModelBase
    {
        public partial class AbilityWithStuff : ObservableObject
        {
            [ObservableProperty]
            private DnD5eAbility ability;

            [ObservableProperty]
            private bool isUsed;

            [ObservableProperty]
            private bool isEnabled;

            public AbilityWithStuff(DnD5eAbility ability, bool isUsed = false, bool isEnabled = true)
            {
                Ability = ability;
                IsUsed = isUsed;
                IsEnabled = isEnabled;
            }
        }

        [ObservableProperty]
        private DnD5eCharacter character = new();

        [ObservableProperty]
        private bool raceCustomBonusesAvailable = false;

        [ObservableProperty]
        private bool subracesAvailable = false;

        public ObservableCollection<AbilityWithStuff> AbilitiesForCustomBonuses { get; set; } = new();

        public DnD5eViewModel()
        {
            character.PropertyChanged += Race_PropertyChanged;
        }

        private void UpdateAbilitiesForCustomBonuses()
        {
            foreach (var abilityWithStuff in AbilitiesForCustomBonuses)
            {
                abilityWithStuff.PropertyChanged -= AbilityWithBool_PropertyChanged;
            }
            AbilitiesForCustomBonuses.Clear();
            foreach (var ability in Character.Race!.StatsAvailableForCustomBonuses)
            {
                AbilityWithStuff abilityWithBool = new(ability);
                abilityWithBool.PropertyChanged += AbilityWithBool_PropertyChanged;
                AbilitiesForCustomBonuses.Add(abilityWithBool);
            }
        }

        private void UpdateAbilitiesForCustomBonusesState()
        {
            foreach (var abilityWithStuff in AbilitiesForCustomBonuses)
            {
                abilityWithStuff.IsEnabled = abilityWithStuff.IsUsed || (Character.Race!.CustomBonusesQuantity > Character.Race.AbilitiesWithCustomBonuses.Count);
            }
        }

        private void AbilityWithBool_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AbilityWithStuff.IsUsed))
            { 
                if ((sender is AbilityWithStuff currAbility))
                {
                    if (currAbility.IsUsed)
                    {
                        Character.Race!.AbilitiesWithCustomBonuses.Add(currAbility.Ability);
                    }
                    else
                    {
                        Character.Race!.AbilitiesWithCustomBonuses.Remove(currAbility.Ability);
                    }
                    UpdateAbilitiesForCustomBonusesState();
                }
            }
        }

        private void Race_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Character.Race))
            {
                if (Character.Race != null)
                {
                    SubracesAvailable = Character.Race.AvailableSubraces.Count() > 0;
                    RaceCustomBonusesAvailable = Character.Race.CustomBonusesQuantity > 0;
                    UpdateAbilitiesForCustomBonuses();
                }
            }
        }
    }
}
