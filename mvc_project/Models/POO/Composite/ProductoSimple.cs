namespace mvc_project.Models.POO.Composite
{
    public class ProductoSimple : Producto
    {
        public double Precio { get; set; }

        public override double ObtenerPrecio()
        {
            return this.Precio;
        }
    }
}