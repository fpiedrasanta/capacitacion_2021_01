using System;

namespace mvc_project.Models.POO
{
    public abstract class OcupacionModel
    {
        public virtual string DomicilioLaboral { get; set; }
        
        public abstract double ObtenerIngresoMensual();

        public abstract double ObtenerValorHora();
    }

    public class FreelanceModel : OcupacionModel
    {
        public double ValorHora { get; set; }
        
        public override double ObtenerIngresoMensual()
        {
            return this.ValorHora * 160;
        }

        public override double ObtenerValorHora()
        {
            return this.ValorHora;
        }
    }

    public class RelacionDependenciaModel : OcupacionModel
    {
        public double Sueldo { get; set; }
        
        public override double ObtenerIngresoMensual()
        {
            return this.Sueldo;
        }

        public override double ObtenerValorHora()
        {
            return this.Sueldo / 160;
        }
    }
}