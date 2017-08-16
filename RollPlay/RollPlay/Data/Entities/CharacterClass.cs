using System.Collections.Generic;

namespace RollPlay.Data.Entities
{
    public class CharacterClass
    {

        //The HP taken per level
        //
    }

    public class Class
    {
        public string Title { get; set; }

        //Hit Dice
        //HP Per Level
        //HP at first level

        public virtual ICollection<ClassLevelFeature> LevelFeatures { get; set; }

        //counter for Rages/Ki whatever, needs a good generic name and a way to increase by level (not direct)

        //Proficiencies (armor/weapons/tools)

        public virtual ICollection<StatBuff> StatBuffs { get; set; }

        //TODO: v2 Skill proficiencies

        //Proficiency bonus by level

        //TODO: Starting Equipment

        //TODO: Ability score increases on leveling up

        public virtual ICollection<CharacterSubclass> Subclasses { get; set; }




        //Spell Casting

    }

    public class CharacterSubclass
    {

        public string Title { get; set; }
        public string FlavorText { get; set; }
        public virtual ICollection<ClassLevelFeature> LevelFeatures { get; set; }

    }

    /// <summary>
    /// Levels available to a class at a given feature
    /// </summary>
    public class ClassLevelFeature
    {
        public int Level { get; set; }
        public virtual ICollection<Feature> Feats { get; set; }

    }

    public class ClassLevelSpellcasting
    {
        public int Level { get; set; }


        //TODO: These super can't stay as dictionaries
        public Dictionary<int, int> SpellSlotsPerLevel { get; set; } //treat cantrips as 0 level spells

        public Dictionary<int, int> SpellCountPerLevel { get; set; } //nulllable, if it's not defined don't limit

        //TODO: Probably a better way to organize this
        public Dictionary<int, List<Spell>> SpellsKnownPerLevel { get; set; }
    }

    /// <summary>
    /// Individual Spells
    /// </summary>
    public class Spell
    {
        public string Title { get; set; }
        public string FlavorText { get; set; }

        public int Level { get; set; } //0 for cantrip
        public string MagicSchool { get; set; }

        public int RangeDistance { get; set; }
        public string CastingTime { get; set; }

        public string Components { get; set; } //(Not just components, also needs material descriptions

        //Tie to turns?
        public string Duration { get; set; }

        //Attacks associated with the spell
        //TODO: Attacks that increment with level
    }


}