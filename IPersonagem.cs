using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabFinalLoud
{
    public interface IInimigoObservado
    {
        void RegistrarObservador(IObservador observador);
        void NotificarPersonagens();

    }
}