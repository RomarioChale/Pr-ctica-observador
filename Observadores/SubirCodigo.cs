using System;

namespace Observadores
{
    public class SubirCodigo : IObservador
    {
        public void ActualizaObservado()
        {
            Console.WriteLine("Commit de código de la versión 1.1");
        }
    }
}
