using System.Collections.Generic;

namespace mvc_project.Models.POO.Composite
{
    public class ProductoCompuesto : Producto
    {
        public List<Producto> Productos;

        public override double ObtenerPrecio()
        {
            double precio = 0;
            foreach(Producto producto in this.Productos)
            {
                precio += producto.ObtenerPrecio();
            }

            return precio + 400;
        }
    }
}