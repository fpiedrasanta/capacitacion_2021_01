namespace mvc_project.Models.POO.StatePattern
{
    public abstract class ModeloEstadoPropiedad
    {
        public virtual long Id { get; set; }

        public virtual long CodigoSistema { get; set; }

        public virtual string Descripcion { get; set; }

        public abstract bool EstaDisponible();

        public abstract string GetEstado();

        public abstract string GetColor();
    }
}