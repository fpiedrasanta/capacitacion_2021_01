using System.Collections.Generic;

namespace mvc_project.Models.POO.Observer
{
    public abstract class Sujeto
    {
        protected List<Observador> observadores = new List<Observador>();

        public abstract void CometiFalta();
        
        public void NotificarFalta()
        {
            foreach(Observador observador in this.observadores)
            {
                observador.CometioFalta();
            }
        }

        public void AgregarObservador(Observador observador)
        {
            this.observadores.Add(observador);
        }
    }
}