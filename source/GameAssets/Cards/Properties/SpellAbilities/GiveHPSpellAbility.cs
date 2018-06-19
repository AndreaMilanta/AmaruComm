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
        protected GiveHPSpellAbility(int numHP = 4) : base(true)
        {
            this.numHP = numHP;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}