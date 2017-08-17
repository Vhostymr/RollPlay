using RollPlay.Utilities;

namespace RollPlay.Data.Entities
{
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
        SleightOfHand,
        Stealth,
        Survival
    }

    public class Skills : Stats
    {
        private readonly int _characterLevel;
        private readonly IProficiencyCalculator _proficiencyCalculator;

        public Skills(int characterLevel)
        {
            _characterLevel = characterLevel;
            _proficiencyCalculator = new ProficiencyCalculator(); //todo see if autofac can inject here.
        }

        #region Skills

        public int Acrobatics => GetSkillModifer(StatType.Dexterity);
        public bool AcrobaticsAdvantage { get; set; }

        public int AnimalHandling => GetSkillModifer(StatType.Wisdom);
        public bool AnimalHandlingAdvantage { get; set; }

        public int Arcana => GetSkillModifer(StatType.Intelligence);
        public bool ArcanaAdvantage { get; set; }

        public int Athletics => GetSkillModifer(StatType.Strength);
        public bool AthleticsAdvantage { get; set; }

        public int Deception => GetSkillModifer(StatType.Charisma);
        public bool DeceptionAdvantage { get; set; }

        public int History => GetSkillModifer(StatType.Intelligence);
        public bool HistoryAdvantage { get; set; }

        public int Insight => GetSkillModifer(StatType.Wisdom);
        public bool InsightAdvantage { get; set; }

        public int Intimidation => GetSkillModifer(StatType.Charisma);
        public bool IntimidationAdvantage { get; set; }

        public int Investigation => GetSkillModifer(StatType.Intelligence);
        public bool InvestigationAdvantage { get; set; }

        public int Medicine => GetSkillModifer(StatType.Wisdom);
        public bool MedicineAdvantage { get; set; }

        public int Nature => GetSkillModifer(StatType.Intelligence);
        public bool NatureAdvantage { get; set; }

        public int Perception => GetSkillModifer(StatType.Wisdom);
        public bool PerceptionAdvantage { get; set; }

        public int Performance => GetSkillModifer(StatType.Wisdom);
        public bool PerformanceAdvantage { get; set; }

        public int Persuasion => GetSkillModifer(StatType.Charisma);
        public bool PersuasionAdvantage { get; set; }

        public int Religion => GetSkillModifer(StatType.Intelligence);
        public bool ReligionAdvantage { get; set; }

        public int SleightOfHand => GetSkillModifer(StatType.Dexterity);
        public bool SleightOfHandAdvantage { get; set; }

        public int Stealth => GetSkillModifer(StatType.Dexterity);
        public bool StealthAdvantage { get; set; }

        public int Survival => GetSkillModifer(StatType.Wisdom);
        public bool SurvivalAdvantage { get; set; }
        #endregion

        /// <summary>
        /// Returns the sum of the proficiency bonus and the governing stat modifier.
        /// </summary>
        /// <param name="type">The governing stat attribute.</param>
        /// <returns>The sum of the proficiency bonus and modifer.</returns>
        private int GetSkillModifer(StatType type)
        {
            return _proficiencyCalculator.GetProficiencyBonus(_characterLevel) + GetStatModifier(type);
        }
    }
}