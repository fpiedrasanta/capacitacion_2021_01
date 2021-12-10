namespace mvc_project.Models.POO.TemplateMethod
{
    public class PagoCheque : Pago
    {
        protected override string ValidarDepositoDinero(out bool hayPlataDepositada)
        {
            hayPlataDepositada = true;

            return "Le pregunté al banco si el cheque tiene fondos, y si.";
        }
    }
}