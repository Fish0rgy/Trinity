﻿using Area51.SDK;
using System;

namespace Area51.Module.World.World_Hacks.Among_Us
{
    class A_BystandersWin : BaseModule
    {
        public A_BystandersWin() : base("Bystanders Win", "", Main.Instance.Amongusbutton, null, false)
        {
        }
        public override void OnEnable()
        {
            try
            {
                Logg.Log(Logg.Colors.Green, "Game Ended And Set Bystanders As The Winners", false, false);
                A_Misc.AmongUsMod("SyncVictoryB");
            }
            catch (Exception ex)
            {
                Logg.Log(Logg.Colors.Red, ex.ToString(), false, false);
            }
        }
    }
}
