using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RollPlay.Data
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