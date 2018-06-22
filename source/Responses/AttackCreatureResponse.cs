using System;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class AttackCreatureResponse : Response
    {
        public CharacterEnum Caller;
        public CharacterEnum Target;
        public CreatureCard Attacker;
        public CreatureCard AttackedCreature;

        public AttackCreatureResponse(CharacterEnum caller, CharacterEnum target, CreatureCard attacker, CreatureCard attackedCreature)
        {
            this.Caller = caller;
            this.Target = target;
            this.Attacker = attacker;
            this.AttackedCreature = attackedCreature;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}