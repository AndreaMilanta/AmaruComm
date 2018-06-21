using System;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class AttackPlayerResponse : Response
    {
        public AttackPlayerResponse()
        {

        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}