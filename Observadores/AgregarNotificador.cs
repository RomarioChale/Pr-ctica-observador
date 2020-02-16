using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observadores
{
    public class AgregarNotificador : IObservador
    {
        public void ActualizaObservado()
        {
            Console.WriteLine("se subio codigo");
        }
    }
}
