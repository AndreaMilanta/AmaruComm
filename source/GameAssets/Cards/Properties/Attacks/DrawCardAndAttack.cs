using System;
using AmaruCommon.Actions.Targets;
using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class DrawCardAndAttack : Attack
    {
        public Target CreatureOrPlayer { get; private set; }

        public DrawCardAndAttack(int cost,Target kindOfTarget) : base(cost)
        {
            this.CreatureOrPlayer = kindOfTarget;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
