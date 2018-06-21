using System;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class AttackPlayerResponse : Response
    {
        public CharacterEnum Caller;
        public CharacterEnum Target;
        public CreatureCard Attacker;
        public int TargetHealthAfter;

        public AttackPlayerResponse(CharacterEnum caller, CharacterEnum target, CreatureCard attacker, int targetHealthAfter)
        {
            this.Caller = caller;
            this.Target = target;
            this.Attacker = attacker;
            this.TargetHealthAfter = targetHealthAfter;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}