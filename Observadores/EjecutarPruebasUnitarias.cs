using System;

namespace Observadores
{
    public class EjecutarPruebasUnitarias : IObservador
    {
        public void ActualizaObservado()
        {
            Console.WriteLine("se agrego  compilador");
        }
    }
}
