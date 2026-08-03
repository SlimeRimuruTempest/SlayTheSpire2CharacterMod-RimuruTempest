using Godot;
using STS2RitsuLib.Character;
using STS2RitsuLib.Interop.AutoRegistration;

namespace RimuruTempest;

[RegisterCharacter]
public sealed class RimuruTempestCharacter
    : ModCharacterTemplate<RimuruTempestCardPool, RimuruTempestRelicPool, RimuruTempestPotionPool>
{
    public override int StartingHp => 72;
    public override int StartingGold => 99;
    public override CharacterGender Gender => CharacterGender.Neutral;
    public override Color NameColor => new("88bbcc"); // 利姆露银蓝发色
    public override float AttackAnimDelay => 0.15f;
    public override float CastAnimDelay => 0.25f;
}
