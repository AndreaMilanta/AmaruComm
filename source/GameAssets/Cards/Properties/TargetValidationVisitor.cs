using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.Actions.Targets;
using AmaruCommon.Exceptions;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.CreatureEffects;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    /// <summary>
    /// Controlla se il target passato è valido per il tipo di ability o spellAbility
    /// Controlla se:
    /// - il target è di tipo accettato (PlayerTarget e/o CardTarget)
    /// - il target è del giocatore corretto (tutti / mio)
    /// NON Controlla:
    /// - il target è nella posizione giusta
    /// 
    /// </summary>
    public class TargetValidationVisitor : PropertyVisitor
    {
        public Target Target { get; set; }
        public TargetValidationVisitor(string logger) : base(logger)
        {

        }

        public override int Visit(GainCPAttack attack)
        {
            return 0;
        }

        public override int Visit(GainHPAttack attack)
        {
            return 0;
        }

        public override int Visit(ImperiaAttack attack)
        {
            return 0;
        }

        public override int Visit(KrumAttack attack)
        {
            return 0;
        }

        public override int Visit(PoisonAttack attack)
        {
            return 0;
        }

        public override int Visit(SalazarAttack attack)
        {
            return 0;
        }

        public override int Visit(SeribuAttack attack)
        {
            return 0;
        }

        public override int Visit(SimpleAttack attack)
        {
            return 0;
        }

        public override int Visit(GainHPAbility ability)
        {
            if (Target == null)
                return 0;
            if (Target is CardTarget)
                if (((CardTarget)Target).CardId == this.OwnerCard.Id)
                    return 0;
            throw new InvalidTargetException();
        }

        public override int Visit(ReturnToHandAbility returnToHandAbility)
        {
            
        }

        public override int Visit(SalazarAbility salazarAbility)
        {
            return 0;
        }

        public override int Visit(SpendCPToDealDamageAbility spendCPToDealDamageAbility)
        {
            return 0;
        }

        public override int Visit(ResurrectOrTakeFromGraveyardAbility resurrectAbility)
        {
            return 0;
        }

        public override int Visit(SeribuAbility seribuAbility)
        {
            return 0;
        }

        public override int Visit(KillIfPDAbility killIfPDAbility)
        {
            return 0;
        }

        public override int Visit(SummonAbility summonAbility)
        {
            return 0;
        }

        public override int Visit(AmaruIncarnationAbility amaruIncarnationAbility)
        {
            return 0;
        }

        public override int Visit(DamageDependingOnCreatureNumberAbility damageDependingOnCreatureNumberAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(BonusAttackDependingOnHealthAbility bonusAttackDependingOnHealthAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DamageWithPDAbility damageWithPDAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(GiveEPAbility ability)
        {
            throw new NotImplementedException();
        }

        public override int Visit(GainCPAbility gainCPAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DoubleHPAbility doubleHPAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DuplicatorSpellAbility duplicatorSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(AddEPAndDrawSpellAbility addEPAndDrawSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(PDDamageToCreatureSpellAbility pDDamageToCreatureSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(ResurrectSpecificCreatureSpellAbility resurrectSpecificCreatureSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(ResurrectOrReturnToHandSpellAbility resurrectOrReturnToHandSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(GiveHPSpellAbility giveHPSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(GainCpSpellAbility gainCpSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(AttackFromInnerSpellAbility attackFromInnerSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DealDamageDependingOnPDNumberSpellAbility dealDamageDependingOnPDNumberSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DealDamageToEverythingSpellAbility dealDamageToEverythingSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DealTotDamageToTotTargetsSpellAbility dealTotDamageToTotTargetsSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DamagePDToAllCreaturesOfTargetPlayerSpellAbility damagePDToAllCreaturesOfTargetPlayerSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DealDamageDependingOnMAXHPSpeelAbility dealDamageDependingOnMAXHPSpeelAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(AttackEqualToHPSpellAbility attackEqualToHPSpellAbility)
        {
            throw new NotImplementedException();
        }

        public override int Visit(HalveDamageIfPDEffect halveDamageIfPDEffect)
        {
            throw new NotImplementedException();
        }

        public override int Visit(CostLessForPDEffect costLessForPDEffect)
        {
            throw new NotImplementedException();
        }

        public override int Visit(GainHPForDamageEffect gainHPForDamageEffect)
        {
            throw new NotImplementedException();
        }

        public override int Visit(IfKillGainHPEffect ifKillGainHPEffect)
        {
            throw new NotImplementedException();
        }

        public override int Visit(GainAdditionalEPEffect gainAdditionalEPEffect)
        {
            throw new NotImplementedException();
        }

        public override int Visit(GainCPForCardPlayedEffect gainCPForCardPlayed)
        {
            throw new NotImplementedException();
        }

        public override int Visit(DrawCardAndAttack drawCardAndAttack)
        {
            throw new NotImplementedException();
        }

        public override int Visit(AttackBuffInSpecificZoneEffect attackBuffInSpecificZoneEffect)
        {
            throw new NotImplementedException();
        }

        public override int Visit(ImmunityCreatureEffect immunityCreatureEffect)
        {
            throw new NotImplementedException();
        }
    }
}
