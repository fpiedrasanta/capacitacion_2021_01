namespace mvc_project.Models.POO.StatePattern
{
    public class ModeloAlquilada : ModeloEstadoPropiedad
    {
        public override bool EstaDisponible()
        {
            return false;
        }

        public override string GetColor()
        {
            return "orange";
        }

        public override string GetEstado()
        {
            return "Alquilada";
        }
    }
}