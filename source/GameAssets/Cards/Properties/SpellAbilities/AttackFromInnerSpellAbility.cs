﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{
    public class AttackFromInnerSpellAbility : SpellAbility
    {
        public int BonusAttack { get; private set; }

        protected AttackFromInnerSpellAbility(int bonusAttack) : base(false)
        {
            this.BonusAttack = bonusAttack;
        }
        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}