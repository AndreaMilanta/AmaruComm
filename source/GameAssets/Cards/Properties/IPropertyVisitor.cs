using System;

using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;
using AmaruCommon.GameAssets.Cards.Properties.CreatureEffects;

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

        // SpellAbility
        int Visit(DuplicatorSpellAbility duplicatorSpellAbility);
        int Visit(AddEPAndDrawSpellAbility addEPAndDrawSpellAbility);
        int Visit(PDDamageToCreatureSpellAbility pDDamageToCreatureSpellAbility);
        int Visit(ResurrectSpecificCreatureSpellAbility resurrectSpecificCreatureSpellAbility);
        int Visit(ResurrectOrReturnToHandSpellAbility resurrectOrReturnToHandSpellAbility);
        int Visit(GiveHPSpellAbility giveHPSpellAbility);
        int Visit(GainCpSpellAbility gainCpSpellAbility);
        int Visit(AttackFromInnerSpellAbility attackFromInnerSpellAbility);
        int Visit(DealDamageDependingOnPDNumberSpellAbility dealDamageDependingOnPDNumberSpellAbility);
        int Visit(DealDamageToEverythingSpellAbility dealDamageToEverythingSpellAbility);
        int Visit(DealTotDamageToTotTargetsSpellAbility dealTotDamageToTotTargetsSpellAbility);
        int Visit(DamagePDToAllCreaturesOfTargetPlayerSpellAbility damagePDToAllCreaturesOfTargetPlayerSpellAbility);
        int Visit(DealDamageDependingOnMAXHPSpeelAbility dealDamageDependingOnMAXHPSpeelAbility);
        int Visit(AttackEqualToHPSpellAbility attackEqualToHPSpellAbility);

        //Creature Effect
        int Visit(HalveDamageIfPDEffect halveDamageIfPDEffect);
        int Visit(CostLessForPDEffect costLessForPDEffect);
        int Visit(GainHPForDamageEffect gainHPForDamageEffect);
        int Visit(IfKillGainHPEffect ifKillGainHPEffect);
        int Visit(GainAdditionalEPEffect gainAdditionalEPEffect);
        int Visit(GainCPForCardPlayedEffect gainCPForCardPlayed);
        int Visit(DrawCardAndAttack drawCardAndAttack);
        int Visit(AttackBuffInSpecificZoneEffect attackBuffInSpecificZoneEffect);
    }
}
