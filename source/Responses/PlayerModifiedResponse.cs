using AmaruCommon.GameAssets.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class PlayerModifiedResponse : Response
    {        
        public CharacterEnum Character { get; private set; }
        public int NewMana { get; private set; }
        public int NewHealth { get; private set; }
        
        public PlayerModifiedResponse(CharacterEnum character, int newMana, int newHealth)
        {
            this.Character = character;
            this.NewMana = newMana;
            this.NewHealth = newHealth;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
