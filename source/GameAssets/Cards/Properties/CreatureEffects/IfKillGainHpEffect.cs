﻿using AmaruCommon.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.CreatureEffects
{
    public class IfKillGainHPEffect : CreatureEffect
    {

        public int HPToGain { get; private set; }

        protected IfKillGainHPEffect(int hpToGain = 3)
        {
            this.HPToGain = hpToGain;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}