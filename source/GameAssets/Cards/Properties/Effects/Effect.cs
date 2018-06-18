using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Effects
{
    [Serializable]
    public abstract class Effect : CardProperty
    {
        public abstract override int Visit(IPropertyVisitor visitor);
    }
}
