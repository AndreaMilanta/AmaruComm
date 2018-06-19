﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class GainCPAbility : Ability
    {
        public int cp { get; private set; }

        protected GainCPAbility(int cost,int cp) : base (cost)
        {
            this.cp = cp;
        }

        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}