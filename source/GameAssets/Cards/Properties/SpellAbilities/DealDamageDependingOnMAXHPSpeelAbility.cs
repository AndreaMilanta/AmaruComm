﻿using System;
using System.Collections.Generic;
using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AmaruCommon.GameAssets.Cards.Properties.SpellAbilities
{

    [Serializable]
    public class DealDamageDependingOnMAXHPSpeelAbility : SpellAbility
    {
        protected DealDamageDependingOnMAXHPSpeelAbility()
        {
        }
        public override int Visit(IPropertyVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}