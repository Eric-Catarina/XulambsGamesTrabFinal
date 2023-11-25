using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    public interface IObservador
    {
       void Avisar(IInimigoObservado personagem);
    }
}