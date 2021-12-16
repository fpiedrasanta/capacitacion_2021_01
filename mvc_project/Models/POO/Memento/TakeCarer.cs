using System;
using System.Collections.Generic;

namespace mvc_project.Models.POO
{
    public class TakeCarer
    {
        public PersonaModel PersonaModel { get; set; }

        public List<PersonaModel> HistorialPersona { get; set; }

        public void SaveToMemento(PersonaModel personaModel)
        {
            PersonaModel personaClonada = (PersonaModel) personaModel.Clone();

            this.HistorialPersona.Add(personaClonada);

            personaModel.PersonaAnterior = personaClonada;
        }
    }
}