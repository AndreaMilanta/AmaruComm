using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    public class GainCpSpellAbility : SpellAbility
    {
        public int numCP { get; private set; }
        public GainCpSpellAbility (int numCP = 4) : base(true,1,Constants.KindOfTarget.PLAYER)
        {
            this.numCP = numCP;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}