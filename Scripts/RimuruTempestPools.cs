using Godot;
using STS2RitsuLib.ModSystem.Pools;

namespace RimuruTempest;

public sealed class RimuruTempestCardPool : TypeListCardPoolModel
{
    public override string Title => "Rimuru";
    public override string EnergyColorName => "Blue";
    public override Color DeckEntryCardColor => new("4488cc");
    public override bool IsColorless => false;
}

public sealed class RimuruTempestRelicPool : TypeListRelicPoolModel
{
    public override string Title => "Rimuru";
    public override string EnergyColorName => "Blue";
}

public sealed class RimuruTempestPotionPool : TypeListPotionPoolModel
{
    public override string Title => "Rimuru";
    public override string EnergyColorName => "Blue";
}
