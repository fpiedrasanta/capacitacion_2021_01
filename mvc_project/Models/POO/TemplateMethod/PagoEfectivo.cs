namespace mvc_project.Models.POO.TemplateMethod
{
    public class PagoEfectivo : Pago
    {
        protected override string ValidarDepositoDinero(out bool hayPlataDepositada)
        {
            hayPlataDepositada = false;
            return "Me fijé en el caja registradora (clin!), y no hay ingreso de plata";
        }
    }
}