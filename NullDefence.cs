using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    class NullDefence : ISpecialDefence
    {
        public int calculateDemageReduction(int TotalDamage)
        {
            return 0;  // no operation  / "do nothing" behaviour
        }
    }
}
