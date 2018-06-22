using System;
using AmaruCommon.Actions.Targets;
using AmaruCommon.GameAssets.Cards.Properties;
using AmaruCommon.GameAssets.Cards.Properties.Attacks;

namespace AmaruCommon.GameAssets.Cards.Properties.Attacks
{
    [Serializable]
    public class DrawCardAndAttack : SimpleAttack
    {
        public Target CreatureOrPlayer { get; private set; }

        public DrawCardAndAttack(int cost, int power) : base(cost, power)
        {
            
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
