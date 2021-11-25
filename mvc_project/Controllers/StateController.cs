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
using mvc_project.Models.POO.StatePattern;
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class StateController : Controller
    {
        private readonly ILogger<StateController> _logger;

        public StateController(ILogger<StateController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploState()
        {
            List<ModeloPropiedad> modelosPropiedad = this.ObtenerPropiedades();

            EjemploStateViewModel ejemploStateViewModel = new EjemploStateViewModel();
            
            foreach(ModeloPropiedad modeloPropiedad in modelosPropiedad)
            {
                ejemploStateViewModel.DatosPropiedad.Add(new DatoPropiedad
                {
                    DescripcionEstado = modeloPropiedad.ObtenerDescripcionEstado(),
                    EstaDisponible = modeloPropiedad.EstaDisponible() ? "Si" : "No",
                    Color = modeloPropiedad.ObtenerColor()
                });
            }

            return View(ejemploStateViewModel);
        }

        public List<ModeloPropiedad> ObtenerPropiedades()
        {
            Random r = new Random();
            
            List<ModeloPropiedad> modelosPropiedad = new List<ModeloPropiedad>(10);

            for(int i = 0; i < 10; i++)
            {
                int numero = r.Next(1, 6);
                
                ModeloEstadoPropiedad modeloEstadoPropiedad = null;
                if(numero == 1)
                {
                    modeloEstadoPropiedad = new ModeloDisponible();
                }
                else if(numero == 2)
                {
                    modeloEstadoPropiedad = new ModeloAlquilada();
                }
                else if(numero == 3)
                {
                    modeloEstadoPropiedad = new ModeloVendida();
                }
                else if(numero == 4)
                {
                    modeloEstadoPropiedad = new ModeloReparacion();
                }

                modelosPropiedad.Add(new ModeloPropiedad(modeloEstadoPropiedad));
            }

            return modelosPropiedad;
        }
    }
}
