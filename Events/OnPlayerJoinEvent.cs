﻿namespace Area51.Events
{
    public interface OnPlayerJoinEvent
    {
        void OnPlayerJoin(VRC.Player player);
        void OnPlayerEnteredRoom(Photon.Realtime.Player player);
    }
}
