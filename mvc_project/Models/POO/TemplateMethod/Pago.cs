using System.Collections.Generic;

namespace mvc_project.Models.POO.TemplateMethod
{
    public abstract class Pago
    {
        public List<string> Cobrar()
        {
            List<string> resultado = new List<string>();
            
            bool hayPlataDepositada = false;
            resultado.Add(ValidarDepositoDinero(out hayPlataDepositada));
            if(hayPlataDepositada)
            {
                resultado.Add(GenerarFactura());
                resultado.Add(DescontarStock());
            }
            else
            {
                resultado.Add(CancelarCompra());
            }

            return resultado;
        }

        private string GenerarFactura()
        {
            return "Genero la factura electrónica por la compra";
        }

        private string DescontarStock()
        {
            return "Descuento el stock de productos";
        }

        private string CancelarCompra()
        {
            return "Se canceló la compra";
        }

        protected abstract string ValidarDepositoDinero(out bool hayPlataDepositada);
    }
}