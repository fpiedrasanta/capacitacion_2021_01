namespace mvc_project.Models.POO.Decorator
{
    public abstract class Producto
    {
        public string Nombre { get; set; }

        public long Id { get; set; }

        public abstract double ObtenerPrecio();

        public abstract string ObtenerColor();
    }
}