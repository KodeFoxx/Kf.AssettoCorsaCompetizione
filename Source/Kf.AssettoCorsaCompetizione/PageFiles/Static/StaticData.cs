using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Static
{    
    [StructLayout(LayoutKind.Sequential, Pack = 4, CharSet = CharSet.Unicode)]
    [Serializable]
    public struct StaticData
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string SMVersion;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        public string ACVersion;
    }
}
