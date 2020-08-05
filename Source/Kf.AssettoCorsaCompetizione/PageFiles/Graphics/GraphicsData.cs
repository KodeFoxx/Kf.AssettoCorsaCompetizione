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
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string LasdtTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string BestTime;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string Split;
        public int CompletedLaps;
        public int Position;
        public int CurrentTimeMilliSeconds;
        public int LastTimeMilliSeconds;
        public int BestTimeMilliSeconds;
        public float TimeLeft;
        public float DistanceTravelled;
        public int IsInPit;
        public int CurrentSector;
        public int LastSectorTimeMilliSeconds;
        public int NumberOfCompletedLaps;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public string TyreCompound;
        [Obsolete]
        public float ReplayTimeMultiplier;
        public float NormalizedCarPosition;
        public int ActiveCars;
        //[MarshalAs(UnmanagedType.ByValArray, SizeConst = 60 * 3)]
        //public float[,] CarCoordinates;
        public CarCoordinates CarCoordinates;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] CarIds;
        public int CarId;
        public float PenaltyTime;
        public FlagTypes Flag;
    }
}
