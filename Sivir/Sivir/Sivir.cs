﻿using System;
using Aimtec;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Menu.Config;
using Aimtec.SDK.TargetSelector;
using System.Linq;

using Aimtec;
using Aimtec.SDK.Damage;
using Aimtec.SDK.Extensions;
using Aimtec.SDK.Menu;
using Aimtec.SDK.Menu.Components;
using Aimtec.SDK.Orbwalking;
using Aimtec.SDK.TargetSelector;
using Aimtec.SDK.Util.Cache;
using Aimtec.SDK.Prediction.Skillshots;
using Aimtec.SDK.Util;

namespace Sivir
{
    internal partial class Sivir
    {
        public Sivir()
        {
            InitMenus();
            InitSpells();
            InitMethods();
        }


        public static Obj_AI_Hero GetBestEnemyHeroTarget()
        {
            return GetBestEnemyHeroTargetInRange(float.MaxValue);
        }

        public static Obj_AI_Hero GetBestEnemyHeroTargetInRange(float range)
        {
            var ts = TargetSelector.Implementation;
            var target = ts.GetTarget(range);
            if (target != null && target.IsValidTarget())
            {
                return target;
            }

            var firstTarget = ts.GetOrderedTargets(range)
                .FirstOrDefault(t => t.IsValidTarget());
            if (firstTarget != null)
            {
                return firstTarget;
            }

            return null;
        }

        public void OnTick()
        {
            target = GetBestEnemyHeroTargetInRange(1500);

            if (GlobalKeys.ComboKey.Active)
            {
                Combo();
            }

            if (GlobalKeys.WaveClearKey.Active)
            {
                //lane clear logic
            }

            if (GlobalKeys.LastHitKey.Active)
            {
                //last hit logic
            }

            if (GlobalKeys.MixedKey.Active)
            {
                //harass logic
            }
        }

        //public void OnDraws()
        //{
        //    if (Player.IsDead)
        //    {
        //        return;
        //    }
        //    InitDrawings();
        //}
    }
}