using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using CharacterListCreationTool.Lang;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterListCreationTool.Models
{
    public abstract partial class DnD5eRace : ObservableObject
    {
        [ObservableProperty]
        private string name = "";

        [ObservableProperty]
        private DnD5eRace? subrace;

        [ObservableProperty]
        private int strengthBonus = 0;

        [ObservableProperty]
        private int dexterityBonus = 0;

        [ObservableProperty]
        private int constitutionBonus = 0;

        [ObservableProperty]
        private int intelligenceBonus = 0;

        [ObservableProperty]
        private int wisdomBonus = 0;

        [ObservableProperty]
        private int charismaBonus = 0;

        [ObservableProperty]
        private int customBonusesQuantity = 0;

        [ObservableProperty]
        private int customBonusSize = 0;

        public ObservableCollection<DnD5eStats> StatsAvailableForCustomBonuses { get; } = new();

        public ObservableCollection<DnD5eStats?> StatsWithCustomBonuses { get; } = new();

        public ObservableCollection<DnD5eRace> AvailableSubraces { get; } = new();
    }

    #region Gnome
    public class DnD5eRaceGnome : DnD5eRace
    {
        public DnD5eRaceGnome()
        {
            Name = Resources.DnD5eRaceGnome;
            IntelligenceBonus = 2;
            AvailableSubraces.Add(new DnD5eSubraceForestGnome());
            AvailableSubraces.Add(new DnD5eSubraceRockGnome());
        }
    }

    public class DnD5eSubraceForestGnome : DnD5eRace
    {
        public DnD5eSubraceForestGnome()
        {
            Name = Resources.DnD5eSubraceForestGnome;
            DexterityBonus = 1;
        }
    }

    public class DnD5eSubraceRockGnome : DnD5eRace
    {
        public DnD5eSubraceRockGnome()
        {
            Name = Resources.DnD5eSubraceRockGnome;
            ConstitutionBonus = 1;
        }
    }
    #endregion

    #region Dwarf
    public class Dnd5eRaceDwarf : DnD5eRace
    {
        public Dnd5eRaceDwarf()
        {
            Name = Resources.DnD5eRaceDwarf;
            ConstitutionBonus = 2;
            AvailableSubraces.Add(new Dnd5eSubraceMountainDwarf());
            AvailableSubraces.Add(new Dnd5eSubraceHillDwarf());
        }
    }

    public class Dnd5eSubraceMountainDwarf : DnD5eRace
    {
        public Dnd5eSubraceMountainDwarf()
        {
            Name = Resources.DnD5eSubraceMountainDwarf;
            StrengthBonus = 2;
        }
    }

    public class Dnd5eSubraceHillDwarf : DnD5eRace
    {
        public Dnd5eSubraceHillDwarf()
        {
            Name = Resources.DnD5eSubraceHillDwarf;
            WisdomBonus = 1;
        }
    }
    #endregion

    #region Dragonborn
    public class DnD5eRaceDragonborn : DnD5eRace
    {
        public DnD5eRaceDragonborn()
        {
            Name = Resources.DnD5eRaceDragonborn;
            StrengthBonus = 2;
            CharismaBonus = 1;
            AvailableSubraces.Add(new DnD5eSubraceWhiteDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceBronzeDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceGreenDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceGoldDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceRedDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceBrassDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceCopperDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceSilverDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceBlueDragonborn());
            AvailableSubraces.Add(new DnD5eSubraceBlackDragonborn());
        }
    }

    public class DnD5eSubraceWhiteDragonborn : DnD5eRace
    {
        public DnD5eSubraceWhiteDragonborn()
        {
            Name = Resources.DnD5eSubraceWhiteDragonborn;
        }
    }

    public class DnD5eSubraceBronzeDragonborn : DnD5eRace
    {
        public DnD5eSubraceBronzeDragonborn()
        {
            Name = Resources.DnD5eSubraceBronzeDragonborn;
        }
    }

    public class DnD5eSubraceGreenDragonborn : DnD5eRace
    {
        public DnD5eSubraceGreenDragonborn()
        {
            Name = Resources.DnD5eSubraceGreenDragonborn;
        }
    }

    public class DnD5eSubraceGoldDragonborn : DnD5eRace
    {
        public DnD5eSubraceGoldDragonborn()
        {
            Name = Resources.DnD5eSubraceGoldDragonborn;
        }
    }

    public class DnD5eSubraceRedDragonborn : DnD5eRace
    {
        public DnD5eSubraceRedDragonborn()
        {
            Name = Resources.DnD5eSubraceRedDragonborn;
        }
    }

    public class DnD5eSubraceBrassDragonborn : DnD5eRace
    {
        public DnD5eSubraceBrassDragonborn()
        {
            Name = Resources.DnD5eSubraceBrassDragonborn;
        }
    }

    public class DnD5eSubraceCopperDragonborn : DnD5eRace
    {
        public DnD5eSubraceCopperDragonborn()
        {
            Name = Resources.DnD5eSubraceCopperDragonborn;
        }
    }

    public class DnD5eSubraceSilverDragonborn : DnD5eRace
    {
        public DnD5eSubraceSilverDragonborn()
        {
            Name = Resources.DnD5eSubraceSilverDragonborn;
        }
    }

    public class DnD5eSubraceBlueDragonborn : DnD5eRace
    {
        public DnD5eSubraceBlueDragonborn()
        {
            Name = Resources.DnD5eSubraceBlueDragonborn;
        }
    }

    public class DnD5eSubraceBlackDragonborn : DnD5eRace
    {
        public DnD5eSubraceBlackDragonborn()
        {
            Name = Resources.DnD5eSubraceBlackDragonborn;
        }
    }
    #endregion

    #region HalfOrc
    public class DnD5eRaceHalfOrc : DnD5eRace
    {
        public DnD5eRaceHalfOrc()
        {
            Name = Resources.DnD5eRaceHalfOrc;
            StrengthBonus = 2;
            ConstitutionBonus = 1;
        }
    }
    #endregion

    #region Halfling
    public class DnD5eRaceHalfling : DnD5eRace
    {
        public DnD5eRaceHalfling()
        {
            Name = Resources.DnD5eRaceHalfling;
            DexterityBonus = 2;
            AvailableSubraces.Add(new DnD5eSubraceLightfootHalfling());
            AvailableSubraces.Add(new DnD5eSubraceStoutHalfling());
        }
    }

    public class DnD5eSubraceLightfootHalfling : DnD5eRace
    {
        public DnD5eSubraceLightfootHalfling()
        {
            Name = Resources.DnD5eSubraceLightfootHalfling;
            CharismaBonus = 1;
        }
    }

    public class DnD5eSubraceStoutHalfling : DnD5eRace
    {
        public DnD5eSubraceStoutHalfling()
        {
            Name = Resources.DnD5eSubraceStoutHalfling;
            ConstitutionBonus = 1;
        }
    }
    #endregion

    #region HalfElf
    public class DnD5eRaceHalfElf : DnD5eRace
    {
        public DnD5eRaceHalfElf()
        {
            Name = Resources.DnD5eRaceHalfElf;
            CharismaBonus = 2;
            CustomBonusesQuantity = 2;
            CustomBonusSize = 1;

            StatsAvailableForCustomBonuses.Add(DnD5eStats.Strength);
            StatsAvailableForCustomBonuses.Add(DnD5eStats.Dexterity);
            StatsAvailableForCustomBonuses.Add(DnD5eStats.Constitution);
            StatsAvailableForCustomBonuses.Add(DnD5eStats.Intelligence);
            StatsAvailableForCustomBonuses.Add(DnD5eStats.Wisdom);

            StatsWithCustomBonuses.Add(null);
            StatsWithCustomBonuses.Add(null);
        }
    }
    #endregion

    #region Tiefling
    public class DnD5eRaceTiefling : DnD5eRace
    {
        public DnD5eRaceTiefling()
        {
            Name = Resources.DnD5eRaceTiefling;
            CharismaBonus = 2;
            IntelligenceBonus = 1;
        }
    }
    #endregion

    #region Human
    public class DnD5eRaceHuman : DnD5eRace
    {
        public DnD5eRaceHuman()
        {
            Name = Resources.DnD5eRaceHuman;
            StrengthBonus = 1;
            DexterityBonus = 1;
            ConstitutionBonus = 1;
            IntelligenceBonus = 1;
            WisdomBonus = 1;
            CharismaBonus = 1;
        }
    }
    #endregion

    #region Elf
    public class DnD5eRaceElf : DnD5eRace
    {
        public DnD5eRaceElf()
        {
            Name = Resources.DnD5eRaceElf;
            DexterityBonus = 2;
            AvailableSubraces.Add(new DnD5eSubraceHighElf());
            AvailableSubraces.Add(new DnD5eSubraceWoodElf());
            AvailableSubraces.Add(new DnD5eSubraceDrowElf());
        }
    }

    public class DnD5eSubraceHighElf : DnD5eRace
    {
        public DnD5eSubraceHighElf()
        {
            Name = Resources.DnD5eSubraceHighElf;
            IntelligenceBonus = 1;
        }
    }

    public class DnD5eSubraceWoodElf : DnD5eRace
    {
        public DnD5eSubraceWoodElf()
        {
            Name = Resources.DnD5eSubraceWoodElf;
            WisdomBonus = 1;
        }
    }

    public class DnD5eSubraceDrowElf : DnD5eRace
    {
        public DnD5eSubraceDrowElf()
        {
            Name = Resources.DnD5eSubraceDrowElf;
            CharismaBonus = 1;
        }
    }
    #endregion
}
