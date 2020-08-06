using Kf.AssettoCorsaCompetizione.PageFiles.Graphics.AccDataTypes;

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
        public FlagTypes Flag
            => GameState == GameStates.Off || GameState == GameStates.Replay
                ? FlagTypes.None
                : Data.Flag;
        public int Position => Data.Position;
        public int Sector
            => GameState == GameStates.Off || GameState == GameStates.Replay
                ? 0
                : Data.CurrentSector + 1;
        public int TotalCars => Data.ActiveCars;
        public CarCoordinates[] CarCoordinates => Data.CarCoordinates;
        public string TyreCompound => Data.TyreCompound;
    }
}
