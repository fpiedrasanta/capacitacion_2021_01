using System.Collections.Generic;

namespace mvc_project.Models.ViewModels
{
    public class FichaPersonalViewModel
    {
        public mvc_project.Models.POO.PersonaModel Persona { get; set; }

        public string ObtenerNombre()
        {
            return this.Persona != null ? this.Persona.Nombre : "";
        }

        public string ObtenerApellido()
        {
            return this.Persona != null ? this.Persona.Apellido : "";
        }

        public string ObtenerAltura()
        {
            return this.Persona != null ? this.Persona.Altura.ToString("#0.00") : "";
        }

        public string ObtenerTipoDocumento()
        {
            return this.Persona != null ? this.Persona.TipoDocumento : "";
        }

        public string ObtenerNumeroDocumento()
        {
            return this.Persona != null ? this.Persona.NumeroDocumento.ToString() : "";
        }

        public string ObtenerDomicilioLaboral2()
        {
            return this.Persona != null ? this.Persona.ObtenerDomicilioLaboral2() : "";
        }

        public string ObtenerIngresoMensual2()
        {
            return this.Persona != null ? this.Persona.ObtenerIngresoMensual2().ToString("#0.00") : "";
        }

        public string ObtenerValorHora2()
        {
            return this.Persona != null ? this.Persona.ObtenerValorHora2().ToString("#0.00") : "";
        }

        public string ObtenerDomicilioLaboral()
        {
            return this.Persona != null ? this.Persona.ObtenerDomicilioLaboral() : "";
        }

        public string ObtenerIngresoMensual()
        {
            return this.Persona != null ? this.Persona.ObtenerIngresoMensual().ToString("#0.00") : "";
        }

        public string ObtenerValorHora()
        {
            return this.Persona != null ? this.Persona.ObtenerValorHora().ToString("#0.00") : "";
        }
    }
}