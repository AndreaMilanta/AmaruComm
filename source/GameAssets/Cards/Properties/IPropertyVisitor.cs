using System;

using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    public interface IPropertyVisitor
    {
        void Visit(SimpleAttack attack);
        void Visit(AttackFromInnerEffect effect);
    }
}
