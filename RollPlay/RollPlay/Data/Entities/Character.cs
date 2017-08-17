namespace RollPlay.Data.Entities
{
    //Fill in the Buff Types that are NOT
    //      Stats
    //      Skills
    public enum BuffType
    {
        //Health
        MaxHealth,

        //Defensive Stats
        ArmorClass
    }

    public class Character
    {
        public Character()
        {
            Stats = new Stats();
            Skills = new Skills(Level); //Needed to calculate proficiency bonus modifiers.
        }

        public int Level { get; set; }

        public Stats Stats { get; private set; }

        public Skills Skills { get; private set; }

        public virtual CharacterBackground Background { get; set; }

        //TODO: Per Level Additions (Keep broken up in case you need to roll back levels)

        public int DamageTaken { get; set; }
    }
}