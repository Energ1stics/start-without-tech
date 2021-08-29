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
                if (factionDef.isPlayer)
                {
                    factionDef.startingResearchTags.Clear();
                }
            }
        }
    }
}
