﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Aimtec;
using Aimtec.SDK.Extensions;

namespace Sivir
{
    internal partial class Sivir
    {
        public void CastQ(Obj_AI_Base unit)
        {
            if (!Q.Ready || Player.Mana < Player.SpellBook.GetSpell(SpellSlot.Q).Cost)
            {
                return;
            }

            if (Player.Distance(unit) < Q.Range)
            {
                Q.Cast(unit);
            }
        }

        public void CastW(Obj_AI_Base unit)
        {
            if (!W.Ready || Player.Mana < Player.SpellBook.GetSpell(SpellSlot.W).Cost)
            {
                return;
            }

            if (Player.Distance(unit) < W.Range)
            {
                W.Cast();
            }
        }

    }
}
