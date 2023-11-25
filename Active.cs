using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal abstract class Active : Item, IUsable
    {
        public bool canBeUsedUsed(PC who)
        {
            throw new NotImplementedException();
        }

        public void use(PC player)
        {
            throw new NotImplementedException();
        }
    }
}