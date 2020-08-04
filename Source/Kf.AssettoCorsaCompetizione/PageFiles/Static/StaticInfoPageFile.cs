using System;
using System.Collections.Generic;
using System.Text;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Static
{
    public sealed class StaticInfoPageFile : PageFile<StaticData>
    {
        public StaticInfoPageFile()
            : base("Local\\acpmf_static")
        { }
    }
}
