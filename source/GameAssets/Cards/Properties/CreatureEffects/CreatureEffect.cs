using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.CreatureEffects
{
    public abstract class CreatureEffect : CardProperty
    {
        protected CreatureEffect()
        {

        }
        public abstract override int Visit(IPropertyVisitor visitor);
    }
}
