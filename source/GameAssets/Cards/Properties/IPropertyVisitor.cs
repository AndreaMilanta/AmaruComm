using System;

using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    public interface IPropertyVisitor
    {
        int Visit(GainCPAttack attack);
        int Visit(AttackFromInnerEffect effect);
        int Visit(GainHPAttack attack);
        int Visit(ImperiaAttack attack);
        int Visit(KrumAttack attack);
        int Visit(PoisonAttack attack);
        int Visit(SalazarAttack attack);
        int Visit(SeribuAttack attack);
        int Visit(SimpleAttack attack);
    }
}
