using CharacterListCreationTool.Lang;
using System.ComponentModel.DataAnnotations;

namespace CharacterListCreationTool.Models
{
    public enum DnD5eStats
    {
        [Display(Name = "DnD5eStatsStrength", ResourceType = typeof(Resources))]
        Strength,
        [Display(Name = "DnD5eStatsDexterity", ResourceType = typeof(Resources))]
        Dexterity,
        [Display(Name = "DnD5eStatsConstitution", ResourceType = typeof(Resources))]
        Constitution,
        [Display(Name = "DnD5eStatsIntelligence", ResourceType = typeof(Resources))]
        Intelligence,
        [Display(Name = "DnD5eStatsWisdom", ResourceType = typeof(Resources))]
        Wisdom,
        [Display(Name = "DnD5eStatsCharisma", ResourceType = typeof(Resources))]
        Charisma
    }
}
