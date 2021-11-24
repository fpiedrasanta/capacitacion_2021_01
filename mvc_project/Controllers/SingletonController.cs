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
using mvc_project.Models.ViewModels;

namespace mvc_project.Controllers
{
    public class SingletonController : Controller
    {
        private readonly ILogger<SingletonController> _logger;

        public SingletonController(ILogger<SingletonController> logger)
        {
            _logger = logger;
        }

        public IActionResult EjemploSingleton()
        {
            if (HttpContext.Session.GetString("SesionIniciada") == null ||
                HttpContext.Session.GetString("SesionIniciada") != "SI")
            {
                HttpContext.Session.SetString("SesionIniciada", "SI");
                RegistroVisita.Instance.Visitas++;
            }

            EjemploSingletonViewModel ejemploSingletonViewModel = new EjemploSingletonViewModel
            {
                Visitas = RegistroVisita.Instance.Visitas.ToString()
            };

            return View(ejemploSingletonViewModel);
        }
    }
}
