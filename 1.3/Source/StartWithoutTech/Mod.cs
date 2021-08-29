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
            listing.CheckboxLabeled("UseSelectedTechLevelLabel".Translate() + ": ",
                                            ref settings.useSelectedTechLevel,
                                            "Some Tooltip yolo");
            listing.AddLabeledSlider("StartingTechLevelLabel".Translate() + ": ",
                                             ref settings.startingTechLevel);
            listing.End();
            settings.Write();
            base.DoSettingsWindowContents(inRect);
        }
    }
}
