﻿using GameServerCore.Packets.Enums;
using GameServerCore.Packets.Handlers;

namespace LeagueSandbox.GameServer.Packets.PacketHandlers
{
    public class HandleLockCamera : PacketHandlerBase
    {
        public override PacketCmd PacketType => PacketCmd.PKT_C2S_LOCK_CAMERA;
        public override Channel PacketChannel => Channel.CHL_C2S;

        public HandleLockCamera(Game game) { }

        public override bool HandlePacket(int userId, byte[] data)
        {
            return true;
        }
    }
}
