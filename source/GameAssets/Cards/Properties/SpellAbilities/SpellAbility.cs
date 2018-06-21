using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    public abstract class SpellAbility : CardProperty
    {
        public KindOfTarget kindOfTarget { get; private set; }
        public bool Immediate { get; private set; }
        public int NumTarget { get; private set; }
        protected SpellAbility(bool immediate, int numTarget, KindOfTarget kindOfTarget)
        {
            this.kindOfTarget = kindOfTarget;
            this.Immediate = immediate;
            this.NumTarget = numTarget;
        }

        public abstract override int Visit(PropertyVisitor visitor);
    }
}
