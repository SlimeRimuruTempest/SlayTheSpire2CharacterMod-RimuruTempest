using System.Reflection;
using STS2RitsuLib;
using STS2RitsuLib.ModSystem;

[assembly: ModInitializer(typeof(RimuruTempest.Entry), nameof(RimuruTempest.Entry.Initialize))]

namespace RimuruTempest;

public static class Entry
{
    public const string ModId = "RimuruTempest";
    public static IModLogger Logger = null!;

    public static void Initialize()
    {
        var assembly = Assembly.GetExecutingAssembly();
        Logger = RitsuLibFramework.CreateLogger(ModId);
        ModTypeDiscoveryHub.RegisterModAssembly(ModId, assembly);

        RitsuLibFramework.CreateContentPack(ModId)
            .Character<RimuruTempestCharacter>(c => c
                .AddStartingCard<RimuruStrike>(4, order: 10)
                .AddStartingCard<RimuruDefend>(4, order: 20))
            .Apply();

        Logger.Log("RimuruTempest mod initialized.");
    }
}
