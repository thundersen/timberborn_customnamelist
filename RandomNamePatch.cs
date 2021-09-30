using System;
using HarmonyLib;
using Timberborn.Characters;

namespace CustomNameList
{
    class RandomNamePatch
    {
        [HarmonyPatch(typeof(NameService), "RandomName")]
        public static class PatchRandomNameGeneration
        {
            private static void Postfix(ref string __result)
            {
                if (!Plugin.NameService.IsInitialized)
                    return;

                __result = Plugin.NameService.NextName();
            }
        }
    }
}