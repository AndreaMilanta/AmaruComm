using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.CreatureEffects
{
    public class CostLessForPDEffect : CreatureEffect
    {

        protected CostLessForPDEffect()
        {
        
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}