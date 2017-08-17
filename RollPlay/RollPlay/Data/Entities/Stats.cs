using System;

namespace RollPlay.Data.Entities
{
    public enum StatType
    {
        Strength,
        Dexterity,
        Constitution,
        Intelligence,
        Wisdom,
        Charisma
    }

    public class Stats
    {
        #region Core stats
        private int baseStrength;
        public int Strength
        {
            get
            {
                return this.baseStrength; //TODO: Plus the addons
            }
            set
            {
                this.baseStrength = value;
            }
        }

        private int baseDexterity;
        public int Dexterity
        {
            get
            {
                return this.baseDexterity; //TODO: Plus the addons
            }
            set
            {
                this.baseDexterity = value;
            }
        }

        private int baseConstitution;
        public int Constitution
        {
            get
            {
                return this.baseConstitution; //TODO: Plus the addons
            }
            set
            {
                this.baseConstitution = value;
            }
        }

        private int baseIntelligence;
        public int Intelligence
        {
            get
            {
                return this.baseIntelligence; //TODO: Plus the addons
            }
            set
            {
                this.baseIntelligence = value;
            }
        }

        private int baseWisdom;
        public int Wisdom
        {
            get
            {
                return this.baseWisdom; //TODO: Plus the addons
            }
            set
            {
                this.baseWisdom = value;
            }
        }

        private int baseCharisma;
        public int Charisma
        {
            get
            {
                return this.baseCharisma; //TODO: Plus the addons
            }
            set
            {
                this.baseCharisma = value;
            }
        }

        public int GetStatModifier(StatType type)
        {
            int baseValue = GetStat(type);
            return (int)Math.Floor((double)baseValue / 2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private int GetStat(StatType type)
        {
            switch (type)
            {
                case StatType.Strength:
                    return Strength;
                case StatType.Dexterity:
                    return Dexterity;
                case StatType.Constitution:
                    return Constitution;
                case StatType.Intelligence:
                    return Intelligence;
                case StatType.Wisdom:
                    return Wisdom;
                case StatType.Charisma:
                    return Charisma;
                default:
                    return 0;
            }
        }
        #endregion
    }
}