using RimWorld;
using Verse;

namespace StartWithoutTech
{
    public class Settings : ModSettings
    {
        public bool removeFactionResearches = true;
        public bool removeMemeResearches = true;
        public bool useSelectedTechLevel = false;
        public TechLevel startingTechLevel = TechLevel.Animal;

        public override void ExposeData()
        {
            Scribe_Values.Look(ref this.removeFactionResearches, nameof(this.removeFactionResearches), true);
            Scribe_Values.Look(ref this.removeMemeResearches, nameof(this.removeMemeResearches), true);
            Scribe_Values.Look(ref this.useSelectedTechLevel, nameof(this.useSelectedTechLevel), false);
            Scribe_Values.Look(ref this.startingTechLevel, nameof(this.startingTechLevel), TechLevel.Animal);
            base.ExposeData();
        }
    }
}
