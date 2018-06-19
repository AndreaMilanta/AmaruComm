using System;

using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    public interface IPropertyVisitor
    {
        // Attacks
        int Visit(GainCPAttack attack);
        int Visit(GainHPAttack attack);
        int Visit(ImperiaAttack attack);
        int Visit(KrumAttack attack);
        int Visit(DuplicatorSpellAbility duplicatorSpellAbility);
        int Visit(AddEPAndDrawSpellAbility addEPAndDrawSpellAbility);
        int Visit(PDDamageToCreatureSpellAbility pDDamageToCreatureSpellAbility);
        int Visit(ResurrectSpecificCreatureSpellAbility resurrectSpecificCreatureSpellAbility);
        int Visit(ResurrectOrReturnToHandSpellAbility resurrectOrReturnToHandSpellAbility);
        int Visit(GiveHPSpellAbility giveHPSpellAbility);
        int Visit(GainCpSpellAbility gainCpSpellAbility);
        int Visit(PoisonAttack attack);
        int Visit(DealDamageDependingOnPDNumberSpellAbility dealDamageDependingOnPDNumberSpellAbility);
        int Visit(DealDamageToEverythingSpellAbility dealDamageToEverythingSpellAbility);
        int Visit(DealTotDamageToTotTargetsSpellAbility dealTotDamageToTotTargetsSpellAbility);
        int Visit(DealDamageDependingOnMAXHPSpeelAbility dealDamageDependingOnMAXHPSpeelAbility);
        int Visit(SalazarAttack attack);
        int Visit(DamagePDToAllCreaturesOfTargetPlayerSpellAbility damagePDToAllCreaturesOfTargetPlayerSpellAbility);
        int Visit(SeribuAttack attack);
        int Visit(SimpleAttack attack);
        int Visit(AttackEqualToHPSpellAbility attackEqualToHPSpellAbility);

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
