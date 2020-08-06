using System;
using System.Runtime.InteropServices;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Graphics.AccDataTypes
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct CarCoordinates
    {
        public float X;
        public float Y;
        public float Z;
    }
}
