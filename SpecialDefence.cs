using System;
using System.Collections.Generic;
using System.Text;

namespace GameConsole
{
    public abstract class SpecialDefence
    {
        public abstract int calculateDemageReduction(int TotalDamage);

        public static SpecialDefence Null { get; } = new NullDefence();
        private class NullDefence : SpecialDefence
        {
            public override int calculateDemageReduction(int TotalDamage)
            {
                return 0;  // no operation  / "do nothing" behaviour
            }
        }
    }
}
