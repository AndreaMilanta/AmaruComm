using AmaruCommon.GameAssets.Characters;
using AmaruCommon.GameAssets.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    [Serializable]
    public struct PlayerMod
    {
        public CharacterEnum Character { get; private set; }
        public int NewMana { get; private set; }
        public int NewHealth { get; private set; }

        public PlayerMod(CharacterEnum character, int newMana, int newHealth)
        {
            this.Character = character;
            this.NewMana = newMana;
            this.NewHealth = newHealth;
        }
        public PlayerMod(Player player)
        {
            this.Character = player.Character;
            this.NewMana = player.Mana;
            this.NewHealth = player.Health;
        }
    }

    [Serializable]
    public class PlayerModifiedResponse : Response
    {
        public List<PlayerMod> Modifieds;
        
        public PlayerModifiedResponse(CharacterEnum character, int newMana, int newHealth)
        {
            Modifieds = new List<PlayerMod>() {new PlayerMod(character, newMana, newHealth)};
        }

        public PlayerModifiedResponse(PlayerMod pMod)
        {
            Modifieds = new List<PlayerMod>() { pMod };
        }

        public PlayerModifiedResponse(List<PlayerMod> mods)
        {
            Modifieds = mods;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
