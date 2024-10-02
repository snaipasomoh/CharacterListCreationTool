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
        public partial class StatWithStuff : ObservableObject
        {
            [ObservableProperty]
            private DnD5eStats stat;

            [ObservableProperty]
            private bool isUsed;

            [ObservableProperty]
            private bool isEnabled;

            public StatWithStuff(DnD5eStats stat, bool isUsed = false, bool isEnabled = true)
            {
                Stat = stat;
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

        public ObservableCollection<StatWithStuff> StatsForCustomBonuses { get; set; } = new();

        public DnD5eViewModel()
        {
            character.PropertyChanged += Race_PropertyChanged;
        }

        private void UpdateStatsForCustomBonuses()
        {
            foreach (var statWithStuff in StatsForCustomBonuses)
            {
                statWithStuff.PropertyChanged -= StatWithBool_PropertyChanged;
            }
            StatsForCustomBonuses.Clear();
            foreach (var stat in Character.Race!.StatsAvailableForCustomBonuses)
            {
                StatWithStuff statWithBool = new(stat);
                statWithBool.PropertyChanged += StatWithBool_PropertyChanged;
                StatsForCustomBonuses.Add(statWithBool);
            }
        }

        private void UpdateStatsForCustomBonusesState()
        {
            foreach (var statWithStuff in StatsForCustomBonuses)
            {
                statWithStuff.IsEnabled = statWithStuff.IsUsed || (Character.Race!.CustomBonusesQuantity > Character.Race.StatsWithCustomBonuses.Count);
            }
        }

        private void StatWithBool_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(StatWithStuff.IsUsed))
            { 
                if ((sender is StatWithStuff currStat))
                {
                    if (currStat.IsUsed)
                    {
                        Character.Race!.StatsWithCustomBonuses.Add(currStat.Stat);
                    }
                    else
                    {
                        Character.Race!.StatsWithCustomBonuses.Remove(currStat.Stat);
                    }
                    UpdateStatsForCustomBonusesState();
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
                    UpdateStatsForCustomBonuses();
                }
            }
        }
    }
}
