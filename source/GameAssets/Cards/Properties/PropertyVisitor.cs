using System;

using AmaruCommon.GameAssets.Players;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;
using AmaruCommon.GameAssets.Cards.Properties.CreatureEffects;
using Logging;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    public abstract class PropertyVisitor : Loggable
    {
        // Set Card and Player
        public Card Card { get; set; }
        public Players.Player Player { get; set; }

        public PropertyVisitor(string logger) : base(logger) { }

        // Attacks
        public abstract int Visit(GainCPAttack attack);
        public abstract int Visit(GainHPAttack attack);
        public abstract int Visit(ImperiaAttack attack);
        public abstract int Visit(KrumAttack attack);
        public abstract int Visit(PoisonAttack attack);
        public abstract int Visit(SalazarAttack attack);
        public abstract int Visit(SeribuAttack attack);
        public abstract int Visit(SimpleAttack attack);

        // Ability
        public abstract int Visit(GainHPAbility ability);
        public abstract int Visit(ReturnToHandAbility returnToHandAbility);
        public abstract int Visit(SalazarAbility salazarAbility);
        public abstract int Visit(SpendCPToDealDamageAbility spendCPToDealDamageAbility);
        public abstract int Visit(ResurrectOrTakeFromGraveyardAbility resurrectAbility);
        public abstract int Visit(SeribuAbility seribuAbility);
        public abstract int Visit(KillIfPDAbility killIfPDAbility);
        public abstract int Visit(SummonAbility summonAbility);
        public abstract int Visit(AmaruIncarnationAbility amaruIncarnationAbility);
        public abstract int Visit(DamageDependingOnCreatureNumberAbility damageDependingOnCreatureNumberAbility);
        public abstract int Visit(BonusAttackDependingOnHealthAbility bonusAttackDependingOnHealthAbility);
        public abstract int Visit(DamageWithPDAbility damageWithPDAbility);
        public abstract int Visit(GiveEPAbility ability);
        public abstract int Visit(GainCPAbility gainCPAbility);

        // SpellAbility
        public abstract int Visit(DuplicatorSpellAbility duplicatorSpellAbility);
        public abstract int Visit(AddEPAndDrawSpellAbility addEPAndDrawSpellAbility);
        public abstract int Visit(PDDamageToCreatureSpellAbility pDDamageToCreatureSpellAbility);
        public abstract int Visit(ResurrectSpecificCreatureSpellAbility resurrectSpecificCreatureSpellAbility);
        public abstract int Visit(ResurrectOrReturnToHandSpellAbility resurrectOrReturnToHandSpellAbility);
        public abstract int Visit(GiveHPSpellAbility giveHPSpellAbility);
        public abstract int Visit(GainCpSpellAbility gainCpSpellAbility);
        public abstract int Visit(AttackFromInnerSpellAbility attackFromInnerSpellAbility);
        public abstract int Visit(DealDamageDependingOnPDNumberSpellAbility dealDamageDependingOnPDNumberSpellAbility);
        public abstract int Visit(DealDamageToEverythingSpellAbility dealDamageToEverythingSpellAbility);
        public abstract int Visit(DealTotDamageToTotTargetsSpellAbility dealTotDamageToTotTargetsSpellAbility);
        public abstract int Visit(DamagePDToAllCreaturesOfTargetPlayerSpellAbility damagePDToAllCreaturesOfTargetPlayerSpellAbility);
        public abstract int Visit(DealDamageDependingOnMAXHPSpeelAbility dealDamageDependingOnMAXHPSpeelAbility);
        public abstract int Visit(AttackEqualToHPSpellAbility attackEqualToHPSpellAbility);

        //Creature Effect
        public abstract int Visit(HalveDamageIfPDEffect halveDamageIfPDEffect);
        public abstract int Visit(CostLessForPDEffect costLessForPDEffect);
        public abstract int Visit(GainHPForDamageEffect gainHPForDamageEffect);
        public abstract int Visit(IfKillGainHPEffect ifKillGainHPEffect);
        public abstract int Visit(GainAdditionalEPEffect gainAdditionalEPEffect);
        public abstract int Visit(GainCPForCardPlayedEffect gainCPForCardPlayed);
        public abstract int Visit(DrawCardAndAttack drawCardAndAttack);
        public abstract int Visit(AttackBuffInSpecificZoneEffect attackBuffInSpecificZoneEffect);

        internal int Visit(ImmunityCreatureEffect immunityCreatureEffect)
        {
            throw new NotImplementedException();
        }
    }
}
