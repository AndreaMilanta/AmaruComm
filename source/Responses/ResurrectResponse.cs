using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class ResurrectResponse : Response
    {
        public CharacterEnum Caller { get; private set; }
        public CreatureCard Evoked { get; private set; }
        public Place Destination { get; private set; }

        public ResurrectResponse(CharacterEnum caller, CreatureCard evoked, Place destination)
        {
            this.Caller = caller;
            this.Evoked = evoked;
            this.Destination = destination;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
