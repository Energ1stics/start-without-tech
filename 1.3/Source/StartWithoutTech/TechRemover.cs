using Verse;
using RimWorld;

namespace StartWithoutTech
{
    [StaticConstructorOnStartup]
    public static class TechRemover
    {
        static TechRemover()
        {
            foreach (FactionDef factionDef in DefDatabase<FactionDef>.AllDefs)
            {
                if (!factionDef.isPlayer)
                {
                    continue;
                }
                factionDef.startingResearchTags.Clear();
            }
            foreach (MemeDef memeDef in DefDatabase<MemeDef>.AllDefs)
            {
                memeDef.startingResearchProjects.Clear();
            }
        }
    }
}
