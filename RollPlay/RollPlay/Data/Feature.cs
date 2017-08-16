using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RollPlay.Data
{
    public class Feature
    {
        public virtual List<Buff> Buffs { get; set; }
        public virtual List<StatBuff> StatBuffs { get; set; }

    }
}