using System;

namespace AmaruCommon.GameAssets.Cards.Properties
{
    [Serializable]
    public abstract class CardProperty
    {
        public abstract void Visit(IPropertyVisitor visitor);
    }
}
