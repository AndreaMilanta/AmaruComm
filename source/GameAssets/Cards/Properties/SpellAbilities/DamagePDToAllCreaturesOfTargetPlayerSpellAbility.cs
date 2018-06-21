using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    public class DamagePDToAllCreaturesOfTargetPlayerSpellAbility : SpellAbility
    {
        public int numPd { get; private set; }
        protected DamagePDToAllCreaturesOfTargetPlayerSpellAbility(int numPd =1) : base(true, 1, Constants.KindOfTarget.PLAYER)
        {
            this.numPd = numPd;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
