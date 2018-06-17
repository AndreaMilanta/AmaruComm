using System;
using System.Collections.Generic;

using AmaruCommon.Constants;
using AmaruCommon.Exceptions;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.GameAssets.Cards
{
    public static class DeckFactory
    {
        /// <summary>
        /// New shuffled Moraika Deck
        /// </summary>
        public static List<Card> MoraikaDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
            CardFactory.GetMoraikaCard(Moraika.Imperia),
            CardFactory.GetMoraikaCard(Moraika.RavenCrow),
            CardFactory.GetMoraikaCard(Moraika.RavenCrow),
            CardFactory.GetMoraikaCard(Moraika.RavenCrow),
            CardFactory.GetMoraikaCard(Moraika.PoolOfLight),
            CardFactory.GetMoraikaCard(Moraika.PoolOfLight),
            CardFactory.GetMoraikaCard(Moraika.ElCondor),
            CardFactory.GetMoraikaCard(Moraika.ElCondor),
            CardFactory.GetMoraikaCard(Moraika.PurewhiteAlbatross),
            CardFactory.GetMoraikaCard(Moraika.PurewhiteAlbatross),
            CardFactory.GetMoraikaCard(Moraika.SacredOwl),
            CardFactory.GetMoraikaCard(Moraika.SacredOwl),
            CardFactory.GetMoraikaCard(Moraika.ImperialTucan),
            CardFactory.GetMoraikaCard(Moraika.ImperialTucan),
            CardFactory.GetMoraikaCard(Moraika.WindFury),
            CardFactory.GetMoraikaCard(Moraika.WindFury),
            CardFactory.GetMoraikaCard(Moraika.HealthManagement),
            CardFactory.GetMoraikaCard(Moraika.HealthManagement),
            CardFactory.GetMoraikaCard(Moraika.InfinitePower),
            CardFactory.GetMoraikaCard(Moraika.InfinitePower)
        }); }
        
        /// <summary>
        /// New shuffled Luna Deck
        /// </summary>
        public static List<Card> LunaDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
            CardFactory.GetLunaCard(Luna.Salazar),
            CardFactory.GetLunaCard(Luna.BlackMamba),
            CardFactory.GetLunaCard(Luna.BlackMamba),
            CardFactory.GetLunaCard(Luna.BlackMamba),
            CardFactory.GetLunaCard(Luna.GreenAnaconda),
            CardFactory.GetLunaCard(Luna.GreenAnaconda),
            CardFactory.GetLunaCard(Luna.ReticulatedPython),
            CardFactory.GetLunaCard(Luna.ReticulatedPython),
            CardFactory.GetLunaCard(Luna.RustyTaipan),
            CardFactory.GetLunaCard(Luna.RustyTaipan),
            CardFactory.GetLunaCard(Luna.Rattlesnake),
            CardFactory.GetLunaCard(Luna.Rattlesnake),
            CardFactory.GetLunaCard(Luna.DragonSnake),
            CardFactory.GetLunaCard(Luna.DragonSnake),
            CardFactory.GetLunaCard(Luna.Plague),
            CardFactory.GetLunaCard(Luna.Plague),
            CardFactory.GetLunaCard(Luna.SmogBomb),
            CardFactory.GetLunaCard(Luna.SmogBomb),
            CardFactory.GetLunaCard(Luna.PoisonBomb),
            CardFactory.GetLunaCard(Luna.PoisonBomb),
        }); }

        /// <summary>
        /// New shuffled Leon Deck
        /// </summary>
        public static List<Card> LeonDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
            CardFactory.GetLeonCard(Leon.Seribu),
            CardFactory.GetLeonCard(Leon.LightingLynx),
            CardFactory.GetLeonCard(Leon.LightingLynx),
            CardFactory.GetLeonCard(Leon.LightingLynx),
            CardFactory.GetLeonCard(Leon.ShieldedBear),
            CardFactory.GetLeonCard(Leon.ShieldedBear),
            CardFactory.GetLeonCard(Leon.PatriarchBull),
            CardFactory.GetLeonCard(Leon.PatriarchBull),
            CardFactory.GetLeonCard(Leon.WildHorse),
            CardFactory.GetLeonCard(Leon.WildHorse),
            CardFactory.GetLeonCard(Leon.BloodborneRhino),
            CardFactory.GetLeonCard(Leon.BloodborneRhino),
            CardFactory.GetLeonCard(Leon.FieryLion),
            CardFactory.GetLeonCard(Leon.FieryLion),
            CardFactory.GetLeonCard(Leon.Duplicator),
            CardFactory.GetLeonCard(Leon.Duplicator),
            CardFactory.GetLeonCard(Leon.Duplicator),
            CardFactory.GetLeonCard(Leon.WarHorn),
            CardFactory.GetLeonCard(Leon.WarHorn),
            CardFactory.GetLeonCard(Leon.WarHorn),

        }); }

        /// <summary>
        /// New shuffled Yaku Deck
        /// </summary>
        public static List<Card> YakuDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
            CardFactory.GetYakuCard(Yaku.Krum),
            CardFactory.GetYakuCard(Yaku.BlackSeaNettle),
            CardFactory.GetYakuCard(Yaku.BlackSeaNettle),
            CardFactory.GetYakuCard(Yaku.BlackSeaNettle),
            CardFactory.GetYakuCard(Yaku.RoyalStarfish),
            CardFactory.GetYakuCard(Yaku.RoyalStarfish),
            CardFactory.GetYakuCard(Yaku.BigClawSnappingShrimp),
            CardFactory.GetYakuCard(Yaku.BigClawSnappingShrimp),
            CardFactory.GetYakuCard(Yaku.MuggerCrocodile),
            CardFactory.GetYakuCard(Yaku.MuggerCrocodile),
            CardFactory.GetYakuCard(Yaku.ReaperKraken),
            CardFactory.GetYakuCard(Yaku.ReaperKraken),
            CardFactory.GetYakuCard(Yaku.KillerWhale),
            CardFactory.GetYakuCard(Yaku.KillerWhale),
            CardFactory.GetYakuCard(Yaku.EnergyMaker),
            CardFactory.GetYakuCard(Yaku.EnergyMaker),
            CardFactory.GetYakuCard(Yaku.WavesPower),
            CardFactory.GetYakuCard(Yaku.WavesPower),
            CardFactory.GetYakuCard(Yaku.Rainstorm),
            CardFactory.GetYakuCard(Yaku.Rainstorm)

        }); }

        /// <summary>
        /// New shuffled Amaru Deck
        /// </summary>
        public static List<Card> AmaruDeck { get => Tools.Shuffle(new List<Card>() {
            // Insert cards declaration
            CardFactory.GetAmaruCard(Amaru.AmaruIncarnation),
            CardFactory.GetAmaruCard(Amaru.SoulGuardian),
            CardFactory.GetAmaruCard(Amaru.SoulGuardian),
            CardFactory.GetAmaruCard(Amaru.SoulGuardian),
            CardFactory.GetAmaruCard(Amaru.SoulGuardian),
            CardFactory.GetAmaruCard(Amaru.BodyGuardian),
            CardFactory.GetAmaruCard(Amaru.BodyGuardian),
            CardFactory.GetAmaruCard(Amaru.BodyGuardian),
            CardFactory.GetAmaruCard(Amaru.BodyGuardian),
            CardFactory.GetAmaruCard(Amaru.AmaruAdept),
            CardFactory.GetAmaruCard(Amaru.AmaruAdept),
            CardFactory.GetAmaruCard(Amaru.AmaruAdept),
            CardFactory.GetAmaruCard(Amaru.AmaruAdept),
            CardFactory.GetAmaruCard(Amaru.Colossus),
            CardFactory.GetAmaruCard(Amaru.Colossus),
            CardFactory.GetAmaruCard(Amaru.Colossus),
            CardFactory.GetAmaruCard(Amaru.Colossus),
            CardFactory.GetAmaruCard(Amaru.Cataclysm),
            CardFactory.GetAmaruCard(Amaru.Cataclysm),
            CardFactory.GetAmaruCard(Amaru.Cataclysm),
            CardFactory.GetAmaruCard(Amaru.Cataclysm),
            CardFactory.GetAmaruCard(Amaru.SpiritualPortal),
            CardFactory.GetAmaruCard(Amaru.SpiritualPortal),
            CardFactory.GetAmaruCard(Amaru.SpiritualPortal),
            CardFactory.GetAmaruCard(Amaru.SpiritualPortal),
            CardFactory.GetAmaruCard(Amaru.SpiritualPortal),
            CardFactory.GetAmaruCard(Amaru.PowerOfResurrection),
            CardFactory.GetAmaruCard(Amaru.PowerOfResurrection),
            CardFactory.GetAmaruCard(Amaru.PowerOfResurrection),
            CardFactory.GetAmaruCard(Amaru.PowerOfResurrection),
        }); }

        /// <summary>
        /// Returns a new shuffled deck of given character
        /// </summary>
        /// <param name="character"></param>
        /// <exception cref="InvalidCharacterException"></exception>
        /// <returns></returns>
        public static List<Card> GetDeck(CharacterEnum character)
        {
            switch (character)
            {
                case CharacterEnum.MORAIKA: return MoraikaDeck;
                case CharacterEnum.LUNA:    return LunaDeck;
                case CharacterEnum.LEON:    return LeonDeck;
                case CharacterEnum.YAKU:    return YakuDeck;
                case CharacterEnum.AMARU:   return AmaruDeck;
                default: throw new InvalidCharacterException();
            }
        }
    }
}
