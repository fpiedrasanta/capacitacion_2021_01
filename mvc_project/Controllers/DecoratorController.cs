using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_project.Models;
using mvc_project.Models.POO;
using mvc_project.Models.POO.Decorator;
using mvc_project.Models.POO.StatePattern;
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class DecoratorController : Controller
    {
        private readonly ILogger<DecoratorController> _logger;

        public DecoratorController(ILogger<DecoratorController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploDecorator()
        {
            //TODO: Fede - Obtener de la base de datos.
            List<Producto> productos = this.ObtenerProductos();

            EjemploDecoratorViewModel ejemploDecoratorViewModel = new EjemploDecoratorViewModel
            {
                Productos = new List<DatosProducto>()
            };

            foreach(Producto producto in productos)
            {
                ejemploDecoratorViewModel.Productos.Add(new DatosProducto
                {
                    Id = producto.Id,
                    Nombre = producto.Nombre,
                    Precio = producto.ObtenerPrecio().ToString("#0.00"),
                    Color = producto.ObtenerColor()
                });
            }
            
            return View(ejemploDecoratorViewModel);
        }

        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            ProductoSimple ps1 = new ProductoSimple
            {
                Nombre = "Monitor",
                Id = 1,
                Precio = 17000
            };

            productos.Add(ps1);

            ProductoSimple ps2 = new ProductoSimple
            {
                Nombre = "Memoria RAM 4GB",
                Id = 2,
                Precio = 2500
            };

            productos.Add(ps2);

            ProductoSimple ps3 = new ProductoSimple
            {
                Nombre = "Microprocesador INTEL i5 - Tercera Gen.",
                Id = 3,
                Precio = 15000
            };

            productos.Add(ps3);


            ProductoSimple ps4 = new ProductoSimple
            {
                Nombre = "Teclado mecánico",
                Id = 4,
                Precio = 2400
            };

            productos.Add(ps4);
            
            ProductoSimple ps5 = new ProductoSimple
            {
                Nombre = "Mouse Logitech",
                Id = 5,
                Precio = 2800
            };

            productos.Add(ps5);

            ProductoElaborado productoCompuesto6 = new ProductoElaborado()
            {
                Id = 6,
                Nombre = "Placa Madre micro intel - 4 GB ram",
                Productos = new List<Producto>()
            };

            productoCompuesto6.Productos.Add(ps2);
            productoCompuesto6.Productos.Add(ps3);

            productos.Add(productoCompuesto6);

            ProductoElaborado productoCompuesto7 = new ProductoElaborado()
            {
                Id = 7,
                Nombre = "Tower Intel + 4 GB + Teclado Mec + Mouse Logitech",
                Productos = new List<Producto>()
            };

            productoCompuesto7.Productos.Add(productoCompuesto6);
            productoCompuesto7.Productos.Add(ps4);
            productoCompuesto7.Productos.Add(ps5);

            productos.Add(productoCompuesto7);

            ProductoElaborado productoCompuesto8 = new ProductoElaborado()
            {
                Id = 8,
                Nombre = "Compu",
                Productos = new List<Producto>()
            };

            productoCompuesto8.Productos.Add(productoCompuesto7);
            productoCompuesto8.Productos.Add(ps1);

            productos.Add(productoCompuesto8);

            ProductoSimple ps6 = new ProductoSimple
            {
                Nombre = "Equipo sonido",
                Id = 9,
                Precio = 1300
            };

            productos.Add(ps6);

            ComboProducto comboProducto = new ComboProducto()
            {
                Id = 10,
                Nombre = "Computadora + Equipo de sonido",
                Productos = new List<Producto>()
            };

            comboProducto.Productos.Add(productoCompuesto8);
            comboProducto.Productos.Add(ps6);

            productos.Add(comboProducto);

            return productos;
        }
    }
}
