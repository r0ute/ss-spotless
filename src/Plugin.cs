using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using HarmonyLib;

namespace SS.src;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;

    internal static ConfigEntry<bool> SpawnGarbage;

    internal static ConfigEntry<bool> Dusting;

    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;

        SpawnGarbage = Config.Bind("*General*", "SpawnGarbage", false, "Enable to spawn garbage");
        Dusting = Config.Bind("*General*", "Dusting", false, "Enable dusting");

        Harmony harmony = new(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll(typeof(Patches));

        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }


    class Patches
    {

        [HarmonyPatch(typeof(GarbageManager), nameof(GarbageManager.SpawnGarbage))]
        [HarmonyPrefix]
        static void OnSpawnGarbage(ref bool __runOriginal)
        {
            __runOriginal = SpawnGarbage.Value;

        }

        [HarmonyPatch(typeof(GarbageManager), nameof(GarbageManager.Dusting))]
        [HarmonyPrefix]
        static void OnDusting(ref bool __runOriginal)
        {
            __runOriginal = Dusting.Value;
        }

    }
}
