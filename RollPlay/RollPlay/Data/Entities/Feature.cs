using System.Collections.Generic;

namespace RollPlay.Data.Entities
{
    public class Feature
    {
        public virtual List<Buff> Buffs { get; set; }
        public virtual List<StatBuff> StatBuffs { get; set; }

    }
}