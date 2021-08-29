using RimWorld.Planet;
using SettingsHelper;
using UnityEngine;
using Verse;

namespace StartWithoutTech
{
    public class Mod : Verse.Mod
    {
        private Settings settings;

        public Mod(ModContentPack content) : base(content)
        {
            this.settings = GetSettings<Settings>();
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listing = new Listing_Standard();
            listing.Begin(inRect);

            listing.CheckboxLabeled("UseSelectedTechLevelLabel".Translate() + "*: ",
                                    ref settings.useSelectedTechLevel,
                                    "UseSelectedTechLevelTooltip".Translate());
            listing.AddLabeledSlider("StartingTechLevelLabel".Translate() + "*: ",
                                     ref settings.startingTechLevel);
            listing.Gap();
            listing.AddHorizontalLine();
            listing.Gap();

            if (Current.ProgramState == ProgramState.Playing)
            {
                listing.AddLabeledSlider("SetCurrentTechLevelLabel".Translate() + ": ",
                                         ref Find.FactionManager.OfPlayer.def.techLevel);
            }

            listing.AddLabelLine("* " + "RequiresRestartLabel".Translate());

            listing.End();
            settings.Write();
            base.DoSettingsWindowContents(inRect);
        }

        public override string SettingsCategory()
        {
            return "StartWithoutTechModName".Translate();
        }
    }
}
