using CharacterListCreationTool.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterListCreationTool.ViewModels
{
    public partial class DnD5eViewModel : ViewModelBase
    {
        [ObservableProperty]
        private DnD5eCharacter character = new();

        [ObservableProperty]
        private bool raceFirstCustomBonusAvailable = false;

        [ObservableProperty]
        private bool raceSecondCustomBonusAvailable = false;

        [ObservableProperty]
        private bool subracesAvailable = false;

        public DnD5eViewModel()
        {
            character.PropertyChanged += Race_PropertyChanged;
        }

        private void Race_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Character.Race))
            {
                RaceFirstCustomBonusAvailable = Character.Race?.CustomBonusesQuantity >= 1;
                RaceSecondCustomBonusAvailable = Character.Race?.CustomBonusesQuantity >= 2;
                SubracesAvailable = Character.Race?.AvailableSubraces.Count() > 0;
            }
        }
    }
}
