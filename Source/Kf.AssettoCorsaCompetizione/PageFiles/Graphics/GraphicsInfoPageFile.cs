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
        public FlagTypes Flag => Data.Flag;
        public int Position => Data.Position;
        public int Sector
            => GameState != GameStates.Off && GameState != GameStates.Replay
                ? Data.CurrentSector + 1
                : 0;
        public int TotalCars => Data.ActiveCars;
        public string TyreCompound => Data.TyreCompound;
    }
}
