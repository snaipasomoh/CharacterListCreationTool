using CharacterListCreationTool.Lang;
using System.ComponentModel.DataAnnotations;

namespace CharacterListCreationTool.Models
{
    public enum DnD5eAbility
    {
        [Display(Name = "DnD5eAbilitiesStrength", ResourceType = typeof(Resources))]
        Strength,
        [Display(Name = "DnD5eAbilitiesDexterity", ResourceType = typeof(Resources))]
        Dexterity,
        [Display(Name = "DnD5eAbilitiesConstitution", ResourceType = typeof(Resources))]
        Constitution,
        [Display(Name = "DnD5eAbilitiesIntelligence", ResourceType = typeof(Resources))]
        Intelligence,
        [Display(Name = "DnD5eAbilitiesWisdom", ResourceType = typeof(Resources))]
        Wisdom,
        [Display(Name = "DnD5eAbilitiesCharisma", ResourceType = typeof(Resources))]
        Charisma
    }
}
