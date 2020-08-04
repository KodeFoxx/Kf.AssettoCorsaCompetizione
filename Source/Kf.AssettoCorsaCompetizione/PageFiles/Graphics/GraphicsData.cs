using System;
using System.Runtime.InteropServices;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Graphics
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct GraphicsData
    {
        public int PacketId;
        public GameStates GameState;
        public SessionTypes Session;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string CurrentTime;
    }
}
