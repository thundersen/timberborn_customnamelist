using HarmonyLib;
using Timberborn.Beavers;

namespace CustomNameList
{
    class RandomNamePatch
    {
        [HarmonyPatch(typeof(BeaverNameService), "RandomName")]
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