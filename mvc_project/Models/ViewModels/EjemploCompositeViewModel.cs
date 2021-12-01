using System.Collections.Generic;

namespace mvc_project.Models.ViewModels
{
    public class DatosProducto
    {
        public string Nombre;

        public long Id;

        public string Precio;

        public string Color;
    }

    public class EjemploCompositeViewModel
    {
        public List<DatosProducto> Productos;
    }
}