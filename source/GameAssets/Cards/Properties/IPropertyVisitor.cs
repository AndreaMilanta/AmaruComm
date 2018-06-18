using System;

using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Effects;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    public interface IPropertyVisitor
    {
        // Attacks
        int Visit(GainCPAttack attack);
        int Visit(GainHPAttack attack);
        int Visit(ImperiaAttack attack);
        int Visit(KrumAttack attack);
        int Visit(PoisonAttack attack);
        int Visit(SalazarAttack attack);
        int Visit(SeribuAttack attack);
        int Visit(SimpleAttack attack);

        // Effects
        int Visit(AttackFromInnerEffect effect);

        // Ability
        int Visit(GainHPAbility ability);
        int Visit(GiveEPAbility ability);
    }
}
