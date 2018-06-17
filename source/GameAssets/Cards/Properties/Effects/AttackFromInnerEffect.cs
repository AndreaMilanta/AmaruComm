using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Effects
{
    public class AttackFromInnerEffect : Effect
    {
        public override void Visit(IPropertyVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
