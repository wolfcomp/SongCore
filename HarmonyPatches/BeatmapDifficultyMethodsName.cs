﻿using HarmonyLib;
namespace SongCore.HarmonyPatches
{


    [HarmonyPatch(typeof(BeatmapDifficultyMethods))]
    [HarmonyPatch("Name", MethodType.Normal)]
    public class BeatmapDifficultyMethodsName
    {
        static void Postfix(BeatmapDifficulty difficulty, ref string __result)
        {
            if (!Plugin.displayDiffLabels) return;
            if (difficulty == BeatmapDifficulty.Easy)
            {
                if (HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.EasyOverride != "")
                    __result = HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.EasyOverride.Replace(@"<", "<\u200B").Replace(@">", ">\u200B");
            }
            if (difficulty == BeatmapDifficulty.Normal)
            {
                if (HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.NormalOverride != "")
                    __result = HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.NormalOverride.Replace(@"<", "<\u200B").Replace(@">", ">\u200B");
            }
            if (difficulty == BeatmapDifficulty.Hard)
            {
                if (HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.HardOverride != "")
                    __result = HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.HardOverride.Replace(@"<", "<\u200B").Replace(@">", ">\u200B");
            }
            if (difficulty == BeatmapDifficulty.Expert)
            {
                if (HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.ExpertOverride != "")
                    __result = HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.ExpertOverride.Replace(@"<", "<\u200B").Replace(@">", ">\u200B");
            }
            if (difficulty == BeatmapDifficulty.ExpertPlus)
            {
                if (HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.ExpertPlusOverride != "")
                    __result = HarmonyPatches.StandardLevelDetailViewRefreshContent.currentLabels.ExpertPlusOverride.Replace(@"<", "<\u200B").Replace(@">", ">\u200B");
            }
            //    Console.WriteLine(__result);
        }




    }
}
