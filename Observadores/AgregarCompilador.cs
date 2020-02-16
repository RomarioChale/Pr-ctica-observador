using System;

namespace Observadores
{
    public class AgregarCompilador : IObservador
    {
        void IObservador.ActualizaObservado()
        {
            Console.WriteLine("se agrego  notificador");
        }
    }
}
