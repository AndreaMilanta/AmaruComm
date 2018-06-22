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
        //unica abilità con dei target, siamo sicuri? 
        //Altrimenti qui gestiamo il numero di target e altrove le carte...
        public LimitedList<CreatureCard> myTargets { get; private set; }
        public int myDivisor { get; private set; }

        public BonusAttackDependingOnHealthAbility(int cost, int numTarget, int myDivisor) : base(cost, numTarget)
        {
            this.myDivisor = myDivisor;
            this.myTargets = new LimitedList<CreatureCard>(numTarget);
        }

        //aggiungi un singolo elemento per volta
        public void AddToMyTarget (CreatureCard newTarget)
        {
            myTargets.Add(newTarget);
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
