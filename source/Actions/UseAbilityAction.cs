using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.Actions.Targets;
using AmaruCommon.GameAssets.Characters;

namespace AmaruCommon.Actions
{
    [Serializable]
    public class UseAbilityAction : PlayerAction
    {
        public List<Target> Targets { get; private set; } = null;
        public UseAbilityAction(CharacterEnum caller, int playedCardId, List<Target> targets) : base(caller, playedCardId)
        {
            this.Targets = targets;
        }

        public UseAbilityAction(CharacterEnum caller, int playedCardId, Target target) : base(caller, playedCardId)
        {
            this.Targets = new List<Target>() { target };
        }

        public UseAbilityAction(CharacterEnum caller, int playedCardId) : base(caller, playedCardId){ }

        public override void Visit(ActionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
