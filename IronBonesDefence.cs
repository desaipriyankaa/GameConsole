using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public class IronBonesDefence : SpecialDefence
    {
        public override int calculateDemageReduction(int TotalDamage)
        {
            return 5;
        }
    }
}
