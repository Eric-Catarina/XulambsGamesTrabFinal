using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    internal interface IUsable
    {
        void use(PC player);
        
        bool canBeUsedUsed(PC  who);
    }
}