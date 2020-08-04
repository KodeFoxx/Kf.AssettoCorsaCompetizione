using System;
using System.Runtime.InteropServices;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Physics
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct PhysicsData
    {
        public int PacketId;        
    }
}
