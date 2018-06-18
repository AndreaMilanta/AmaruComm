using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Effects
{
    public class AttackFromInnerEffect : Effect
    {
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
