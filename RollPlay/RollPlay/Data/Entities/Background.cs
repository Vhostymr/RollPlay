using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RollPlay.Data.Entities
{
    public class CharacterBackground
    {
        public Background Background { get; set; }
        public int PersonalityTraitsSelection { get; set; }
        public int IdealsSelection { get; set; }
        public int BondsSelection { get; set; }
        public int FlawsSelection { get; set; }

        public int? MiscSelection { get; set; }
    }

    public class Background
    {
        [Key]
        public int UniqueID { get; set; }
        public string Name { get; set; }
        public string FlavorDesscription { get; set; }

        //TODO: Proficiency

        //TODO: Languages (specific or choice)

        //TODO: Starter Equipment

        public virtual ICollection<Feature> Feats { get; set; }

        public virtual ICollection<BackgroundTrait> PersonalityTraits { get; set; }
        public virtual ICollection<BackgroundTrait> Ideals { get; set; }
        public virtual ICollection<BackgroundTrait> Bonds { get; set; }
        public virtual ICollection<BackgroundTrait> Flaws { get; set; }

        public string MiscName { get; set; } //See Charlatan's Schemes, Entertainer's Routines, etc
        public string MiscDescription { get; set; }
        public virtual ICollection<BackgroundTrait> Misc { get; set; }

    }

    public class BackgroundTrait
    {
        [Key]
        public int UniqueID { get; set; }
        public int DisplayID { get; set; }
        public string DisplayText { get; set; }
    }
}