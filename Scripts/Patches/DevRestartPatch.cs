using System;
using Godot;
using HarmonyLib;

namespace RimuruTempest.Patches;

[HarmonyPatch]
public static class DevRestartPatch
{
    [HarmonyPrefix]
    [HarmonyPatch(typeof(SceneTree), nameof(SceneTree._Process))]
    static void CheckRestart()
    {
        if (Input.IsPhysicalKeyPressed(Key.F5))
            EngineTime.Scale = 0f;
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(SceneTree), nameof(SceneTree._Process))]
    static void ApplyRestart()
    {
        if (Input.IsKeyPressed(Key.F5))
        {
            var tree = (SceneTree)Engine.GetMainLoop();
            tree.ReloadCurrentScene();
        }
    }
}
