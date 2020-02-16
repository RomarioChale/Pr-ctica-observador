using System.Collections.Generic;

namespace Observadores
{
    public class Devops
    {
        private readonly List<IObservador> _observadores = new List<IObservador>(); 
        public void AgregarObservador(IObservador observador)
        {
            _observadores.Add(observador);
            NotificarObservadores();
        }

        public void EliminarObservador(IObservador observador)
        {
            _observadores.Remove(observador);

        }
        public void NotificarObservadores()
        {
            foreach (IObservador obj in _observadores)
            {
                obj.ActualizaObservado();
            }
        }
       
    }
}
