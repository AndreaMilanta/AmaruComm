using System;
using System.Collections.Generic;
using AmaruCommon.Actions.Targets;
using AmaruCommon.GameAssets.Cards;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Responses
{
    [Serializable]
    public class PlayASpellResponse : Response
    {
        public CharacterEnum Caller;
        public SpellCard Spell;
        public List<Target> Targets;

        public PlayASpellResponse(CharacterEnum caller, SpellCard spell, List<Target> targets)
        {
            this.Caller = caller;
            this.Spell = spell;
            this.Targets = targets;
        }

        public override void Visit(IResponseVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
