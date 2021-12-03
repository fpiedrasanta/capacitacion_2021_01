using System;

namespace mvc_project.Models.POO.FacadePattern
{
    public class ModeloFacadeHouse
    {
        public ModeloBanio ModeloBanio { get; set; }
        public ModeloCocina ModeloCocina { get; set; }
        public ModeloHabitacion ModeloHabitacion { get; set; }
        public ModeloPatio ModeloPatio { get; set; }

        public long ObtenerTotalMetrosCuadrados()
        {
            long metrosCuadrados = 0;

            metrosCuadrados += this.ModeloBanio.MetrosCuadrados;
            metrosCuadrados += this.ModeloCocina.CentimetrosCuadrados / (long) Math.Pow(100, 2);
            metrosCuadrados += this.ModeloHabitacion.MetrosCuadrados;
            metrosCuadrados += this.ModeloPatio.MetrosCuadrados;

            return metrosCuadrados;
        }

        public long ObtenerTotalVentanas()
        {
            long cantidadVentanas = 0;

            cantidadVentanas += this.ModeloBanio.CantidadVentanas;
            cantidadVentanas += this.ModeloCocina.CantidadVentanas;
            cantidadVentanas += this.ModeloHabitacion.CantidadVentanas;
            cantidadVentanas += this.ModeloPatio.CantidadVentanas;

            return cantidadVentanas;
        }
    }
}