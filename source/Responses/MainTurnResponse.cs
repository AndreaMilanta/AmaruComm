using System;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class MainTurnResponse : Response
    {
        public MainTurnResponse()
        {

        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
