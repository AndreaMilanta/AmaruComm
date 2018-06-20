﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmaruCommon.GameAssets.Cards.Properties;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    public class DealTotDamageToTotTargetsSpellAbility : SpellAbility
    {
        public int numTarget { get; private set; }
        public int DamageToDeal { get; private set; }

        protected DealTotDamageToTotTargetsSpellAbility(int numTarget = 3, int damageToDeal = 3) : base(true)
        {
            this.numTarget = numTarget;
            this.DamageToDeal = damageToDeal;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}