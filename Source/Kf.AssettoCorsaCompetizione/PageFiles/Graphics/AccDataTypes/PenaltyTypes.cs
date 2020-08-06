namespace Kf.AssettoCorsaCompetizione.PageFiles.Graphics.AccDataTypes
{
    public enum PenaltyTypes
    {
        None = 0,
        DriveThrough_Cutting = 1,
        StopAndGo_10_Seconds_Cutting = 2,
        StopAndGo_20_Seconds_Cutting = 3,
        StopAndGo_30_Seconds_Cutting = 4,
        Disqualified_Cutting = 5,
        BestLapTimeRemoved_Cutting = 6,
        DriveThrought_SpeedingInPitLane = 7,
        StopAndGo_10_Seconds_SpeedingInPitLane = 8,
        StopAndGo_20_Seconds_SpeedingInPitLane = 9,
        StopAndGo_30_Seconds_SpeedingInPitLane = 10,
        Disqualified_SpeedingInPitLane = 11,
        BestLapTimeRemoved_SpeedingInPitLane = 12,
        Disqualified_IgnoringMandatoryPitStop = 13,
        PostRaceTimeAdded = 14,
        Disqualified_Trolling = 15,
        Disqualified_PitEntry = 16,
        Disqualified_PitExit = 17,
        Disqualified_GoingWrongWay = 18,
        DriveThrough_IgnoringDriverStint = 19,
        Disqualified_IgnoringDriverStint = 20,
        Disqualified_ExceedingDriverStintLimit = 21
    }
}
