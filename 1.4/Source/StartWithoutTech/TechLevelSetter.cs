using RimWorld;
using System.Linq;
using Verse;

namespace StartWithoutTech
{
    [StaticConstructorOnStartup]
    public class TechLevelSetter
    {
        static TechLevelSetter()
        {
            Settings settings = LoadedModManager.GetMod<Mod>().GetSettings<Settings>();

            if (!settings.useSelectedTechLevel)
            {
                return;
            }

            foreach (FactionDef factionDef in DefDatabase<FactionDef>.AllDefs.Where(f => f.isPlayer == true))
            {
                factionDef.techLevel = settings.startingTechLevel;
            }
        }
    }
}
