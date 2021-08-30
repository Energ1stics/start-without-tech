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
            foreach (FactionDef factionDef in DefDatabase<FactionDef>.AllDefs.Where(f => f.isPlayer == true))
            {
                if (factionDef.startingResearchTags == null)
                {
                    continue;
                }
                factionDef.startingResearchTags.Clear();
            }
            foreach (MemeDef memeDef in DefDatabase<MemeDef>.AllDefs)
            {
                if (memeDef.startingResearchProjects == null)
                {
                    continue;
                }
                memeDef.startingResearchProjects.Clear();
            }
        }
    }
}
