using Verse;
using RimWorld;
using System.Linq;

namespace StartWithoutTech
{
    [StaticConstructorOnStartup]
    public static class TechRemover
    {
        static TechRemover()
        {
            Settings settings = LoadedModManager.GetMod<Mod>().GetSettings<Settings>();

            if (settings.removeFactionResearches) RemoveStartingResearches();
            if (settings.removeMemeResearches) RemoveMemeResearches();
        }

        private static void RemoveMemeResearches()
        {
            foreach (MemeDef memeDef in DefDatabase<MemeDef>.AllDefs)
            {
                if (memeDef.startingResearchProjects == null)
                {
                    continue;
                }
                memeDef.startingResearchProjects.Clear();
            }
        }

        private static void RemoveStartingResearches()
        {
            foreach (FactionDef factionDef in DefDatabase<FactionDef>.AllDefs.Where(f => f.isPlayer == true))
            {
                if (factionDef.startingResearchTags == null)
                {
                    continue;
                }
                factionDef.startingResearchTags.Clear();
            }
        }
    }
}
