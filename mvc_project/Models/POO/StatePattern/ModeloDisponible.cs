namespace mvc_project.Models.POO.StatePattern
{
    public class ModeloDisponible : ModeloEstadoPropiedad
    {
        public override bool EstaDisponible()
        {
            return true;
        }

        public override string GetEstado()
        {
            return "Disponible";
        }

        public override string GetColor()
        {
            return "green";
        }
    }
}