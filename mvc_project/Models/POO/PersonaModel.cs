using System;

namespace mvc_project.Models.POO
{
    public class PersonaModel
    {
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string TipoDocumento { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public Int64 NumeroDocumento { get; set; }
        
        public float Altura { get; set; }
        
        public OcupacionModel Ocupacion { get; set; }

        public Ocupacion2Model Ocupacion2 { get; set; }

        public string ObtenerNombreCompleto()
        {
            return this.Nombre + " " + this.Apellido;
        }

        public int ObtenerEdad()
        {
            return (int)(DateTime.Today - FechaNacimiento).TotalDays/365;
        }

        public string ObtenerDomicilioLaboral2()
        {
            return this.Ocupacion2 != null ? this.Ocupacion2.DomicilioLaboral : "";
        }

        public double ObtenerIngresoMensual2()
        {
            return this.Ocupacion2 != null ? this.Ocupacion2.ObtenerIngresoMensual() : 0;
        }

        public double ObtenerValorHora2()
        {
            return this.Ocupacion2 != null ? this.Ocupacion2.ObtenerValorHora() : 0;
        }

        public string ObtenerDomicilioLaboral()
        {
            return this.Ocupacion != null ? this.Ocupacion.DomicilioLaboral : "";
        }

        public double ObtenerIngresoMensual()
        {
            return this.Ocupacion != null ? this.Ocupacion.ObtenerIngresoMensual() : 0;
        }

        public double ObtenerValorHora()
        {
            return this.Ocupacion != null ? this.Ocupacion.ObtenerValorHora() : 0;
        }
    }
}