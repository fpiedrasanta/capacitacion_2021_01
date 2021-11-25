namespace mvc_project.Models.POO.StatePattern
{
    public class ModeloPropiedad
    {
        private ModeloEstadoPropiedad estadoPropiedad;
        
        public ModeloPropiedad(ModeloEstadoPropiedad modeloEstadoPropiedad)
        {
            this.estadoPropiedad = modeloEstadoPropiedad;
        }

        public bool EstaDisponible()
        {
            if(this.estadoPropiedad != null)
            {
                return this.estadoPropiedad.EstaDisponible();
            }

            return true;
        }

        public string ObtenerDescripcionEstado()
        {
            if(this.estadoPropiedad != null)
            {
                return this.estadoPropiedad.GetEstado();
            }

            return "Sin estado";
        }

        public string ObtenerColor()
        {
            if(this.estadoPropiedad != null)
            {
                return this.estadoPropiedad.GetColor();
            }

            return "black";
        }
    }
}