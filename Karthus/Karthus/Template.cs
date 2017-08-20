﻿using Aimtec.SDK.Orbwalking;

namespace Karthus
{
    internal partial class Karthus
    {
        public Karthus()
        {
            InitMethods();
            InitSpells();
            InitMenus();
        }

        private void Game_OnUpdate()
        {
            if (Player.IsDead)
            {
                return;
            }

            switch (Orbwalker.Implementation.Mode)
            {
                case OrbwalkingMode.Combo:
                    Combo();
                    break;
                case OrbwalkingMode.Mixed:
                    Harass();
                    break;
                /*case OrbwalkingMode.Lasthit:
                    LastHit();
                    break;*/
                case OrbwalkingMode.Laneclear:
                    LaneClear();
                    break;
            }
        }

        private void OnDrawings()
        {
            if (Player.IsDead)
            {
                return;
            }
            InitDrawings();
        }
    }
}