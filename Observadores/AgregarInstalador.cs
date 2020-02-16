using System;

namespace Observadores
{
    public class AgregarInstalador : IObservador
    {
        public void ActualizaObservado()
        {
            Console.WriteLine("se agrego  ejecutor de pruebas");
        }
    }
}
