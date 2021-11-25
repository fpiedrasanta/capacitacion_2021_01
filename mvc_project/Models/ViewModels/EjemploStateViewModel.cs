using System.Collections.Generic;

namespace mvc_project.Models.ViewModels
{
    public class DatoPropiedad
    {
        public string EstaDisponible;

        public string DescripcionEstado;

        public string Color;
    }

    public class EjemploStateViewModel
    {
        public List<DatoPropiedad> DatosPropiedad = new List<DatoPropiedad>();
    }
}