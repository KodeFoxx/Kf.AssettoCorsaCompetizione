using System;
using System.Collections.Generic;
using System.Text;

namespace Kf.AssettoCorsaCompetizione.PageFiles.Physics
{
    public sealed class PhysicsInfoPageFile : PageFile<PhysicsData>
    {
        public PhysicsInfoPageFile()
            : base("Local\\acpmf_physics")
        { }
    }
}
