namespace mvc_project.Models.POO.TemplateMethod
{
    public class PagoTarjeta : Pago
    {
        protected override string ValidarDepositoDinero(out bool hayPlataDepositada)
        {
            hayPlataDepositada = true;

            return "Validé contra mi operadora de tarjeta de crédito y está ok";
        }
    }
}