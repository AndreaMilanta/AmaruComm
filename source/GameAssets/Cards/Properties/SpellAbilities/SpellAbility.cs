﻿using AmaruCommon.GameAssets.Cards.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmaruCommon.source.GameAssets.Cards.Properties.SpellAbilities
{
    [Serializable]
    public abstract class SpellAbility : CardProperty
    {
        public SpellAbility()
        {
        }

        public abstract override int Visit(IPropertyVisitor visitor);
    }
}