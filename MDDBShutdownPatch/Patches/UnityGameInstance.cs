using BattleTech.Data;
using Harmony;

// ReSharper disable UnusedMember.Global
// ReSharper disable InconsistentNaming

namespace MDDBShutdownPatch.Patches
{
    [HarmonyPatch(typeof(MetadataDatabase), "Shutdown")]
    public static class MetadataDatabase_Shutdown_Patch
    {
        public static bool Prefix()
        {
            return false;
        }
    }
}
