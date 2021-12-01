using System.Collections.Generic;

namespace mvc_project.Models.POO.Decorator
{
    public abstract class DecoratorProducto : Producto
    {
        public List<Producto> Productos;

        public abstract override double ObtenerPrecio();

        public abstract override string ObtenerColor();
    }

    public class ProductoElaborado : DecoratorProducto
    {
        public override double ObtenerPrecio()
        {
            double precio = 0;
            foreach(Producto producto in this.Productos)
            {
                precio += producto.ObtenerPrecio();
            }

            return precio;
        }

        public override string ObtenerColor()
        {
            return "red";
        }
    }

    public class ComboProducto : DecoratorProducto
    {
        public override double ObtenerPrecio()
        {
            double precio = 0;
            foreach(Producto producto in this.Productos)
            {
                precio += producto.ObtenerPrecio();
            }

            return precio * 0.9;
        }

        public override string ObtenerColor()
        {
            return "green";
        }
    }
}