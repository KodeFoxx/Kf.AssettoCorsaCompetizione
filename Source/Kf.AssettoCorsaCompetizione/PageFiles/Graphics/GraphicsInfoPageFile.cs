using System;
using System.Runtime.InteropServices;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Graphics
{
    public sealed class GraphicsInfoPageFile : PageFile<GraphicsData>
    {
        public GraphicsInfoPageFile()
            : base("Local\\acpmf_graphics")
        { }

        public int PacketId => Data.PacketId;
        public GameStates GameState => Data.GameState;
        public SessionTypes Session => Data.Session;
    }
}
