using System;

namespace mvc_project.Models.POO
{
    public class Ocupacion2Model
    {
        private IMetodoTrabajo metodoTrabajo;

        public virtual string DomicilioLaboral { get; set; }
        
        public double ObtenerIngresoMensual()
        {
            return this.metodoTrabajo != null ? this.metodoTrabajo.ObtenerIngresoMensual() : 0;
        }

        public double ObtenerValorHora()
        {
            return this.metodoTrabajo != null ? this.metodoTrabajo.ObtenerValorHora() : 0;
        }

        public Ocupacion2Model()
        {
            this.metodoTrabajo = null;
            this.DomicilioLaboral = "";
        }

        public Ocupacion2Model(IMetodoTrabajo metodoTrabajo, string domicilioLaboral)
        {
            this.metodoTrabajo = metodoTrabajo;
            this.DomicilioLaboral = domicilioLaboral;
        }
    }

    public interface IMetodoTrabajo
    {
        double ObtenerIngresoMensual();

        double ObtenerValorHora();
    }

    public class Freelance2Model : IMetodoTrabajo
    {
        public double ValorHora { get; set; }

        public double ObtenerIngresoMensual()
        {
            return this.ValorHora * 160;
        }

        public double ObtenerValorHora()
        {
            return this.ValorHora;
        }
    }

    public class RelacionDependencia2Model : IMetodoTrabajo
    {
        public double Sueldo { get; set; }
        
        public double ObtenerIngresoMensual()
        {
            return this.Sueldo;
        }

        public double ObtenerValorHora()
        {
            return this.Sueldo / 160;
        }
    }
}