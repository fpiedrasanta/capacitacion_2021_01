using System.Collections.Generic;

namespace mvc_project.Models.ViewModels
{
    public class MementoViewModel
    {
        public mvc_project.Models.POO.PersonaModel Persona { get; set; }

        public List<mvc_project.Models.POO.PersonaModel> HistorialPersona { get; set; }
    }
}