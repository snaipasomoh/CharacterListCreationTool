using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterListCreationTool.Models
{
    public partial class DnD5eCharacter : ObservableObject
    {
        [ObservableProperty]
        private string name = "";

        [ObservableProperty]
        private DnD5eClass? characterClass;

        [ObservableProperty]
        private DnD5eRace? race;

        public ObservableCollection<DnD5eRace> AvailableRaces { get; set; } = new ObservableCollection<DnD5eRace>() {
            new DnD5eRaceGnome(),
            new Dnd5eRaceDwarf(),
            new DnD5eRaceDragonborn(),
            new DnD5eRaceHalfOrc(),
            new DnD5eRaceHalfling(),
            new DnD5eRaceHalfElf(),
            new DnD5eRaceTiefling(),
            new DnD5eRaceHuman(),
            new DnD5eRaceElf()};

        [ObservableProperty]
        private DnD5eBackground? background;

        [ObservableProperty]
        private DnD5eAlignment? alignment;

        [ObservableProperty]
        private int level = 1;

        [ObservableProperty]
        private int proficiencyBonus = 2;

        [ObservableProperty]
        private int strength = 0;

        [ObservableProperty]
        private int strengthModifier = 0;

        [ObservableProperty]
        private int dexterity = 0;

        [ObservableProperty]
        private int dexterityModifier = 0;

        [ObservableProperty]
        private int constitution = 0;

        [ObservableProperty]
        private int constitutionModifier = 0;

        [ObservableProperty]
        private int intelligence = 0;

        [ObservableProperty]
        private int intelligenceModifier = 0;

        [ObservableProperty]
        private int wisdom = 0;

        [ObservableProperty]
        private int wisdomModifier = 0;

        [ObservableProperty]
        private int charisma = 0;

        [ObservableProperty]
        private int charismaModifier = 0;
    }

    public class DnD5eClass { }
    public class DnD5eBackground { }
    public class DnD5eAlignment { }
}
