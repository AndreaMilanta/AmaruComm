using System.ComponentModel;

namespace AmaruCommon.Constants
{
    public static class AmaruConstants
    {
        // Logging
        public const string GAME_PREFIX = "Game_";

        // Game
        //public const int NUM_PLAYER = 4;
        public const int NUM_PLAYER = 1;
        public const int NUM_CHARACTERS = 5;
        //public const int NUM_DISADVANTAGED = 2;     // Number of disadvantaged players (last - )
        public const int NUM_DISADVANTAGED = 0;     // Number of disadvantaged players (last - )

        // Players
        public const int INITIAL_PLAYER_HEALTH = 20;    // Initial Health of a player
        public const int INITIAL_AMARU_HEALTH = 50;     // Initial Health of Amaru

        // Decks Constants
        public const int INITIAL_HAND_SIZE = 3;     // Number of cards in hand at the beginning
        public const int INITIAL_HAND_BONUS = 1;    // Number of extra cards for disadvantaged players (3, 4)
        public const int HAND_MAX_SIZE = 6;         // Maximum number of cards in hand
        public const int INNER_MAX_SIZE = 6;        // Maximum number of cards in inner zone
        public const int OUTER_MAX_SIZE = 6;        // Maximum number of cards in outer zone

        // Cards constants
        internal const int AUTO_ID = -1;            // Value used to set card id automatically !! MUST BE < 0 !!
    }

    // Useful Enums

    // Possible locations of a card
    public enum Place
    {
        DECK,
        HAND,
        INNER,
        OUTER,
        CEMETERY
    }

    public enum Property
    {
        ATTACK,
        ABILITY
    }
    
    public enum Shield
    {
        NONE,
        SHIELDUP,
        SHIELDMAIDEN,
        BOTH
    }
    
    // LIST OF CARDS (for implementation see CardFactory.cs)

    public enum Moraika
    {
        Imperia,
        RavenCrow,
        PoolOfLight,
        ElCondor,
        PurewhiteAlbatross,
        SacredOwl,
        ImperialTucan,
        WindFury,
        HealthManagement,
        InfinitePower
    }
    // Amaru
    public enum Luna
    {
        Salazar,
        BlackMamba,
        GreenAnaconda,
        ReticulatedPython,
        RustyTaipan,
        Rattlesnake,
        DragonSnake,
        Plague,
        SmogBomb,
        PoisonBomb
    }

    // Amaru
    public enum Leon
    {
        Seribu,
        LightingLynx,
        ShieldedBear,
        PatriarchBull,
        WildHorse,
        BloodborneRhino,
        FieryLion,
        Duplicator,
        WarHorn,
        Calf,
        Bear
    }
    // Amaru
    public enum Yaku
    {
        Krum,
        BlackSeaNettle,
        RoyalStarfish,
        BigClawSnappingShrimp,
        MuggerCrocodile,
        Kraken,
        KillerWhale,
        EnergyMaker,
        WavesPower,
        Rainstorm
    }

    // Amaru
    public enum Amaru
    {
        AmaruIncarnation,
        SoulGuardian,
        BodyGuardian,
        AmaruAdept,
        Colossus,
        Cataclysm,
        PowerOfResurrection,
        SpiritualPortal
    }

}
