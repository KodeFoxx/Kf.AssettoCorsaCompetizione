using System;
using System.Runtime.InteropServices;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Graphics
{
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct CarCoordinates
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public float[] One;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public float[] Two;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
        public float[] Three;
    }
}
