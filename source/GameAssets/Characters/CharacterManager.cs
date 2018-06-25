using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using AmaruCommon.Constants;

namespace AmaruCommon.GameAssets.Characters
{
    public class CharacterManager
    {
        // Singleton stuff
        private static CharacterManager _instance = null;
        public static CharacterManager Instance { get => _instance ?? new CharacterManager(); }

        public List<CharacterEnum> PlayCharacters { get => new List<CharacterEnum>(_playCharacters); }
        public List<CharacterEnum> Characters { get => new List<CharacterEnum>(_characters); }

        // Charactes definition
        private List<CharacterEnum> _playCharacters = new List<CharacterEnum>() {
            CharacterEnum.LEON,
            CharacterEnum.MORAIKA,
            CharacterEnum.LUNA,
            CharacterEnum.YAKU
        };

        private List<CharacterEnum> _characters = new List<CharacterEnum>() {
            CharacterEnum.LEON,
            CharacterEnum.LUNA,
            CharacterEnum.MORAIKA,
            CharacterEnum.YAKU,
            CharacterEnum.AMARU
        };

        // Useful Properties
        public CharacterEnum RandomChar { get => (CharacterEnum)(new Random().Next(AmaruConstants.NUM_CHARACTERS) + CharacterEnum.AMARU); }
        public CharacterEnum RandomPlayChar { get => (CharacterEnum)(new Random().Next(AmaruConstants.NUM_CHARACTERS)); }
        public List<CharacterEnum> RandomPlayCharList { get => Tools.Shuffle(_playCharacters); }

        private CharacterManager()
        {
            _instance = this;
        }

        public List<CharacterEnum> Others(CharacterEnum character)
        {
            List<CharacterEnum> others = new List<CharacterEnum>();
            foreach (CharacterEnum c in _characters)
                if (c != character)
                    others.Add(c);
            return others;
        }

        public List<CharacterEnum> PlayOthers(CharacterEnum character)
        {
            List<CharacterEnum> others = new List<CharacterEnum>();
            foreach (CharacterEnum c in _playCharacters)
                if (c != character)
                    others.Add(c);
            return others;
        }
    }
}
