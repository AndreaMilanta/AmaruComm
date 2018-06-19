using System;

using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    public interface IPropertyVisitor
    {
        // Attacks
        int Visit(GainCPAttack attack);
        int Visit(GainHPAttack attack);
        int Visit(ImperiaAttack attack);
        int Visit(AttackFromInnerSpellAbility attackFromInnerSpellAbility);
        int Visit(KrumAttack attack);
        int Visit(PoisonAttack attack);
        int Visit(SalazarAttack attack);
        int Visit(SeribuAttack attack);
        int Visit(SimpleAttack attack);

        // Ability
        int Visit(GainHPAbility ability);
        int Visit(ReturnToHandAbility returnToHandAbility);
        int Visit(SalazarAbility salazarAbility);
        int Visit(SpendCPToDealDamageAbility spendCPToDealDamageAbility);
        int Visit(ResurrectOrTakeFromGraveyardAbility resurrectAbility);
        int Visit(SeribuAbility seribuAbility);
        int Visit(KillIfPDAbility killIfPDAbility);
        int Visit(SummonAbility summonAbility);
        int Visit(AmaruIncarnationAbility amaruIncarnationAbility);
        int Visit(DamageDependingOnCreatureNumberAbility damageDependingOnCreatureNumberAbility);
        int Visit(BonusAttackDependingOnHealthAbility bonusAttackDependingOnHealthAbility);
        int Visit(DamageWithPDAbility damageWithPDAbility);
        int Visit(GiveEPAbility ability);
        int Visit(GainCPAbility gainCPAbility);
    }
}
