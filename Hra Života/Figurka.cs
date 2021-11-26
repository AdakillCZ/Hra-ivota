using System;
using System.Collections.Generic;
using System.Text;

namespace Hra_Života
{
    public abstract class Figurka
    {
        public int typTahu;

        public abstract void ProvestTah();

        public override string ToString()
        {
            return this.typTahu + "";
        }
    }
}
