using AmaruCommon.Constants;
using AmaruCommon.GameAssets.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class BonusAttackDependingOnHealthAbility : Ability
    {
        public LimitedList<CreatureCard> myTargets { get; private set; }
        public int myDivisor { get; private set; }
        protected BonusAttackDependingOnHealthAbility(int cost, int myDivisor, int myTargetsNumber) : base(cost)
        {
            this.myDivisor = myDivisor;
            this.myTargets = new LimitedList<CreatureCard>(myTargetsNumber);
        }

        //aggiungi un singolo elemento per volta
        public void AddToMyTarget (CreatureCard newTarget)
        {
            myTargets.Add(newTarget);
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
