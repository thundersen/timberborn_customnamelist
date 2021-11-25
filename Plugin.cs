using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;
using System.IO;
using UnityEngine;

namespace CustomNameList
{
    [BepInPlugin("com.thundersen.timberborn.customnamelist", "Custom Name List", "0.1.2")]
    [BepInProcess("Timberborn.exe")]
    public class Plugin : BaseUnityPlugin
    {
        internal static ManualLogSource Log;

        private static string _namesFilePath = $"{Path.GetDirectoryName(Paths.ExecutablePath)}{Path.DirectorySeparatorChar}names.txt";

        internal static CustomNameService NameService = new CustomNameService(_namesFilePath);

        private void Awake()
        {
            Log = base.Logger;

            NameService.Init();

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());

            Logger.LogInfo($"Plugin com.thundersen.timberborn.customnamelist is loaded!");
        }
    }
}
