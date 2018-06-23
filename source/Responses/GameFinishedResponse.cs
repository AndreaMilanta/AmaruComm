using AmaruCommon.GameAssets.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class GameFinishedResponse : Response
    {
        public CharacterEnum Winner { get; private set; }

        public GameFinishedResponse(CharacterEnum winner)
        {
            this.Winner = winner;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
