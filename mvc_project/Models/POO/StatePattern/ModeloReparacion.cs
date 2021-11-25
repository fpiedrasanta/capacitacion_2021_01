namespace mvc_project.Models.POO.StatePattern
{
    public class ModeloReparacion : ModeloEstadoPropiedad
    {
        public override bool EstaDisponible()
        {
            return false;
        }

        public override string GetColor()
        {
            return "gray";
        }

        public override string GetEstado()
        {
            return "En reparación";
        }
    }
}