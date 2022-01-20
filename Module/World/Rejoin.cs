﻿using Area51.SDK;

namespace Area51.Module.World
{
    class Rejoin : BaseModule
    {
        public Rejoin() : base("Rejoin", "Rejoin the World", Main.Instance.WorldButton, null) { }

        public override void OnEnable()
        {
            VRCFlowManager.prop_VRCFlowManager_0.Method_Public_Void_String_WorldTransitionInfo_Action_1_String_Boolean_0(RoomManager.field_Internal_Static_ApiWorld_0.id + ":" + RoomManager.field_Internal_Static_ApiWorldInstance_0.instanceId);
            Logg.LogDebug($"ReJoined {RoomManager.field_Private_Static_RoomManager_0.name} | World ID: {RoomManager.field_Internal_Static_ApiWorldInstance_0.id}");
        }
    }
}
