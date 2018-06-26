using System;
using AmaruCommon.Actions.Targets;
using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties.Abilities;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.CreatureEffects;
using AmaruCommon.GameAssets.Cards.Properties.SpellAbilities;

namespace AmaruCommon.GameAssets.Cards
{
    public class CardFactory
    {
        public static Card GetMoraikaCard(Moraika card)
        {
            switch (card)
            {
                case Moraika.Imperia:
                    return new CreatureCard(new CardEnum(card), "Imperia", 5, 5, new ImperiaAttack(1), ability: new DoubleHPAbility(1,0), isLegendary: true);
                case Moraika.RavenCrow:
                    return new CreatureCard(new CardEnum(card), "Raven Crow", 1, 2, new GainHPAttack(1, 1, 1, true),shield:Shield.SHIELDMAIDEN);
                case Moraika.PoolOfLight:
                    return new CreatureCard(new CardEnum(card), "Pool of Light", 2, 3, new GainHPAttack(1,1,1,false), ability: new GainHPAbility(1,0,2), shield: Shield.SHIELDMAIDEN);
                case Moraika.ElCondor:
                    return new CreatureCard(new CardEnum(card), "El Condor", 2, 5, new SimpleAttack(1, 2), shield: Shield.SHIELDMAIDEN);
                case Moraika.PurewhiteAlbatross:
                    return new CreatureCard(new CardEnum(card), "Purewhite Albatross", 3, 4, new SimpleAttack(1, 2), creatureEffect: new GainHPForDamageEffect(), ability: new GainHPAbility(2,0,4), shield: Shield.SHIELDUP);
                case Moraika.SacredOwl:
                    return new CreatureCard(new CardEnum(card), "Sacred Owl", 3, 2, new SimpleAttack(1, 3), creatureEffect: new IfKillGainHPEffect(), shield: Shield.SHIELDUP);
                case Moraika.ImperialTucan:
                    return new CreatureCard(new CardEnum(card), "Imperial Toucan", 4, 4, new SimpleAttack(1, 3),ability: new BonusAttackDependingOnHealthAbility(1,2,2));
                case Moraika.WindFury:
                    return new SpellCard(new CardEnum(card), "Wind Fury", 3, new DealDamageDependingOnMAXHPSpellAbility());
                case Moraika.HealthManagement:
                    return new SpellCard(new CardEnum(card), "Health Management", 2, new GiveHPSpellAbility(5));
                case Moraika.InfinitePower:
                    return new SpellCard(new CardEnum(card), "Infinite Power", 3, new AttackEqualToHPSpellAbility());
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetLunaCard(Luna card)
        {
            switch (card)
            {
                case Luna.Salazar:
                    return new CreatureCard(new CardEnum(card), "Salazar", 5, 7, new SalazarAttack(1), ability: new SalazarAbility(1,1,1), isLegendary: true);
                case Luna.BlackMamba:
                    return new CreatureCard(new CardEnum(card), "Black Mamba", 1, 2, new PoisonAttack(1, 2), creatureEffect: new GainAdditionalEPEffect(), ability: new DamageWithPDAbility(2,1,2));
                case Luna.GreenAnaconda:
                    return new CreatureCard(new CardEnum(card), "Green Anaconda", 2, 4, new PoisonAttack(1, 3), creatureEffect: new HalveDamageIfPDEffect(),  shield: Shield.SHIELDUP);
                case Luna.ReticulatedPython:
                    return new CreatureCard(new CardEnum(card), "Reticulated Python", 2, 3, new PoisonAttack(1, 3), ability: new DamageWithPDAbility(1,2,1), shield: Shield.SHIELDMAIDEN);
                case Luna.RustyTaipan:
                    return new CreatureCard(new CardEnum(card), "Rusty Taipan", 3, 5, new PoisonAttack(1, 4), ability: new DamageWithPDAbility(1,3,1), shield: Shield.SHIELDMAIDEN);
                case Luna.Rattlesnake:
                    return new CreatureCard(new CardEnum(card), "Rattlesnake", 4, 4, new PoisonAttack(1, 2), ability: new KillIfPDAbility(1, 1, 4));
                case Luna.DragonSnake:
                    return new CreatureCard(new CardEnum(card), "Dragon Snake", 12, 7, new PoisonAttack(1, 5), creatureEffect: new CostLessForPDEffect(), shield: Shield.SHIELDUP);
                case Luna.Plague:
                    return new SpellCard(new CardEnum(card), "Plague",2, new PDDamageToCreatureSpellAbility(3));
                case Luna.SmogBomb:
                    return new SpellCard(new CardEnum(card), "Smog Bomb", 2, new DamagePDToAllCreaturesOfTargetPlayerSpellAbility(1));
                case Luna.PoisonBomb:
                    return new SpellCard(new CardEnum(card), "Poison Bomb", 3, new DealDamageDependingOnPDNumberSpellAbility());
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetLeonCard(Leon card)
        {
            switch (card)
            {
                case Leon.Seribu:
                    return new CreatureCard(new CardEnum(card), "Seribu", 5, 7, new SeribuAttack(1), ability: new SeribuAbility(1,0), isLegendary: true);
                case Leon.LightingLynx:
                    return new CreatureCard(new CardEnum(card), "Lighting Lynx", 1, 1, new SimpleAttack(1, 3));
                case Leon.ShieldedBear:
                    return new CreatureCard(new CardEnum(card), "Shielded Bear", 1, 2, new SimpleAttack(1, 2), ability: new SummonAbility(1,0,(CreatureCard)GetLeonCard(Leon.Bear)), shield:Shield.SHIELDMAIDEN);
                case Leon.PatriarchBull:
                    return new CreatureCard(new CardEnum(card), "Patriarch Bull", 2, 4, new SimpleAttack(1, 3), ability: new SummonAbility(1, 0, (CreatureCard)GetLeonCard(Leon.Calf)), shield:Shield.SHIELDUP);
                case Leon.WildHorse:
                    return new CreatureCard(new CardEnum(card), "Wild Horse", 3, 3, new SimpleAttack(1, 3), ability: new DamageDependingOnCreatureNumberAbility(1,1,0,Place.OUTER));
                case Leon.BloodborneRhino:
                    return new CreatureCard(new CardEnum(card), "Bloodborne Rhino", 3, 4, new SimpleAttack(1, 3), ability: new DamageDependingOnCreatureNumberAbility(2,1,4,Place.INNER), shield: Shield.SHIELDMAIDEN);
                case Leon.FieryLion:
                    return new CreatureCard(new CardEnum(card), "Fiery Lion", 4, 5, new SimpleAttack(1, 3) , creatureEffect: new AttackBuffInSpecificZoneEffect());
                case Leon.Duplicator:
                    return new SpellCard(new CardEnum(card), "Duplicator", 2, new DuplicatorSpellAbility());
                case Leon.WarHorn:
                    return new SpellCard(new CardEnum(card), "War Horn", 3, new AttackFromInnerSpellAbility(1));
                case Leon.Bear:
                    return new CreatureCard(new CardEnum(card), "Bear", 0, 2, new SimpleAttack(1, 1), shield: Shield.SHIELDMAIDEN);
                case Leon.Calf:
                    return new CreatureCard(new CardEnum(card), "Calf", 0, 2, new SimpleAttack(1, 1), shield: Shield.SHIELDUP);
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetYakuCard(Yaku card)
        {
            switch (card)
            {
                case Yaku.Krum:
                    return new CreatureCard(new CardEnum(card), "Krum", 7, 9, new KrumAttack(1), creatureEffect: new GainCPForCardPlayedEffect(), isLegendary: true);
                case Yaku.BlackSeaNettle:
                    return new CreatureCard(new CardEnum(card), "Black Sea Nettle", 1, 1, new GainCPAttack(1, 1, 1), ability: new GainCPAbility(1,0,2));
                case Yaku.RoyalStarfish:
                    return new CreatureCard(new CardEnum(card), "Royal Starfish", 2, 2, new SimpleAttack(1, 2), ability: new GiveEPAbility(1,1,1));
                case Yaku.BigClawSnappingShrimp:
                    return new CreatureCard(new CardEnum(card), "Big-Claw Snapping Shrimp", 3, 3, new SimpleAttack(1, 2), ability: new SpendCPToDealDamageAbility(3,1));
                case Yaku.MuggerCrocodile:
                    return new CreatureCard(new CardEnum(card), "Mugger Crocodile", 5, 5, new DrawCardAndAttack(1, 4), shield:Shield.SHIELDMAIDEN);
                case Yaku.ReaperKraken:
                    return new CreatureCard(new CardEnum(card), "Reaper Kraken", 5, 4, new SimpleAttack(1, 3), ability: new ResurrectOrTakeFromGraveyardAbility(2,1,Place.HAND), shield: Shield.SHIELDMAIDEN);
                case Yaku.KillerWhale:
                    return new CreatureCard(new CardEnum(card), "Giant Whale", 6, 8, new SimpleAttack(2, 5), ability: new ReturnToHandAbility(2,1), shield: Shield.BOTH);
                case Yaku.EnergyMaker:
                    return new SpellCard(new CardEnum(card), "Energy Maker", 2, new AddEPAndDrawSpellAbility());
                case Yaku.WavesPower:
                    return new SpellCard(new CardEnum(card), "Waves Power", 2, new GainCpSpellAbility());
                case Yaku.Rainstorm:
                    return new SpellCard(new CardEnum(card), "Rainstorm", 4, new DealTotDamageToTotTargetsSpellAbility());
                default:
                    throw new NotImplementedException();
            }
        }
        public static Card GetAmaruCard(Amaru card)
        {
            switch (card)
            {
                case Amaru.AmaruIncarnation:
                    return new CreatureCard(new CardEnum(card), "Amaru's Incarnation", 8, 11, new SimpleAttack(1,7), ability: new AmaruIncarnationAbility(1,1), shield:Shield.SHIELDUP, isLegendary: true);
                case Amaru.SoulGuardian:
                    return new CreatureCard(new CardEnum(card), "Soul Guardian", 2, 6, null, ability: new ResurrectOrTakeFromGraveyardAbility(2,0,Place.OUTER), shield: Shield.SHIELDUP);
                case Amaru.BodyGuardian:
                    return new CreatureCard(new CardEnum(card), "Body Guardian", 2, 6, null, ability: new ResurrectOrTakeFromGraveyardAbility(2, 0, Place.OUTER), shield: Shield.SHIELDMAIDEN);
                case Amaru.AmaruAdept:
                    return new CreatureCard(new CardEnum(card), "Amaru's Adept", 3, 4, new SimpleAttack(1, 2),  creatureEffect: new ImmunityCreatureEffect(), ability: new DamageWithPDAbility(1, 3, 1), shield: Shield.SHIELDUP);
                case Amaru.Colossus:
                    return new CreatureCard(new CardEnum(card), "Colossus", 5, 8, new SimpleAttack(1, 5), creatureEffect: new ImmunityCreatureEffect());
                case Amaru.Cataclysm:
                    return new SpellCard(new CardEnum(card), "Cataclysm", 4, new DealDamageToEverythingSpellAbility());
                case Amaru.SpiritualPortal:
                    return new SpellCard(new CardEnum(card), "Spiritual Portal", 2, new ResurrectOrReturnToHandSpellAbility(Place.OUTER,0));
                case Amaru.PowerOfResurrection:
                    return new SpellCard(new CardEnum(card), "Power of Resurrection", 6, new ResurrectSpecificCreatureSpellAbility(Place.OUTER,0));
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
