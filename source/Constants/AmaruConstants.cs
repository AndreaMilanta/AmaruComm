using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Constants
{
    public static class AmaruConstants
    {
        // Logging
        public const string GAME_PREFIX = "Game_";

        // Game
        public const int NUM_PLAYER = 4;
        public const int NUM_CHARACTERS = 5;
        public const int NUM_DISADVANTAGED = 2;     // Number of disadvantaged players (last - )

        // Players
        public const int INITIAL_PLAYER_HEALTH = 20;    // Initial Health of a player
        public const int INITIAL_AMARU_HEALTH = 50;     // Initial Health of Amaru

        // Decks Constants
        public const int INITIAL_HAND_SIZE = 3;     // Number of cards in hand at the beginning
        public const int INITIAL_HAND_BONUS = 1;    // Number of extra cards for disadvantaged players (3, 4)
        public const int HAND_MAX_SIZE = 6;         // Maximum number of cards in hand
        public const int INNER_MAX_SIZE = 6;        // Maximum number of cards in inner zone
        public const int OUTER_MAX_SIZE = 6;        // Maximum number of cards in outer zone
    }
}
