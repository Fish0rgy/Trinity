﻿using Area51.SDK;
using System;

namespace Area51.Module.World.World_Hacks.Among_Us
{
    class A_MurderWin : BaseModule
    {
        public A_MurderWin() : base("Murder Win", "", Main.Instance.Amongusbutton, null, false)
        {
        }
        public override void OnEnable()
        {
            try
            {
                Logg.Log(Logg.Colors.Green, "Game Ended And Set The Murder As The Winner", false, false);
                A_Misc.AmongUsMod("SyncVictoryM");
            }
            catch (Exception ex)
            {
                Logg.Log(Logg.Colors.Red, ex.ToString(), false, false);
            }
        }
    }
}
