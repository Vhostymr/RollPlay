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

    public enum SkillType
    {
        Acrobatics,
        AnimalHandling,
        Arcana,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        SlightOfHand,
        Stealth,
        Survival
    }

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

        public int Modifier(StatType Type)
        {
            int baseValue = GetStat(Type);
            int mod = (int)Math.Floor(((double)baseValue) / 2);

            //TODO: Add modifier buffs

            return mod;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        private int GetStat(StatType Type)
        {
            switch (Type)
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
            }
            return 0;
        }
        #endregion

        public virtual CharacterBackground Background { get; set; }

        #region Skills

        public int Acrobatics
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Dexterity);
            }
        }
        public bool AcrobaticsAdvantage { get; set; }


        public int AnimalHandling
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Wisdom);
            }
        }
        public bool AnimalHandlingAdvantage { get; set; }


        public int Arcana
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Intelligence);
            }
        }
        public bool ArcanaAdvantage { get; set; }


        public int Athletics
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Strength);
            }
        }
        public bool AthleticsAdvantage { get; set; }


        public int Deception
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Charisma);
            }
        }
        public bool DeceptionAdvantage { get; set; }

        public int History
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Intelligence);
            }
        }
        public bool HistoryAdvantage { get; set; }

        public int Insight
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Wisdom);
            }
        }
        public bool InsightAdvantage { get; set; }

        public int Intimidation
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Charisma);
            }
        }
        public bool IntimidationAdvantage { get; set; }

        public int Investigation
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Intelligence);
            }
        }
        public bool InvestigationAdvantage { get; set; }

        public int Medicine
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Wisdom);
            }
        }
        public bool MedicineAdvantage { get; set; }

        public int Nature
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Intelligence);
            }
        }
        public bool NatureAdvantage { get; set; }

        public int Perception
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Wisdom);
            }
        }
        public bool PerceptionAdvantage { get; set; }

        public int Performance
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Wisdom);
            }
        }
        public bool PerformanceAdvantage { get; set; }

        public int Persuasion
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Charisma);
            }
        }
        public bool PersuasionAdvantage { get; set; }

        public int Religion
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Intelligence);
            }
        }
        public bool ReligionAdvantage { get; set; }

        public int SlightOfHand
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Dexterity);
            }
        }
        public bool SlightOfHandAdvantage { get; set; }

        public int Stealth
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Dexterity);
            }
        }
        public bool StealthAdvantage { get; set; }

        public int Survival
        {
            get
            {
                //TODO: Skill buffs
                return Modifier(StatType.Wisdom);
            }
        }
        public bool SurvivalAdvantage { get; set; }


        #endregion

        //TODO: Per Level Additions (Keep broken up in case you need to roll back levels)

        public int DamageTaken { get; set; }
    }
}