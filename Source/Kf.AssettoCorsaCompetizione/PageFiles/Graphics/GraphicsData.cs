using Kf.AssettoCorsaCompetizione.PageFiles.Graphics.AccDataTypes;
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
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public CarCoordinates[] CarCoordinates;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public int[] CarIds;
        public int CarId;
        public float PenaltyTime;
        public FlagTypes Flag;
        public PenaltyTypes Penalty;
        public int IdealLineOn;
        public int IsInPitLane;
        public float SurfaceGrip;
        public int MandatoryPitDone;
        public float WindSpeed;
        public float WindDirection;
        public int IsSetupMenuVisible;
        public int MainDisplayIndex;
        public int SecondaryDisplayIndex;
        public int TC;
        public int TCUT;
        public int EngineMap;
        public int ABS;
        public float FuelXLap;
        public int RainLights;
        public int FlashingLights;
        public int LightsStage;
        public float ExhaustTemperature;
        public int WiperLV;
        public int DriverStingTotalTimeLeft;
        public int DriverStingTimeLeft;
        public int RainTyres;
        public int SessionIndex;
        public float UsedFuel; //Since last refuel
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String DeltaLapTime;
        public int DeltaLapTimeInMilliSeconds;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public String EstimatedLapTime;
        public int EstimatedLapTimeInMilliSeconds;
        public int IsDeltaPositive;
        public int ISplit; //Last split time in ms
        public int IsValidLap;
        public float FuelEstimatedLaps;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 33)]
        public String TrackStatus;
        public int MissingMandatoryPits;
        public float Clock; //Time of the day in seconds
        public int DirectionLightsLeft;
        public int DirectionLightsRight;
    }
}
