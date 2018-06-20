﻿using System;

namespace AmaruCommon.GameAssets.Cards.Properties.Abilities
{
    [Serializable]
    public class GainHPAbility : Ability
    {
        public int Hp { get; private set; }

        protected GainHPAbility(int cost, int hp) : base(cost)
        {
            this.Hp = hp;
        }

        public override int Visit(PropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
