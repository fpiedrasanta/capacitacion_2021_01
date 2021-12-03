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
using mvc_project.Models.POO.FacadePattern;
using mvc_project.Models.POO.StatePattern;
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class FacadeController : Controller
    {
        private readonly ILogger<FacadeController> _logger;

        public FacadeController(ILogger<FacadeController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploFacade()
        {
            ModeloFacadeHouse modeloFacadeHouse = this.ObtenerModeloCasa();

            EjemploFacadeViewModel ejemploFacadeViewModel = new EjemploFacadeViewModel();

            ejemploFacadeViewModel.TotalSuperficieMetrosCuadrados = modeloFacadeHouse.ObtenerTotalMetrosCuadrados().ToString();
            ejemploFacadeViewModel.TotalVentanas = modeloFacadeHouse.ObtenerTotalVentanas().ToString();

            return View(ejemploFacadeViewModel);
        }

        private ModeloFacadeHouse ObtenerModeloCasa()
        {
            return new ModeloFacadeHouse
            {
                ModeloBanio = new ModeloBanio
                {
                    CantidadVentanas = 1,
                    MetrosCuadrados = 5
                },
                ModeloCocina = new ModeloCocina
                {
                    CantidadVentanas = 3,
                    CentimetrosCuadrados = 20 * (long) Math.Pow(100, 2)
                },
                ModeloHabitacion = new ModeloHabitacion
                {
                    CantidadVentanas = 3,
                    MetrosCuadrados = 12
                },
                ModeloPatio = new ModeloPatio
                {
                    CantidadVentanas = 0,
                    MetrosCuadrados = 325
                }
            };
        }
    }
}
