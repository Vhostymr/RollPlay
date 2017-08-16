namespace RollPlay.Data.Entities
{
    public class Buff
    {
        public BuffType Type { get; set; }

        public int Value { get; set; }

    }

    public enum StatBuffType
    {
        CoreStat,
        Modifier,
        SavingThrow,
    }
    public class StatBuff
    {
        public StatBuffType BuffType { get; set; }
        public StatType StatType { get; set; }

    }
}