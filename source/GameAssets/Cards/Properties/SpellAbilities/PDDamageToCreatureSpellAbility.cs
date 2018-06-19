﻿using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    public class PDDamageToCreatureSpellAbility : SpellAbility
    {
        public int PDDamage { get; private set; }
        protected PDDamageToCreatureSpellAbility(int PDDamage = 3)
        {
            this.PDDamage = PDDamage;
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}