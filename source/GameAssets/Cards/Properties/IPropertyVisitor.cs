using System;

using AmaruCommon.GameAssets.Cards.Properties.Attacks;
using AmaruCommon.GameAssets.Cards.Properties.Effects;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    public interface IPropertyVisitor
    {
        int Visit(SimpleAttack attack);
        int Visit(AttackFromInnerEffect effect);
        int Visit(ImperiaAttack attack);
    }
}
