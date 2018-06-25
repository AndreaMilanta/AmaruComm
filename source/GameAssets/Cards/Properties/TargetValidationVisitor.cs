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
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    /// <summary>
    /// Controlla se il target passato è valido per il tipo di ability o spellAbility
    /// Controlla se:
    /// - il target è di tipo accettato (PlayerTarget e/o CardTarget)
    /// - il target è del giocatore corretto (tutti / mio)
    /// NON Controlla:
    /// - il target è nella posizione giusta
    /// - il target è immune da abilità, e spellabilites
    /// 
    /// </summary>
    public class TargetValidationVisitor : PropertyVisitor
    {
        public Target Target { get; set; }
        public TargetValidationVisitor(string logger) : base(logger)
        {

        }

        private int CheckImmunity()
        {
            if (Target is CardTarget && ((CardTarget)Target).Card.creatureEffect is ImmunityCreatureEffect)
                return -1;
            return 0;
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
            return CheckImmunity();
        }

        public override int Visit(ReturnToHandAbility ability)
        {
            if (Target is CardTarget && Target.Character == this.Owner)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(SalazarAbility ability)
        {
            if (Target is PlayerTarget && Target.Character != this.Owner)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(SpendCPToDealDamageAbility ability)
        {
            // All allowed
            return 0;
        }

        public override int Visit(ResurrectOrTakeFromGraveyardAbility ability)
        {
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(SeribuAbility ability)
        {
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(KillIfPDAbility ability)
        {
            if (Target is CardTarget && ((CardTarget)Target).Card.PoisonDamage>=4)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(SummonAbility ability)
        {
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(AmaruIncarnationAbility ability)
        {
            if (Target is CardTarget && Target.Character != CharacterEnum.AMARU)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DamageDependingOnCreatureNumberAbility ability)
        {
            //All
            return 0;
        }

        public override int Visit(BonusAttackDependingOnHealthAbility ability)
        {
            if (Target is CardTarget)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DamageWithPDAbility ability)
        {
            if (Target is CardTarget)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(GiveEPAbility ability)
        {
            if (Target is CardTarget)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(GainCPAbility ability)
        {
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DoubleHPAbility ability)
        {
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DuplicatorSpellAbility ability)
        {
            if (Target is CardTarget)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(AddEPAndDrawSpellAbility spellAbility)
        {
            if (Target is CardTarget && Target.Character == Owner)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(PDDamageToCreatureSpellAbility spellAbility)
        {
            if (Target is CardTarget)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(ResurrectSpecificCreatureSpellAbility spellAbility)
        {
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(ResurrectOrReturnToHandSpellAbility spellAbility)
        {
            if (Target == null)
                return 0;
            return -1;
        }

        public override int Visit(GiveHPSpellAbility spellAbility)
        {
            // return all;
            return 0;
        }

        public override int Visit(GainCpSpellAbility gainCpSpellAbility)
        {
            // TODO: Check!!
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(AttackFromInnerSpellAbility spellAbility)
        {
            // TODO: Check!!
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DealDamageDependingOnPDNumberSpellAbility spellAbility)
        {
            if (Target.Character != Owner)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DealDamageToEverythingSpellAbility spellAbility)
        {
            if (Target == null)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DealTotDamageToTotTargetsSpellAbility spellAbility)
        {
            if (Target.Character != Owner)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DamagePDToAllCreaturesOfTargetPlayerSpellAbility spellAbility)
        {
            if (Target is PlayerTarget && Target.Character != Owner)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(DealDamageDependingOnMAXHPSpellAbility speelAbility)
        {
            if (Target.Character != Owner)
                return 0;
            return CheckImmunity();
        }

        public override int Visit(AttackEqualToHPSpellAbility spellAbility)
        {
            if (Target is CardTarget)
                return 0;
            return CheckImmunity();
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
