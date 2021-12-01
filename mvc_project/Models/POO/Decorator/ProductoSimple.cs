namespace mvc_project.Models.POO.Decorator
{
    public class ProductoSimple : Producto
    {
        public double Precio { get; set; }

        public override double ObtenerPrecio()
        {
            return this.Precio;
        }

        public override string ObtenerColor()
        {
            return "gray";
        }
    }
}