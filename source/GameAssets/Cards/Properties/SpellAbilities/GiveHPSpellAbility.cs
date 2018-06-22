using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    public class GiveHPSpellAbility : SpellAbility
    {
        public int numHP { get; private set; }
        public GiveHPSpellAbility(int numHP = 4) : base(true,1,Constants.KindOfTarget.MIXED)
        {
            this.numHP = numHP;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}