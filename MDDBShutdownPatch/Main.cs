using System.Reflection;
using Harmony;

// ReSharper disable UnusedMember.Global

namespace MDDBShutdownPatch
{
    public static class Main
    {
        public static void Init()
        {
            var harmony = HarmonyInstance.Create("io.github.mpstark.MDDBShutdownPatch");
            harmony.PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
