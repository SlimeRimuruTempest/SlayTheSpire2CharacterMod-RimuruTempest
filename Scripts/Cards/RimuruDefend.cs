using System.Collections.Generic;
using System.Threading.Tasks;
using MegaCrit.Sts2.Core.Commands;
using MegaCrit.Sts2.Core.Entities.Cards;
using MegaCrit.Sts2.Core.GameActions.Multiplayer;
using MegaCrit.Sts2.Core.Localization.DynamicVars;
using MegaCrit.Sts2.Core.Models.Cards;
using MegaCrit.Sts2.Core.ValueProps;
using STS2RitsuLib.Interop.AutoRegistration;
using BaseLib.Abstracts;

namespace RimuruTempest.Cards;

[RegisterCard(typeof(RimuruTempestCardPool))]
public sealed class RimuruDefend : CustomCardModel
{
    public override bool GainsBlock => true;

    protected override HashSet<CardTag> CanonicalTags =>
        new HashSet<CardTag> { CardTag.Defend };

    protected override IEnumerable<DynamicVar> CanonicalVars => [
        new BlockVar(5m, ValueProp.Move)
    ];

    public RimuruDefend()
        : base(1, CardType.Skill, CardRarity.Basic, TargetType.Self,
               exhaust: false, autoAdd: false)
    { }

    protected override async Task OnPlay(PlayerChoiceContext choiceContext,
                                         CardPlay cardPlay)
    {
        await CreatureCmd.GainBlock(base.Owner.Creature,
                                    base.DynamicVars.Block, cardPlay);
    }

    protected override void OnUpgrade()
    {
        base.DynamicVars.Block.UpgradeValueBy(3m);
    }
}
