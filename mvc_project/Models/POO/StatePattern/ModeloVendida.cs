namespace mvc_project.Models.POO.StatePattern
{
    public class ModeloVendida : ModeloEstadoPropiedad
    {
        public override bool EstaDisponible()
        {
            return false;
        }

        public override string GetEstado()
        {
            return "Vendida";
        }
        
        public override string GetColor()
        {
            return "red";
        }
    }
}