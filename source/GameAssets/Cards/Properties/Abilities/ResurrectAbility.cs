﻿using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class ResurrectAbility : Ability
    {
        public Place myZone { get; private set; }
        protected ResurrectAbility(int cost, Place myZone) : base(cost)
        {
            this.myZone = myZone;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
